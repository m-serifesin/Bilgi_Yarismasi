using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnS.Enabled = true;
            
            
            label5.Text =btnA.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnS.Enabled = true;


            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnS.Enabled = true;


            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnS.Enabled = true;


            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnS.Enabled = false;

            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            
            
            soruno++;
            lblSoru.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923"; 
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi İl Ege Bölgemizde Bulunmaz";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Manisa";
                btnD.Text = "Aydın";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazarımıza Aittir";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Reşat Nuri Gültekin";
                label4.Text = "Sait Faik Abasıyanık";
                btnS.Text = "Sonuçlar";

            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnS.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);

            }

        }
    }
}
