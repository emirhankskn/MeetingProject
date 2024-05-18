using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meetingProject
{
    public partial class LoginUI : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=193.57.41.19;user=kskn;password=26589479124Ek;database=recordmeeting;";
        public string emailP = "example@gmail.com";
        public string usernameP = "user";
        public int userIDP = 0;

        public LoginUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlMailError.Visible = false;
            pnlPasswordError.Visible = false;
            if (string.IsNullOrEmpty(txtEmail.Text)) pnlMailError.Visible = true;
            if (string.IsNullOrEmpty(txtPassword.Text)) pnlPasswordError.Visible = true;

            if (!pnlMailError.Visible && !pnlPasswordError.Visible)
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                try
                {
                    using (connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Email'in varlığını kontrol eden sorgu.
                        string emailQuery = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
                        using (MySqlCommand emailCmd = new MySqlCommand(emailQuery, connection))
                        {
                            // Email'e sahip kişi sayısını alır. Kayıt alma sırasında yazdığımız sorguya göre zaten
                            //   bir email 2.kez kayıt olamaz. Bu yüzden bu komut eğer mail varsa direkt olarak 1 sayısını verecek.
                            int emailCount = Convert.ToInt32(emailCmd.ExecuteScalar());
                            if (emailCount == 0)
                            {
                                pnlMailError.Visible = true;
                                return;// Bu return ifadesi metodu burada sonlandırır ve aşağıdaki kod çalışmaz.
                                // Bu sayede gereksiz yere şifre sorgusu yapmayız.
                            }
                        }


                        // Email ve password kullanıcının girdikleri veri tabanındakiler ile uyuşuyorsa
                        //   bu kullanıcının ID, username, email bilgilerini göster.
                        string userQuery = "SELECT ID, username, email FROM users WHERE email = @Email AND passwd = @Password";
                        using (MySqlCommand userCmd = new MySqlCommand(userQuery, connection))
                        {
                            userCmd.Parameters.AddWithValue("@Email", email);
                            userCmd.Parameters.AddWithValue("@Password", password);
                            using (MySqlDataReader reader = userCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // E-mail'ini ,kullanıcı adını ve ID'sini, yukarıda tanımlanan public değişkenlere ata.
                                    //   diğer formlarda hangi kullanıcının giriş yaptığını bilmemiz için gerekecek.
                                    emailP = reader.GetString("email");
                                    usernameP = reader.GetString("username");
                                    userIDP = reader.GetInt32("ID");
                                }
                            }
                        }

                        // Şifrenin doğruluğunu kontrol eden sorgu.
                        string passwordQuery = $"SELECT COUNT(*) FROM users WHERE email = '{email}' AND passwd = '{password}'";
                        using (MySqlCommand passwordCmd = new MySqlCommand(passwordQuery, connection))
                        {
                            // Verilen email ve şifreye sahip kullanıcı sayısını bulacak olan komuttur.
                            //   Tahmin edildiği üzere beklenmeden bir durum olmadığı sürece daima 1 sayısını verecektir.
                            int userCount = Convert.ToInt32(passwordCmd.ExecuteScalar());
                            if (userCount > 0)
                            {
                                Form mainMenu = new MainMenu(this);
                                mainMenu.Show();
                                this.Hide();
                            }
                            else pnlPasswordError.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DATABASE ERROR : " + ex.Message);
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://193.57.41.19/meeting/index.php");
        }

        private void pctrExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
