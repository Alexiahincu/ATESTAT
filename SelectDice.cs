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
    public partial class SelectDice : Form {
        public static int diceNumber;
        public static bool selectedDice = false;
        public SelectDice() {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (selectedDice == true) {
                this.Owner.Show();
                this.Close();
                selectedDice = false;
            } else {
                MessageBox.Show("Please select the dice!");

            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            selectedDice = true;
            switch (listBox1.SelectedItem.ToString()) {
                case "Set 1": {
                        diceNumber = 0;
                        break;
                    }
                case "Set 2": {
                        diceNumber = 10;
                        break;
                    }
                case "Set 3": {
                        diceNumber = 20;
                        break;
                    }
            }
        }
    }
}

