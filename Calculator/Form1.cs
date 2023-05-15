using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private char _islem;
        private bool _ekranTemizlenecekMi;
        private float _ilksayi;

        private void button1_Click(object sender, EventArgs e) //birinci buton ekrana bir yazdıracak
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = ""; //ekrana girilen sayıyı yaz
                _ekranTemizlenecekMi = false; 
            }

            if (Screen.Text == "0") Screen.Text = "";
                Screen.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                Screen.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (Screen.Text == "0") Screen.Text = "";
            Screen.Text += "0";
        }

        private void additionButton_Click(object sender, EventArgs e)//toplama işlemi butonu
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(Screen.Text);
        }

        private void equalButton_Click(object sender, EventArgs e) //sonuç butonu eşittir işareti
        {
            float ikinciSayi = Convert.ToInt32(Screen.Text);
            float sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;

                default: 
                sonuc = 0;
                    break;
            }
            
            Screen.Text = Convert.ToString(sonuc);
        }

        private void extractionButton_Click(object sender, EventArgs e)//çıkarma işlemi butonu
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(Screen.Text);
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(Screen.Text);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(Screen.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            Screen.Text = (_ilksayi + ",");            
            _ekranTemizlenecekMi = false;
        }

        private void percentileButton_Click(object sender, EventArgs e)
        {
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
        //değeri int verdiğim için yüzdelik ve ondalık ekleyemiyorum,buna bakılacak, önemli!!**
        //ekrandan tek bir sayıyı silebilmeliyim(hepsini değil), buna da bak!!
    }
}
