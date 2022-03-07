using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;


namespace MySqlTest
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            GMapProviders.GoogleMap.ApiKey = @"AIzaSyDjMyeORm1t3nK01oklJfUc6LiFyySQYnM";
            
        }

        MySqlConnection baglanti = new MySqlConnection(@"SERVER=34.133.165.154;DATABASE=kargosistemi;UID=test;PWD=1234");

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {

        }


        private void lblPassCha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            textBox3.Text = txtUsername.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
            else
            {
            baglanti.Open();
            string user;
            string password;
            user = textBox3.Text;
            password = textBox4.Text;

            MySqlCommand sorgu = new MySqlCommand("Select * FROM kullanicilar where kullanici_adi = '"+user+"'",baglanti);
            MySqlDataReader oku = sorgu.ExecuteReader();

            if (oku.Read())
            {
                oku.Close();
                MySqlCommand guncelle = new MySqlCommand("update kullanicilar set sifre='"+password+"' where kullanici_adi='"+user+"'",baglanti);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Şifreniz değiştirildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız hatalıdır.");
            }
            baglanti.Close();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            using (var baglan = baglanti)
            {
                using (var cmd = new MySqlCommand("SELECT musteri_x, musteri_y FROM musteri ", baglan))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader mdr = cmd.ExecuteReader();

                        while (mdr.Read())
                        {
                            listBox1.Items.Add(mdr["musteri_x"]);
                            listBox2.Items.Add(mdr["musteri_y"]);

                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata: " + hata.Message);

                    }
                }
            }

            try
            {
                baglanti.Open();
                string sql = "Select * From kullanicilar where kullanici_adi = @adi AND sifre = @sifresi";
                MySqlParameter prm1 = new MySqlParameter("adi", txtUsername.Text.Trim());
                MySqlParameter prm2 = new MySqlParameter("sifresi", txtPass.Text.Trim());

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form1 fr = new Form1();
                    fr.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }


        }

        private void btnRegis_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
            else
            {
                baglanti.Open();
                string user;
                string password;
                user = txtUsername.Text;
                password = txtPass.Text;

                MySqlCommand komut = new MySqlCommand("Select * FROM kullanicilar where kullanici_adi='" + user + "'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                }
                else
                {
                    oku.Close();
                    MySqlCommand ekle = new MySqlCommand("insert into kullanicilar(kullanici_adi,sifre) values('" + user + "','" + password + "')", baglanti);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt oluşturuldu.");
                }
                baglanti.Close();

            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
