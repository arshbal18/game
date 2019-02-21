using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_russinan_roullete
{
    class shooted
    {
        public int loaded;
        public int shoted = 0;
        public int spined;
        public int sco;
        int k;



        public int spinner(int Spin) //returns the vale of spin +1 if spin is equal to 6 then spin will be set to 1
        {
            if (Spin == 6)
            {
                Spin = 1;

            }
            else
            {
                Spin++;

            }

            return Spin;

        }

        public int mainshoot(int score) //returns the vale of spin +1 if spin is equal to 6 then spin will be set to 1
        {
            for (k = 0; k <= 2; k++) // its is for loop which runs 2 times

            {
                if (shoted == 0 && loaded == spined)
                {
                    shoted = 3;
                    score = 10;

                    break;
                }
                else if (shoted == 1 && loaded != spined)
                {

                    score = 0;
                    break;
                }

                else if (shoted == 1 && loaded == spined)
                {
                    shoted = 3;


                    score = 5;
                    break;

                }

                else
                {
                    shoted = 1; // this sets the value of shot to 1
                    spined = spinner(spined);
                }

                
            }
            return score;
        }
    }
    
}
