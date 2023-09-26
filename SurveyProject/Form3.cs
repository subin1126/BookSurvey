using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyProject
{
    public partial class Survey_start : Form
    {
        public Survey_start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가

            Form1 showForm1 = new Form1();

            showForm1.ShowDialog();
        }

        private void Survey_start_Load(object sender, EventArgs e)
        {

        }
    }
}
