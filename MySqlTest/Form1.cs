using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MySqlTest
{
    public partial class Form1 : Form
    {

        public List<PointLatLng> points = new List<PointLatLng>();
        public static List<String> koordinatlarX = new List<String>();
        public static List<String> koordinatlarY = new List<String>();
        public int j = 0;
   

        public Form1()
        {
            InitializeComponent();

            GMapProviders.GoogleMap.ApiKey = @"Your API Key";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            harita.MinZoom = 5;
            harita.MaxZoom = 100;
            harita.Zoom = 10;

            harita.DragButton = MouseButtons.Left;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtBox1.Focus();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {


            string MySQLBaglanti = $"SERVER=34.133.165.154;DATABASE=kargosistemi;UID=test;PWD=1234";



            using (var baglan = new MySqlConnection(MySQLBaglanti))
            {
                using (var cmd = new MySqlCommand("SELECT musteri_x, musteri_y FROM musteri ", baglan))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader mdr = cmd.ExecuteReader();

                        while (mdr.Read())
                        {

                            koordinatlarX.Add(mdr["musteri_x"].ToString());
                            koordinatlarY.Add(mdr["musteri_y"].ToString());

                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata: " + hata.Message);

                    }
                }
            }


            harita.MapProvider = GMapProviders.GoogleMap;
            
            /*
            double x1 = Convert.ToDouble(koordinatlarX[0]);
            double y1 = 27.12312414;

            double x2 = 41.98987123;
            double y2 = 27.38387012;

            double x3 = 41.55551341;
            double y3 = 26.91238312;

            double x4 = 41.27272712;
            double y4 = 26.55555551;

            */

            harita.Position = new GMap.NET.PointLatLng(Convert.ToDouble(koordinatlarX[0]), Convert.ToDouble(koordinatlarY[0]));

            for (int i=0;  i<koordinatlarX.Count || i<koordinatlarX.Count; i++)
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(koordinatlarX[i]), Convert.ToDouble(koordinatlarY[i]));
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                harita.Overlays.Add(markers);

                points.Add(point);

            }

            for(int i=0; i < points.Count ; i++)
            {
                var route = GoogleMapProvider.Instance.GetRoute(points[0], points[i], false, false, 14);

                /*
                yollar[i].from = 0;
                yollar[i].to = i;
                yollar[i].distance = route.Distance;
                */
                
                var r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };

                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                harita.Overlays.Add(routes);

                j = i;

                lblDistance.Text = route.Distance + " km";
            }

            /* 
             * 
            PointLatLng point = new PointLatLng(x1, y1);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

            PointLatLng point1 = new PointLatLng(x2, y2);
            GMapMarker marker1 = new GMarkerGoogle(point1, GMarkerGoogleType.red_dot);

            PointLatLng point2 = new PointLatLng(x3, y3);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_dot);

            PointLatLng point3 = new PointLatLng(x4, y4);
            GMapMarker marker3 = new GMarkerGoogle(point3, GMarkerGoogleType.red_dot);
            */

            /*
            points.Add(new PointLatLng(x1, y1));
            points.Add(new PointLatLng(x2, y2));
            points.Add(new PointLatLng(x3, y3));
            points.Add(new PointLatLng(x4, y4));
            */
            
            
            /*
            var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
            var route2 = GoogleMapProvider.Instance.GetRoute(points[1], points[2], false, false, 14);
            var route3 = GoogleMapProvider.Instance.GetRoute(points[2], points[3], false, false, 14);

            var r2 = new GMapRoute(route2.Points, "My Route")
            {
                Stroke = new Pen(Color.Blue, 5)
            };

            routes.Routes.Add(r2);
            harita.Overlays.Add(routes);

            var r3 = new GMapRoute(route3.Points, "My Route")
            {
                Stroke = new Pen(Color.Green, 5)
            };

            routes.Routes.Add(r3);
            harita.Overlays.Add(routes);

            */

            // lblDistance.Text = route2.Distance + " km";
           
        }

       

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKonum_Click(object sender, EventArgs e)
        {
            // MySQLBaglanti
            if (txtBox1.Text == "" || txtBox2.Text == "" || txtBox3.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz.");
            }
            else
            {
                string MySQLBaglanti = $"SERVER=34.133.165.154;DATABASE=kargosistemi;UID=test;PWD=1234";
                using (var baglan = new MySqlConnection(MySQLBaglanti))
                {
                    baglan.Open();
                    String isim;
                    String X;
                    String Y;
                    isim = txtBox3.Text;
                    X = txtBox1.Text;
                    Y = txtBox2.Text;
                    using (var cmd = new MySqlCommand("Select * FROM musteri where musteri_ad='" + isim + "'", baglan))
                    {
                        MySqlDataReader oku = cmd.ExecuteReader();
                        if (oku.Read())
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                        }
                        else
                        {
                            oku.Close();
                            MySqlCommand ekle = new MySqlCommand("insert into musteri(musteri_ad,musteri_x,musteri_y) values('" + isim + "','" + X + "','" + Y + "')", baglan);
                            ekle.ExecuteNonQuery();
                            MessageBox.Show("Konum Eklendi.");
                        }
                        baglan.Close();
                    }
                }
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtBox1.Text), Convert.ToDouble(txtBox2.Text));
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                harita.Overlays.Add(markers);

                points.Add(point);

                
                var route = GoogleMapProvider.Instance.GetRoute(points[0], points[j+1], false, false, 14);
                
                var r = new GMapRoute(route.Points, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };

                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                harita.Overlays.Add(routes);

                lblDistance.Text = route.Distance + " km";
                    
            }
        }

        private void lblY_Click(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }
    }
}
