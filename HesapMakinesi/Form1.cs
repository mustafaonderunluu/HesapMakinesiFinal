namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        string islem = " ";
        bool islemsecili = false, yeniSayi;
        public Form1()
        {
            InitializeComponent();
        }
        private void Sayilar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (yeniSayi)
            {
                labelsay�.Text = " ";
                yeniSayi = false;
            }

            if (button.Text == "-/+")
            {
                if (labelsay�.Text != "")
                {
                    labelsay�.Text = "" + (double.Parse(labelsay�.Text) * -1); 
                }
            }
            else if (button.Text == ",")
            {
                if (!labelsay�.Text.Contains(","))
                {
                    labelsay�.Text += ",";
                }
            }
            else
            {
                if (labelsay�.Text == "0")
                {
                    labelsay�.Text = "";
                }
                labelsay�.Text += button.Text;
            }
        }

        private void islemler_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (islemsecili)
            {
                buttonesit.PerformClick();
            }
            else
            {
                sonuc = double.Parse(labelsay�.Text);
            }
            islem = button.Text;
            islemler.Text = sonuc + " " + islem;
            yeniSayi = true;
            islemsecili = true;
        }

        private void buttonesit_Click(object sender, EventArgs e)
        {
            if (islemsecili)
            {
                string gecmis = islemler.Text + " " + labelsay�.Text + "= ";
                switch (islem)
                {
                    case "+":
                        sonuc += double.Parse(labelsay�.Text);
                        break;
                    case "-":
                        sonuc -= double.Parse(labelsay�.Text);
                        break;
                    case "x":
                        sonuc *= double.Parse(labelsay�.Text);
                        break;
                    case "/":
                        // B�lme i�leminde s�f�ra b�lme hatas�n� kontrol et
                        if (double.Parse(labelsay�.Text) != 0)
                        {
                            sonuc /= double.Parse(labelsay�.Text);
                        }
                        else
                        {
                            labelsay�.Text = "Hata!";
                            return;
                        }
                        break;
                    default:
                        break;
                }
                labelsay�.Text = sonuc.ToString();
                listboxgecmis.Items.Add(gecmis + sonuc);
                islemler.Text = "";
                islemler.Text = sonuc + " " + islem;
            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            labelsay�.Text = "0";
            yeniSayi = true;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            button_CE.PerformClick();
            islem = "";
            islemler.Text = "";
            islemsecili = false;

        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            buttonClear.PerformClick();
            listboxgecmis.Items.Clear();

        }
    }
}
