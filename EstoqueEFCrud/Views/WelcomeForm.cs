using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEFCrud.Views
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            timer1.Start();
            this.FormClosed += WelcomeForm_FormClosed;
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar1.Value = startPoint;

            if (progressBar1.Value == 100 )
            {
                progressBar1.Value = 0;
                timer1.Stop();
                
                EstoqueView estoque = new EstoqueView();
                this.Hide();
                estoque.ShowDialog();
                this.Close();
            }
        }
    }
}
