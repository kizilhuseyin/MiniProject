namespace ÖDEV_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, vki;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            double mboy = boy / 100;
            double sonuc = (kilo / (mboy * mboy));
            label4.Text = Convert.ToString(sonuc);

            if (sonuc < 18.5)
            {
                label6.Text = "Zayıf : Riskli";
            }
            else if (sonuc > 18.5 && sonuc < 25)
            {
                label6.Text = "Normal : Sağlıklı";
            }
            else if (sonuc > 25 && sonuc < 30)
            {
                label6.Text = "Hafif Kilolu : Riskli";
            }
            else if (sonuc > 30 && sonuc < 35)
            {
                label6.Text = "Obez : Çok Riskli";
            }
            else if (sonuc > 35)
            {
                label6.Text = "Aşırı Obez : Tıbbi Yardım Gerekli !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();        }
    }
}