
namespace MySqlTest
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.harita = new GMap.NET.WindowsForms.GMapControl();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnKonum = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(848, 655);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // harita
            // 
            this.harita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.harita.Bearing = 0F;
            this.harita.CanDragMap = true;
            this.harita.EmptyTileColor = System.Drawing.Color.Navy;
            this.harita.GrayScaleMode = false;
            this.harita.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.harita.LevelsKeepInMemory = 5;
            this.harita.Location = new System.Drawing.Point(0, 0);
            this.harita.MarkersEnabled = true;
            this.harita.MaxZoom = 2;
            this.harita.MinZoom = 2;
            this.harita.MouseWheelZoomEnabled = true;
            this.harita.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.harita.Name = "harita";
            this.harita.NegativeMode = false;
            this.harita.PolygonsEnabled = true;
            this.harita.RetryLoadTile = 0;
            this.harita.RoutesEnabled = true;
            this.harita.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.harita.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.harita.ShowTileGridLines = false;
            this.harita.Size = new System.Drawing.Size(907, 655);
            this.harita.TabIndex = 21;
            this.harita.Zoom = 0D;
            this.harita.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.White;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistance.Location = new System.Drawing.Point(786, 626);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(72, 20);
            this.lblDistance.TabIndex = 22;
            this.lblDistance.Text = "Uzaklık:";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(1012, 184);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(147, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblX.Location = new System.Drawing.Point(944, 182);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 20);
            this.lblX.TabIndex = 23;
            this.lblX.Text = "X:";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblY.Location = new System.Drawing.Point(944, 220);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(24, 20);
            this.lblY.TabIndex = 24;
            this.lblY.Text = "Y:";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(1012, 220);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(147, 20);
            this.txtBox2.TabIndex = 25;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKonum
            // 
            this.btnKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonum.Location = new System.Drawing.Point(1012, 273);
            this.btnKonum.Name = "btnKonum";
            this.btnKonum.Size = new System.Drawing.Size(117, 29);
            this.btnKonum.TabIndex = 26;
            this.btnKonum.Text = "Konum Ekle";
            this.btnKonum.UseVisualStyleBackColor = true;
            this.btnKonum.Click += new System.EventHandler(this.btnKonum_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(913, 151);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(86, 20);
            this.lblAd.TabIndex = 27;
            this.lblAd.Text = "Ad & Soyad:";
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(1012, 151);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(147, 20);
            this.txtBox3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1171, 655);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnKonum);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.harita);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Harita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl harita;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btnKonum;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtBox3;
    }
}

