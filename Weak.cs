using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Tools {
    public static class Weak {
        /*
        ..x2 == +=1
        ..x1 == +=0
        x1/2 == +=(-1)
        ..x0 == +=(-3)
         */
        public static PokeType Normal = new PokeType(new int[18] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, -5, 0, 0, 0, 0 });
        public static PokeType Fire = new PokeType(new int[18] { 0, -1, 1, -1, 0, -1, 0, 0, 1, 0, 0, -1, 1, 0, 0, 0, -1, -1 });
        public static PokeType Water = new PokeType(new int[18] { 0, -1, -1, 2, 2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0 });
        public static PokeType Grass = new PokeType(new int[18] { 0, 1, -1, -1, -1, 1, 0, 1, -1, 1, 0, 1, 0, 0, 0, 0, 0, 0 });
        public static PokeType Eletric = new PokeType(new int[18] { 0, 0, 0, 0, -1, 0, 0, 0, 1, -1, 0, 0, 0, 0, 0, 0, -1, 0 });
        public static PokeType Ice = new PokeType(new int[18] { 0, 1, 0, 0, 0, -1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0 });
        public static PokeType Fighting = new PokeType(new int[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, -1, -1, 0, 0, -1, 0, 1 });
        public static PokeType Poison = new PokeType(new int[18] { 0, 0, 0, -1, 0, 0, -1, -1, 1, 0, 1, -1, 0, 0, 0, 0, 0, -1 });
        public static PokeType Ground = new PokeType(new int[18] { 0, 0, 1, 1, -5, 1, 0, -1, 0, 0, 0, 0, -1, 0, 0, 0, 0, 0 });
        public static PokeType Flying = new PokeType(new int[18] { 0, 0, 0, -1, 1, 1, -1, 0, -5, 0, 0, -1, 1, 0, 0, 0, 0, 0 });
        public static PokeType Psychic = new PokeType(new int[18] { 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, -1, 1, 0, 1, 0, 1, 0, 0 });
        public static PokeType Bug = new PokeType(new int[18] { 0, 1, 0, -1, 0, 0, -1, 0, -1, 1, 0, 0, 1, 0, 0, 0, 0, 0 });
        public static PokeType Rock = new PokeType(new int[18] { -1, -1, 1, 1, 0, 0, 1, -1, 1, -1, 0, 0, 0, 0, 0, 0, 1, 0 });
        public static PokeType Ghost = new PokeType(new int[18] { -5, 0, 0, 0, 0, 0, -5, -1, 0, 0, 0, -1, 0, 1, 0, 1, 0, 0 });
        public static PokeType Dragon = new PokeType(new int[18] { 0, -1, -1, -1, -1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1 });
        public static PokeType Dark = new PokeType(new int[18] { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, -5, 1, 0, -1, 0, -1, 0, 1 });
        public static PokeType Steel = new PokeType(new int[18] { -1, 1, 0, -1, 0, -1, 1, -5, 1, -1, -1, -1, -1, 0, -1, 0, -1, -1 });
        public static PokeType Fairy = new PokeType(new int[18] { 0, 0, 0, 0, 0, 0, -1, 1, 0, 0, 0, -1, 0, 0, -5, -1, 1, 0 });

        public static List<PokeType> pokeTypes=new List<PokeType>();

        public static void SetList() {
            pokeTypes.Add(Normal); pokeTypes.Add(Fire);
            pokeTypes.Add(Water); pokeTypes.Add(Grass);
            pokeTypes.Add(Eletric); pokeTypes.Add(Ice);
            pokeTypes.Add(Fighting); pokeTypes.Add(Poison);
            pokeTypes.Add(Ground); pokeTypes.Add(Flying);
            pokeTypes.Add(Psychic); pokeTypes.Add(Bug);
            pokeTypes.Add(Rock); pokeTypes.Add(Ghost);
            pokeTypes.Add(Dragon); pokeTypes.Add(Dark);
            pokeTypes.Add(Steel); pokeTypes.Add(Fairy);
        }

        public static PokeType GetWeak(int type) {
            switch(type) {
                case 0: return Normal;
                case 1: return Fire;
                case 2: return Water;
                case 3: return Grass;
                case 4: return Eletric;
                case 5: return Ice;
                case 6: return Fighting;
                case 7: return Poison;
                case 8: return Ground;
                case 9: return Flying;
                case 10: return Psychic;
                case 11: return Bug;
                case 12: return Rock;
                case 13: return Ghost;
                case 14: return Dragon;
                case 15: return Dark;
                case 16: return Steel;
                case 17: return Fairy;
                default: return null;
            }
        }
    }
}
