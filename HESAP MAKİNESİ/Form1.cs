using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {
        char  _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel .Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "1";
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "2";
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "3";
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "4";
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "5";
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "6";
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "7";
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "8";
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "9";
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += "0";
        }

        private void ToplaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi=true;
            _ilksayi =Convert .ToInt32(ekranLabel.Text);
        }

        private void EşittirButton_Click(object sender, EventArgs e)
        {
            int ikincisayi;
            int sonuc;
            ikincisayi = Convert .ToInt32(ekranLabel.Text);

            switch (_islem )
            {
                case '+':sonuc = _ilksayi + ikincisayi;break;
                case '-':sonuc = _ilksayi - ikincisayi;break;
                case '*':sonuc = _ilksayi * ikincisayi;break;
                case '/':sonuc = _ilksayi / ikincisayi;break;
                    default:sonuc = 0;break;
            }
            ekranLabel .Text =sonuc .ToString ();
        }

        private void ÇıkartButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void ÇarpButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void BolButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void TemizlemeButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
