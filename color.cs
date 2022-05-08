using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATESTAT {
    public class Color {
        private string name;
        private int number;
        private bool used;
        private bool definitive;
        public Color(string nm, int nb, bool usd, bool def) {
            this.name = nm;
            this.number = nb;
            this.used = usd;
            this.definitive = def;
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Number {
            get { return number; }
            set { number = value; }
        }
        public bool Used {
            get { return used; }
            set { used = value; }
        }
        public bool Definitive {
            get { return definitive; }
            set { definitive = value; }
        }
        ~Color() {
        }
    }
}
