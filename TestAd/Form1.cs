using System;
using System.Windows.Forms;

namespace TestAd
{
    public partial class Form1 : Form
    {

        CalcAndOutput calc;
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            calc = new CalcAndOutput();
            clickImage.Image = calc.ReturnBanner();
            SetInfo();
        }

        private void clickImage_Click(object sender, EventArgs e)
        {
            calc.BannerEarning[calc.Id]++;
            clickImage.Image = calc.ReturnBanner();
            SetInfo();
        }

        private void refreshClick_Click(object sender, EventArgs e)
        {
            clickImage.Image = calc.ReturnBanner();
            SetInfo();
        }
        private void SetInfo() 
        {
            textBoxOneOutput.Text = calc.BannerOutput[0].ToString();
            textBoxTwoOutput.Text = calc.BannerOutput[1].ToString();
            textBoxThreeOutput.Text = calc.BannerOutput[2].ToString();

            textBoxOneClick.Text = calc.BannerEarning[0].ToString();
            textBoxTwoClick.Text = calc.BannerEarning[1].ToString();
            textBoxThreeClick.Text = calc.BannerEarning[2].ToString();

            textBoxOneInterval.Text = calc.BannerInterval[0].ToString("F");
            textBoxTwoInterval.Text = calc.BannerInterval[1].ToString("F");
            textBoxThreeInterval.Text = calc.BannerInterval[2].ToString("F");

            textBox1.Text = (calc.BannerEarning[0]/ calc.BannerOutput[0]).ToString("F");
            textBox2.Text = (calc.BannerEarning[1] / calc.BannerOutput[1]).ToString("F");
            textBox3.Text = (calc.BannerEarning[2] / calc.BannerOutput[2]).ToString("F");
        }

        
    }
}
