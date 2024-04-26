using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meetingProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=HALIT\\SQLEXPRESS;Initial Catalog=CSharpMeetingApp;Integrated Security=True;Encrypt=False";
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUN.Text;
            string password = txtPW.Text;


            if (AuthenticateUser(username, password))
            {
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                // Hatalı kullanıcı adı veya şifre
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                txtPW.Clear();
                txtUN.Clear();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Kullanıcı kimlik doğrulama işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Username = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool AddUser(string username, string password)
        {
            bool isUserAdded = false;

            // Veritabanına kullanıcı ekleme işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Username = @Username", connection);
                checkCommand.Parameters.AddWithValue("@Username", username);
                int existingUsersCount = (int)checkCommand.ExecuteScalar();

                if (existingUsersCount == 0)
                {
                    // Kullanıcı adı zaten kullanılmıyor, yeni kullanıcı ekle
                    SqlCommand command = new SqlCommand("INSERT INTO Login (Username, Password) VALUES (@Username, @Password)", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();
                    isUserAdded = true;
                }
            }

            return isUserAdded;
        }

        private bool IsValidInput(string input)
        {
            // Özel karakterlerin bulunmadığı bir regex deseni oluşturun
            string pattern = @"^[a-zA-Z0-9_]+$";

            // Girişin boş olup olmadığını ve özel karakter içerip içermediğini kontrol edin
            if (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, pattern))
            {
                return false;
            }

            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUN.Text;
            string password = txtPW.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (IsValidInput(username) && IsValidInput(password))
                {

                    
                    if (AddUser(username, password))
                    {
                        MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten mevcut. Lütfen başka bir kullanıcı adı deneyin.");
                        txtPW.Clear();
                        txtUN.Clear();
                    }
                }

                else
                {
                    MessageBox.Show("Özel veya türkçe karakter kullanamazsınız tekrar deneyin.");
                    txtPW.Clear();
                    txtUN.Clear();
                }
            }
            else
            {
                MessageBox.Show("Kaydedilmedi Tekrar deneyiniz");
            }
        }
    }
}
