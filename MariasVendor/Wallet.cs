using System;
namespace MariasVendor
{
	public class Wallet
	{
        public int enkroner { get; set; } //properties
        public int femkroner { get; set; }
        public int tiokroner { get; set; }
        public int tjugolappar { get; set; }
        public int femtiolappar { get; set; }
        public int hundralappar { get; set; }

        // Constructor with coins only
        public Wallet(int enkroner, int femkroner, int tiokroner)
        {
            this.enkroner = enkroner;
            this.femkroner = femkroner;
            this.tiokroner = tiokroner;
        }

        // Constructor with all
        public Wallet(int enkroner, int femkroner, int tiokroner, int tjugolappar, int femtiolappar, int hundralappar)
        {
            this.enkroner = enkroner;
            this.femkroner = femkroner;
            this.tiokroner = tiokroner;
            this.tjugolappar = tjugolappar;
            this.femtiolappar = femtiolappar;
            this.hundralappar = hundralappar;
        }

        public int GetTotal()
        {
            return enkroner + femkroner * 5 + tiokroner * 10 + tjugolappar * 20 + femtiolappar * 50 + hundralappar * 100;
        }
    }
}

