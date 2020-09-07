using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokémon_Tools {
    /*
    ..x2 == +=1
    ..x1 == +=0
    x1/2 == +=(-1)
    ..x0 == +=(-2) ou recebe 0 (=0)
     */
    public class PokeType {
        public int normal;
        public int fire;
        public int water;
        public int grass;
        public int eletric;
        public int ice;
        public int fighting;
        public int poison;
        public int ground;
        public int flying;
        public int psychic;
        public int bug;
        public int rock;
        public int ghost;
        public int dragon;
        public int dark;
        public int steel;
        public int fairy;

        public PokeType(int[] effect) {
            normal=effect[0];
            fire=effect[1];
            water=effect[2];
            grass=effect[3];
            eletric=effect[4];
            ice=effect[5];
            fighting=effect[6];
            poison=effect[7];
            ground=effect[8];
            flying=effect[9];
            psychic=effect[10];
            bug=effect[11];
            rock=effect[12];
            ghost=effect[13];
            dragon=effect[14];
            dark=effect[15];
            steel=effect[16];
            fairy=effect[17];
        }
        public void Reset(int[] effect) {
            normal=effect[0];
            fire=effect[1];
            water=effect[2];
            grass=effect[3];
            eletric=effect[4];
            ice=effect[5];
            fighting=effect[6];
            poison=effect[7];
            ground=effect[8];
            flying=effect[9];
            psychic=effect[10];
            bug=effect[11];
            rock=effect[12];
            ghost=effect[13];
            dragon=effect[14];
            dark=effect[15];
            steel=effect[16];
            fairy=effect[17];
        }

        public void AddEffect(int type, int value) {
            switch(type) {
                case 0: normal+=value; break;
                case 1: fire+=value; break;
                case 2: water+=value; break;
                case 3: grass+=value; break;
                case 4: eletric+=value; break;
                case 5: ice+=value; break;
                case 6: fighting+=value; break;
                case 7: poison+=value; break;
                case 8: ground+=value; break;
                case 9: flying+=value; break;
                case 10: psychic+=value; break;
                case 11: bug+=value; break;
                case 12: rock+=value; break;
                case 13: ghost+=value; break;
                case 14: dragon+=value; break;
                case 15: dark+=value; break;
                case 16: steel+=value; break;
                case 17: fairy+=value; break;
                default: return;
            }
        }

        public int GetEffect(int type) {
            switch(type) {
                case 0: return normal;
                case 1: return fire;
                case 2: return water;
                case 3: return grass;
                case 4: return eletric;
                case 5: return ice;
                case 6: return fighting;
                case 7: return poison;
                case 8: return ground;
                case 9: return flying;
                case 10: return psychic;
                case 11: return bug;
                case 12: return rock;
                case 13: return ghost;
                case 14: return dragon;
                case 15: return dark;
                case 16: return steel;
                case 17: return fairy;
                default: return 0;
            }
        }
    }
}
