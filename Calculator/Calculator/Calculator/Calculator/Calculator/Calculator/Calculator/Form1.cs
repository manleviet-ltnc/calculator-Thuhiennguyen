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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;
        enum PhepToan { Cong, Tru, Nhan, Chia};
        PhepToan pheptoan;

        double nho;

        

        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NhapSo(btn.Text);
        }


        private void NhapSo(string so)
        {
            if (isTypingNumber)
                lblDisplay.Text = lblDisplay.Text + so;
            else
            {
                lblDisplay.Text = so;
                isTypingNumber = true;
            }
        }

        private void NhapPhepToan(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+": pheptoan = PhepToan.Cong; break;
                case "-": pheptoan = PhepToan.Tru; break;
                case "*": pheptoan = PhepToan.Nhan; break;
                case "/": pheptoan = PhepToan.Chia; break;
                   
            }
            double nho = double.Parse(lblDisplay.Text);
            isTypingNumber = false;
        }
    }
}
