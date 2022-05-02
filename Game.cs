using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ATESTAT {
    public partial class Game : Form {
        public static int[] playerPosition = new int[3];
        public static int[] positionLine = new int[3];
        public static bool finished = false;
        public Game() {    
        InitializeComponent();
            playerPosition[1] = playerPosition[2] = 0;
            positionLine[1] = positionLine[2] = 1;
        this.ControlBox = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            foreach (Color c in SelectPlayer1.colorList) {
                if (c.Definitive == true) {
                    switch (c.Number) {
                        case 1: {
                                pictureBox2.Visible = true;  
                                break;
                            }
                        case 2: {
                                pictureBox3.Visible = true;
                                break;
                            }
                        case 3: {
                                pictureBox4.Visible = true;
                                break;
                            }
                        case 4: {
                                pictureBox5.Visible = true;
                                break;
                            }
                    }
                    
                }

            }
        }
             public static int click = 0;
             public static bool redFound, yelFound, bluFound, grnFound;
    private void Button1_Click(object sender, EventArgs e) {
        string message = "Do you want to close this window?";
        string title = "Close Window";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, title, buttons);
        if (result == DialogResult.Yes) {
            click = 0;
            SelectPlayer1.ok = false;
            SelectPlayer2.ok2 = false;
            SelectPlayer1.playerList.Clear();
            this.Owner.Owner.Owner.Show();
            this.Owner.Close();
            this.Close();
        }
    }


    private void Button2_Click(object sender, EventArgs e) {
        click++;
        int i = 0, n = 0, x = 0, y = 0;
        Random nr = new Random();
        n = nr.Next(1, 21) + 20;
        for (i = 1; i <= n; i++) {
            x = nr.Next(1, 7);
            y = x + SelectDice.diceNumber;
            panel1.BackgroundImage = Image.FromFile(y + ".png");
            panel1.Refresh();
        }
        if(click%2==1) {
                foreach (Player p in SelectPlayer1.playerList) {
                    if(p.Number==1) {
                        switch(p.Color) {
                            case "Red": {
                                    if (playerPosition[1] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[1] == 0) {
                                                pictureBox2.Left += 95;
                                                playerPosition[1]++;
                                                x--;
                                            }
                                            while (playerPosition[1] % 5 != 0 && x > 0) {
                                                if (positionLine[1] % 2 == 1)
                                                    pictureBox2.Left += 95;
                                                else
                                                    pictureBox2.Left -= 95;
                                                x--;
                                                playerPosition[1]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[1] != 5)
                                                    pictureBox2.Top -= 100;
                                                else
                                                    pictureBox2.Left += 95;
                                                x--;
                                                playerPosition[1]++;
                                                positionLine[1]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[1] == 26) {
                                        Form mod = new RedWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Yellow": {
                                    if (playerPosition[1] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[1] == 0) {
                                                pictureBox3.Left += 95;
                                                playerPosition[1]++;
                                                x--;
                                            }
                                            while (playerPosition[1] % 5 != 0 && x > 0) {
                                                if (positionLine[1] % 2 == 1)
                                                    pictureBox3.Left += 95;
                                                else
                                                    pictureBox3.Left -= 95;
                                                x--;
                                                playerPosition[1]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[1] != 5)
                                                    pictureBox3.Top -= 100;
                                                else
                                                    pictureBox3.Left += 95;
                                                x--;
                                                playerPosition[1]++;
                                                positionLine[1]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[1] == 26) {
                                        Form mod = new YellowWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Blue": {
                                    if (playerPosition[1] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[1] == 0) {
                                                pictureBox4.Left += 95;
                                                playerPosition[1]++;
                                                x--;
                                            }
                                            while (playerPosition[1] % 5 != 0 && x > 0) {
                                                if (positionLine[1] % 2 == 1)
                                                    pictureBox4.Left += 95;
                                                else
                                                    pictureBox4.Left -= 95;
                                                x--;
                                                playerPosition[1]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[1] != 5)
                                                    pictureBox4.Top -= 100;
                                                else
                                                    pictureBox4.Left += 95;
                                                x--;
                                                playerPosition[1]++;
                                                positionLine[1]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[1] == 26) {
                                        Form mod = new BlueWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Green": {
                                    if (playerPosition[1] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[1] == 0) {
                                                pictureBox5.Left += 95;
                                                playerPosition[1]++;
                                                x--;
                                            }
                                            while (playerPosition[1] % 5 != 0 && x > 0) {
                                                if (positionLine[1] % 2 == 1)
                                                    pictureBox5.Left += 95;
                                                else
                                                    pictureBox5.Left -= 95;
                                                x--;
                                                playerPosition[1]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[1] != 5)
                                                    pictureBox5.Top -= 100;
                                                else
                                                    pictureBox5.Left += 95;
                                                x--;
                                                playerPosition[1]++;
                                                positionLine[1]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[1] == 26) {
                                        Form mod = new GreenWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
        else {
                foreach (Player p in SelectPlayer1.playerList) {
                    if (p.Number == 2) {
                        switch (p.Color) {
                            case "Red": {
                                    if (playerPosition[2] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[2] == 0) {
                                                pictureBox2.Left += 95;
                                                playerPosition[2]++;
                                                x--;
                                            }
                                            while (playerPosition[2] % 5 != 0 && x > 0) {
                                                if (positionLine[2] % 2 == 1)
                                                    pictureBox2.Left += 95;
                                                else
                                                    pictureBox2.Left -= 95;
                                                x--;
                                                playerPosition[2]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[2] != 5)
                                                    pictureBox2.Top -= 100;
                                                else
                                                    pictureBox2.Left += 95;
                                                x--;
                                                playerPosition[2]++;
                                                positionLine[2]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[2] == 26) {
                                        Form mod = new RedWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Yellow": {
                                    if (playerPosition[2] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[2] == 0) {
                                                pictureBox3.Left += 95;
                                                playerPosition[2]++;
                                                x--;
                                            }
                                            while (playerPosition[2] % 5 != 0 && x > 0) {
                                                if (positionLine[2] % 2 == 1)
                                                    pictureBox3.Left += 95;
                                                else
                                                    pictureBox3.Left -= 95;
                                                x--;
                                                playerPosition[2]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[2] != 5)
                                                    pictureBox3.Top -= 100;
                                                else
                                                    pictureBox3.Left += 95;
                                                x--;
                                                playerPosition[2]++;
                                                positionLine[2]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[2] == 26) {
                                        Form mod = new YellowWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Blue": {
                                    if (playerPosition[2] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[2] == 0) {
                                                pictureBox4.Left += 95;
                                                playerPosition[2]++;
                                                x--;
                                            }
                                            while (playerPosition[2] % 5 != 0 && x > 0) {
                                                if (positionLine[2] % 2 == 1)
                                                    pictureBox4.Left += 95;
                                                else
                                                    pictureBox4.Left -= 95;
                                                x--;
                                                playerPosition[2]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[2] != 5)
                                                    pictureBox4.Top -= 100;
                                                else
                                                    pictureBox4.Left += 95;
                                                x--;
                                                playerPosition[2]++;
                                                positionLine[2]++;
                                            }
                                        }
                                    }
                                    if (playerPosition[2] == 26) {
                                        Form mod = new BlueWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                            case "Green": {
                                    if (playerPosition[2] + x <= 26) {
                                        while (x > 0) {
                                            if (playerPosition[2] == 0) {
                                                pictureBox5.Left += 95;
                                                playerPosition[2]++;
                                                x--;
                                            }
                                            while (playerPosition[2] % 5 != 0 && x > 0) {
                                                if (positionLine[2] % 2 == 1)
                                                    pictureBox5.Left += 95;
                                                else
                                                    pictureBox5.Left -= 95;
                                                x--;
                                                playerPosition[2]++;
                                            }
                                            if (x > 0) {
                                                if (positionLine[2] != 5)
                                                    pictureBox5.Top -= 100;
                                                else
                                                    pictureBox5.Left += 95;
                                                x--;
                                                playerPosition[2]++;
                                                positionLine[2]++;
                                            }
                                        }
                                    }
                                    if(playerPosition[2]==26) {
                                        Form mod = new GreenWins();
                                        mod.Owner = this;
                                        mod.Show();
                                        this.Hide();
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
    }

        private void PictureBox3_Click(object sender, EventArgs e) {

        }

        private void Game_Load(object sender, EventArgs e) {

    }

    private void Panel1_Paint(object sender, PaintEventArgs e) {

    }
    
    private void PictureBox2_Click(object sender, EventArgs e) {
            
    }
    }
}
