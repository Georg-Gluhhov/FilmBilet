using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Start_form: System.Windows.Forms.Form
    {
        public static int FilmC=0;
        Label lbl;
        public Start_form()
        {
            this.Height = 400;
            this.Width = 500;
            var b = 0;

            Button Start_btn = new Button
            {
                Text = "Minu oma aken",
                Location = new System.Drawing.Point(10, 10)
            };
            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);
            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);
            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(10, 60)
            };
            this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;

            PictureBox film = new PictureBox
            {
                Image = Image.FromFile(@"..\..\Filmid\jazz.jpg"),
                Location = new System.Drawing.Point(10, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(140, 140)
            };

            PictureBox film2 = new PictureBox
            {
                Image = Image.FromFile(@"..\..\Filmid\joker.jpg"),
                Location = new System.Drawing.Point(150, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(140, 140)

            };
            PictureBox film3 = new PictureBox
            {
                Image = Image.FromFile(@"..\..\Filmid\navalny.jpg"),
                Location = new System.Drawing.Point(290, 100),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(140, 140)
            };
            lbl = new Label();
            lbl.Text = $"{FilmC}";

            lbl.Location = new Point(50, 300);
            this.Controls.Add(lbl);

            film.Click += Film_Click;
            film2.Click += Film_Click2;
            film3.Click += Film_Click3;

            RadioButton rb = new RadioButton
            {

            };

            this.Controls.Add(film);
            this.Controls.Add(film2);
            this.Controls.Add(film3);
            this.Controls.Add(lbl);
            film.Click += Film_Click;
            film2.Click += Film_Click2;
            film3.Click += Film_Click3;

        }

        private void Film_Click(object sender, EventArgs e)
        {
            FilmC = 1;
            lbl.Text = $"{FilmC}";
        }
        private void Film_Click2(object sender, EventArgs e)
        {
            FilmC = 2;
            lbl.Text = $"{FilmC}";
        }
        private void Film_Click3(object sender, EventArgs e)
        {
            FilmC = 3;
            lbl.Text = $"{FilmC}";
        }
        private void Start_btn_2_Click(object sender, EventArgs e)
        {
           
            MyForm uus_aken = new MyForm(8,5,"21");
            
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Mina olen ilus aken","Vali midagi","Üks","Kaks","Kolm","Neli");
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Start_form
            // 
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "Start_form";
            this.Load += new System.EventHandler(this.Start_form_Load);
            this.ResumeLayout(false);
        }

        private void Start_form_Load(object sender, EventArgs e)
        {

        }
    }
}
