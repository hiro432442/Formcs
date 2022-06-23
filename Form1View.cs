using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestSample
{
    public partial class Form1View : Form
    {
        private Form1ViewModel _viewModel = new Form1ViewModel();
        public Form1View()
        {
            InitializeComponent();

            //タイマ開始
            timer1.Start();
        }




        private void Button1_Click(object sender, EventArgs e)
        {
        
			//ボタンクリック処理
            _viewModel.textBox1 = textBox1.Text;
            _viewModel.textBox2 = textBox2.Text;
            _viewModel.multiplication();
            this.label1.Text = _viewModel.Label1;

        }

        private void CalculationButtom_Click(object sender, EventArgs e)
        {

            int x = System.Windows.Forms.Cursor.Position.X;
            int y = System.Windows.Forms.Cursor.Position.Y;

            _viewModel.textBox1 = textBox1.Text;
            _viewModel.textBox2 = textBox2.Text;
            _viewModel.multiplication();
            this.label1.Text = _viewModel.Label1;
            label2.Text = x.ToString();
            textBox3.Text = y.ToString();

        }
        
        

private void timer1_Tick(object sender, EventArgs e)
        {
			//タイマーで１００ms
			//what do you mean
            int x = System.Windows.Forms.Cursor.Position.X;
            int y = System.Windows.Forms.Cursor.Position.Y;
            label2.Text = x.ToString();
            textBox3.Text = y.ToString();

        }



    }
}
