using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawDataDecoder
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            widthValue.Text = 720+"";
            heightValue.Text = 576 + "";
            format.Text = "YUV 4:4:4";
            format.DropDownStyle = ComboBoxStyle.DropDownList;
            widthValue.TextChanged += TextChanged;
            heightValue.TextChanged += TextChanged;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            int a=0;
            if (int.TryParse(((TextBox)sender).Text, out a)) ;
            else
                ((TextBox)sender).Text = "";
        }
        

        public int getWidth()
        {
            return int.Parse(widthValue.Text);
        }
        public int getHeight()
        {
            return int.Parse(heightValue.Text);
        }
        public string getFormat()
        {
            return format.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
