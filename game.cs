using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rr_game
{
    public class game
    {
        public int lodedgunspin;
        public int shotawayBullete = 0;
        public int shot = 0;
        public int chance = 2;
        public int shotsremain = 6;



        public void Spin() // Spin Function will spin Chamber
        {
            chngebulet(1);
        }

        public int chngebulet(int chngebul)
        {

            if (chngebul == 6)
            {
                chngebul = 1;
            }
            else
            {
                chngebul++;
            }
            return chngebul;
        }

    }
}


