using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrol_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int yataySayisi;
        int dikeySayisi;

        private void button1_Click(object sender, EventArgs e)
        {
            yataySayisi = Convert.ToInt32(textBox_Yatay.Text);
            dikeySayisi = Convert.ToInt32(textBox2_Dikey.Text);


            for (int i = 0; i < yataySayisi; i++)
            {
                for (int j = 0; j < dikeySayisi; j++)
                {
                    // Eklenecek buton oluşturuluyor
                    Button button = new Button();
                    button.Name = "_" + yataySayisi + "" + dikeySayisi;
                    button.Text = dikeySayisi + "," + yataySayisi;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(i * 50, j * 50);

                    // Butonun tıklama olayı için metod tanımlanıyor
                    button.Click += Button_Click;

                    // Oluşturulan buton panel üzerine
                    panel1.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Basılan buton tespit ediliyor
            Button basilanButton = sender as Button;

            // basılan butonun texti mesajbox olarak yansıtılıyor.
            MessageBox.Show(basilanButton.Text);
        }
    }
}
