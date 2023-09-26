using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Török_Levente_BejegyzesProjekt
{
    internal class Bejegyzes
    {
            private string szerzo;
            private string tartalom;
            private int likeok;
            private DateTime letrejott;
            private DateTime szerkesztve;

            public Bejegyzes(string szerzo, string tartalom)
            {
                this.szerzo = szerzo;
                this.tartalom = tartalom;
                this.likeok = 0;
                szerkesztve = DateTime.Now;
                letrejott = DateTime.Now;
            }

            public string Szerzo { get => szerzo; }
            public string Tartalom { get => tartalom; set => szerkesztve = DateTime.Now; }
            public int Likeok { get => likeok; }
            public DateTime Letrejott { get => letrejott; set => szerkesztve = DateTime.Now; }
            public DateTime Szerkesztve { get => szerkesztve; }

            public void Like()
            {
                likeok++;
            }


            public override string ToString()
            {
                return $"{this.szerzo} - {this.likeok} - {this.letrejott} \nSzerkesztve: {this.szerkesztve} \n{this.tartalom}\n";
            }

    }
}


