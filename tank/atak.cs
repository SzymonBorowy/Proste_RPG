using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tank
{
    public class atak
    { 
        public int los_1;
        public int los_2;
        public atak()
        {
            Random random = new Random();
            int a = random.Next(0, 1000) % 4;
            switch (a)
            {
                case 0:
                    los_1 = 0;
                    break;

                case 1:
                    los_1 = 1;
                    break;

                case 2:
                    los_1 = 2;
                    break;

                case 3:
                    los_1 = 3;
                    break;
            }
        }

        public string atak_bohatera(int hp_potwora, int atak_bohatera)
        {
           
            return (hp_potwora - (atak_bohatera + los_1)).ToString();
        }

        public string atak_potwora(int hp_bohatera, int atak_potwora)
        {
            Random random = new Random();
            int a = random.Next(0, 1000) % 3;
            switch (a)
            {
                case 0:
                    los_2 = 0;
                    break;

                case 1:
                    los_2 = 1;
                    break;
                case 2:
                    los_2 = 2;
                    break;
            }
            return (hp_bohatera - (atak_potwora + los_2)).ToString();
        }
        
    }
}
