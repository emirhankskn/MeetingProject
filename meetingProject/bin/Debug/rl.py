try:
    import assemblyai as aai
    import json
except: print('Libraries missing or damaged.')

def meetingRecord(file_url, prefix, speaker_labels=True, language = 'en', output_file = 'transcript.txt'):
    aai.settings.api_key = "137127880b2b489c821902d16a01c900"
    FILE_URL = file_url
    config  = aai.TranscriptionConfig(speaker_labels=speaker_labels, language_code=language)

    print("Transcribing file please wait...")
    print("--------------------------------")

    transcriber = aai.Transcriber()
    transcript = transcriber.transcribe(FILE_URL, config = config)
    
    speakers = {}
    maintext = ''

    try:
        for utterance in transcript.utterances:
            text = utterance.text.lower()
            if prefix.lower() in text:
                name = text[text.find(prefix) : text.find(prefix)+len(prefix)+50].split(' ')[len(prefix.split())].capitalize().strip('.,:;_-/?!')
                if name not in speakers.keys(): speakers[utterance.speaker] = name
                else: speakers[utterance.speaker] = utterance.speaker
            maintext += f"{speakers.get(utterance.speaker)}: {utterance.text}\n"
            print(f"{speakers.get(utterance.speaker)}: {utterance.text}")
            
    except TypeError: print("There's no speaking in the video.")

    with open(output_file, 'w', encoding='utf-8') as file: file.write(maintext)

    print(f"Transcribing completed. Your text saved {output_file} file.")
    print("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*")
    print("Speakers: ")
    print(speakers)
    input("Press enter to exit...")
    return maintext

try:
    with open('parameters.json', encoding='utf-8') as json_file:
        data = json.load(json_file)
        meetingRecord(prefix = data['prefix'], file_url = data['file_url'], 
                        language = data['language'], output_file = data['output_file'])
except FileNotFoundError: print("Configuration file 'parameters.json' missing, damaged or you give wrong parameters.")