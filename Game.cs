﻿using System;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        int x = 0, y = 0, turn = 0;
        Random nr = new Random();
        x = nr.Next(1, 7);
        y = x + SelectDice.diceNumber;
        panel1.BackgroundImage = Image.FromFile(y + ".png");
        if (click % 2 == 1) {
            turn = 1;
        }
        else {
            turn = 2;
        }
        foreach (Player p in SelectPlayer1.playerList) {
            if(p.Number==turn) {
                switch (p.Color) {
                    case "Red": {
                        if (playerPosition[turn] + x <= 50) {
                            while (x > 0) {
                                if (playerPosition[turn] == 0) {
                                   pictureBox2.Left += 75;
                                    playerPosition[turn]++;
                                    x--;
                                }
                                while (playerPosition[turn] % 7 != 0 && x > 0) {
                                    if (positionLine[turn] % 2 == 1)
                                        pictureBox2.Left += 75;
                                    else
                                        pictureBox2.Left -= 75;
                                        x--;
                                    playerPosition[turn]++;
                                }
                                if (x > 0) {
                                    if (positionLine[turn] != 7)
                                        pictureBox2.Top -= 88;
                                    else
                                        pictureBox2.Left += 75;
                                    x--;
                                    playerPosition[turn]++;
                                    positionLine[turn]++;
                                }
                            }
                        }
                        if (playerPosition[turn] == 50) {
                            Form mod = new RedWins();
                            mod.Owner = this;
                            mod.Show();
                            this.Hide();
                        }
                        break;
                    }
                    case "Yellow": {
                        if (playerPosition[turn] + x <= 50) {
                            while (x > 0) {
                                if (playerPosition[turn] == 0) {
                                    pictureBox3.Left += 75;
                                    playerPosition[turn]++;
                                    x--;
                                }
                                while (playerPosition[turn] % 7 != 0 && x > 0) {
                                    if (positionLine[turn] % 2 == 1)
                                        pictureBox3.Left += 75;
                                    else
                                        pictureBox3.Left -= 75;
                                    x--;
                                    playerPosition[turn]++;
                                }
                                if (x > 0) {
                                    if (positionLine[turn] != 7)
                                        pictureBox3.Top -= 88;
                                    else
                                        pictureBox3.Left += 75;
                                    x--;
                                    playerPosition[turn]++;
                                    positionLine[turn]++;
                                }
                            }
                        }
                        if (playerPosition[turn] == 50) {
                            Form mod = new YellowWins();
                            mod.Owner = this;
                            mod.Show();
                            this.Hide();
                        }
                        break;
                    }
                    case "Blue": {
                        if (playerPosition[turn] + x <= 50) {
                            while (x > 0) {
                                if (playerPosition[turn] == 0) {
                                    pictureBox4.Left += 75;
                                    playerPosition[turn]++;
                                    x--;
                                }
                                while (playerPosition[turn] % 7 != 0 && x > 0) {
                                    if (positionLine[turn] % 2 == 1)
                                        pictureBox4.Left += 75;
                                    else
                                        pictureBox4.Left -= 75;
                                    x--;
                                    playerPosition[turn]++;
                                }
                                if (x > 0) {
                                    if (positionLine[turn] != 7)
                                        pictureBox4.Top -= 88;
                                    else
                                        pictureBox4.Left += 75;
                                    x--;
                                    playerPosition[turn]++;
                                    positionLine[turn]++;
                                }
                            }
                        }
                        if (playerPosition[turn] == 50) {
                            Form mod = new BlueWins();
                            mod.Owner = this;
                            mod.Show();
                            this.Hide();
                        }
                        break;
                    }
                    case "Green": {
                        if (playerPosition[turn] + x <= 50) {
                            while (x > 0) {
                                if (playerPosition[turn] == 0) {
                                    pictureBox5.Left += 75;
                                    playerPosition[turn]++;
                                    x--;
                                }
                                while (playerPosition[turn] % 7 != 0 && x > 0) {
                                    if (positionLine[turn] % 2 == 1)
                                        pictureBox5.Left += 75;
                                    else
                                        pictureBox5.Left -= 75;
                                        x--;
                                        playerPosition[turn]++;
                                }
                                if (x > 0) {
                                    if (positionLine[turn] != 7)
                                        pictureBox5.Top -= 88;
                                    else
                                        pictureBox5.Left += 75;
                                    x--;
                                    playerPosition[turn]++;
                                    positionLine[turn]++;
                                }
                            }
                        }
                        if (playerPosition[turn] == 50) {
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
}
