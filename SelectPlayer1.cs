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

    public partial class SelectPlayer1 : Form {
        public static List<Player> playerList = new List<Player>();
        public static List<Color> colorList = new List<Color>();
        public static bool ok = false;
        public SelectPlayer1() {
            InitializeComponent();
            colorList.Add(new Color("Red", 1, false, false));
            colorList.Add(new Color("Yellow", 2, false, false));
            colorList.Add(new Color("Blue", 3, false, false));
            colorList.Add(new Color("Green", 4, false, false));
        }
            

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(Color c in colorList) {
                if (c.Name == listBox1.SelectedItem.ToString()) {
                    c.Used = true;
                    c.Definitive = true;
                    ok = true;
                }
                else {
                    c.Definitive = false;
                }
            }
        }
        
        private void Button1_Click(object sender, EventArgs e) {
            if (ok == true) {
                playerList.Add(new Player(listBox1.SelectedItem.ToString(), 1, true));
                Form mod = new SelectPlayer2();
                mod.Owner = this;
                mod.Show();
                this.Hide();
            } else {
                MessageBox.Show("You must select a color for Player1!! :(");
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            ok = false;
            this.Owner.Show();
            this.Close();
        }
   
    }
}
