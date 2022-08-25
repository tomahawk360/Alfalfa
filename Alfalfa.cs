using System;

namespace Alfalfa {

    public class Reino {

        public Reino(string name, int power) {
            this.Name = name;
            this.Power = power;
        }

        public string Name {
            get;
            set;
        }

        public int Power {
            get;
            set;
        }

        public void incPower(int addpower){
            this.Power += addpower;
        }
        
        public void decPower(int subpower){
            this.Power -= subpower;
        }

    }
    
    public class Batalla {

        public static string ejecutar(Reino reign1, Reino reign2) {
            Random rand = new Random();

            double fac1 = (double)(reign1.Power * reign1.Power) * rand.NextDouble();
            double fac2 = (double)(reign2.Power * reign2.Power) * rand.NextDouble();

            string winner;

            if(fac1 > fac2) {
                winner = reign1.Name;

            } else if(fac1 < fac2) {
                winner = reign2.Name;

            } else {
                winner = "Empate";
            }

            return winner;
        }
    }
}
