using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATESTAT {
    public class Player {
        private string color;
        private int number;
        private bool used;
        public Player(string cl, int nb, bool usd) {
            this.color = cl;
            this.number = nb;
            this.used = usd;
        }
        public string Color {
            get { return color; }
            set { color = value; }
        }
        public int Number {
            get { return number; }
            set { number = value; }
        }
        public bool Used {
            get { return used; }
            set { used = value; }
        }

    }
}

