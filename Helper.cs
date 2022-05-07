using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATESTAT {
    public partial class Helper : Form {
        public Helper() {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Owner.Show();
            this.Close();
        }

    }
}
