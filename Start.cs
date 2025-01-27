﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATESTAT {

    public partial class Start : Form {
        public Start() {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Button1_Click(object sender, EventArgs e) {
            Form mod = new SelectPlayer1();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e) {
            Form mod = new Helper();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e) {
            string message = "Do you want to close the game?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) {
                this.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e) {
            Form mod = new SelectDice();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }
    }
}
