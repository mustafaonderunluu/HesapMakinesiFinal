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
                labelsayý.Text = " ";
                yeniSayi = false;
            }

            if (button.Text == "-/+")
            {
                if (labelsayý.Text != "")
                {
                    labelsayý.Text = "" + (double.Parse(labelsayý.Text) * -1); 
                }
            }
            else if (button.Text == ",")
            {
                if (!labelsayý.Text.Contains(","))
                {
                    labelsayý.Text += ",";
                }
            }
            else
            {
                if (labelsayý.Text == "0")
                {
                    labelsayý.Text = "";
                }
                labelsayý.Text += button.Text;
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
                sonuc = double.Parse(labelsayý.Text);
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
                string gecmis = islemler.Text + " " + labelsayý.Text + "= ";
                switch (islem)
                {
                    case "+":
                        sonuc += double.Parse(labelsayý.Text);
                        break;
                    case "-":
                        sonuc -= double.Parse(labelsayý.Text);
                        break;
                    case "x":
                        sonuc *= double.Parse(labelsayý.Text);
                        break;
                    case "/":
                        // Bölme iþleminde sýfýra bölme hatasýný kontrol et
                        if (double.Parse(labelsayý.Text) != 0)
                        {
                            sonuc /= double.Parse(labelsayý.Text);
                        }
                        else
                        {
                            labelsayý.Text = "Hata!";
                            return;
                        }
                        break;
                    default:
                        break;
                }
                labelsayý.Text = sonuc.ToString();
                listboxgecmis.Items.Add(gecmis + sonuc);
                islemler.Text = "";
                islemler.Text = sonuc + " " + islem;
            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            labelsayý.Text = "0";
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
