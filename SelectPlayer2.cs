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
    public partial class SelectPlayer2 : Form {
        public static bool ok2 = false;
        public static string color2;
        public SelectPlayer2() {
            InitializeComponent();
            this.ControlBox = false;
        }


        private void Button2_Click(object sender, EventArgs e) {
            if (ok2 == true) {
                foreach (Color c in SelectPlayer1.colorList) {
                    if (c.Name == color2)
                        c.Definitive = true;
                }

                SelectPlayer1.playerList.Add(new Player(listBox1.SelectedItem.ToString(), 2, true));
                Form mod = new Game();
                mod.Owner = this;
                mod.Show();
                this.Hide();
            } else {
                MessageBox.Show("You must select a color for Player2!! :(");
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            SelectPlayer1.playerList.Clear();
            ok2 = false;
            this.Owner.Show();
            this.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (Color c in SelectPlayer1.colorList) {
                if (c.Name == listBox1.SelectedItem.ToString()) {
                    if (c.Used == true && c.Definitive == true) {
                        MessageBox.Show("Select another color!");
                    } else {
                        color2 = c.Name;
                        c.Used = true;
                        ok2 = true;
                    }
                    break;
                }
            }
        }

        private void SelectPlayer2_Load(object sender, EventArgs e) {

        }
    }

}