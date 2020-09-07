using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokémon_Tools.Properties;

namespace Pokémon_Tools {
    public partial class form_weak : Form {
        private form_weakList weeksList;
        public List<Image> typeImages;
        private int[] defaultType = new int[18] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        public static PokeType weak;
        public static PokeType strength;
        public form_weak() {
            InitializeComponent();

            weeksList=new form_weakList(this.Width, this.Location.X, this.Location.Y);
            weeksList.Show();

            typeImages=new List<Image>();
            typeImages.Add(Resources.Normal); typeImages.Add(Resources.Fire);
            typeImages.Add(Resources.Water); typeImages.Add(Resources.Grass);
            typeImages.Add(Resources.Eletric); typeImages.Add(Resources.Ice);
            typeImages.Add(Resources.Fighting); typeImages.Add(Resources.Poison);
            typeImages.Add(Resources.Ground); typeImages.Add(Resources.Flying);
            typeImages.Add(Resources.Psychic); typeImages.Add(Resources.Bug);
            typeImages.Add(Resources.Rock); typeImages.Add(Resources.Ghost);
            typeImages.Add(Resources.Dragon); typeImages.Add(Resources.Dark);
            typeImages.Add(Resources.Steel); typeImages.Add(Resources.Fairy);
            typeImages.Add(Resources.None);

            cbx_type2.SelectedIndex=18;
            cbx_type1.SelectedIndex=18;

            weak=new PokeType(defaultType);
            strength=new PokeType(defaultType);

            Weak.SetList();
            Strength.SetList();
        }

        private void SetEffect(int type, int mode, bool unique) {
            if(mode == 0 && unique) {
                weak.Reset(defaultType);
                for(int i = 0; i<18; i++) {
                    weak.AddEffect(i, Weak.pokeTypes[type].GetEffect(i));
                }

                strength.Reset(defaultType);
                for(int i = 0; i<18; i++) {
                    strength.AddEffect(i, Strength.pokeTypes[type].GetEffect(i));
                }
            } else if(mode==0 && !unique) {
                strength.Reset(defaultType);
                weak.Reset(defaultType);

                SetEffect(cbx_type2.SelectedIndex, 1, true);

                for(int i = 0; i<18; i++) {
                    weak.AddEffect(i, Weak.pokeTypes[type].GetEffect(i));
                }

                for(int i = 0; i<18; i++) {
                    strength.AddEffect(i, Strength.pokeTypes[type].GetEffect(i));
                }
            } else if(mode==1 && unique) {
                for(int i = 0; i<18; i++) {
                    weak.AddEffect(i, Weak.pokeTypes[type].GetEffect(i));
                }

                for(int i = 0; i<18; i++) {
                    strength.AddEffect(i, Strength.pokeTypes[type].GetEffect(i));
                }
                SetEffect(0, 3, true);
            } else if(mode != 3) { //mode==1 && !unique
                SetEffect(cbx_type1.SelectedIndex, 0, true);

                for(int i = 0; i<18; i++) {
                    weak.AddEffect(i, Weak.pokeTypes[type].GetEffect(i));
                }

                for(int i = 0; i<18; i++) {
                    strength.AddEffect(i, Strength.pokeTypes[type].GetEffect(i));
                }
                
            }
            form_weakList.setMode(mode); //Seta o modo para controle de botões de vant e fraq
            form_weakList.SetEffects(); //Seta os efeitos prós e contra
        }

        private void PokeType1_SelectedIndexChanged(object sender, EventArgs e) {
            img_type1.Image=typeImages[cbx_type1.SelectedIndex];

            if(cbx_type1.SelectedIndex==18 & cbx_type2.SelectedIndex!=18) { //cbx1 for None e cbx2 não for nem None nem Default(-1)
                cbx_type1.SelectedIndex=cbx_type2.SelectedIndex;
                cbx_type2.SelectedIndex=18;
                cbx_type2.Enabled=true;

                SetEffect(cbx_type1.SelectedIndex, 0, true); //Seta o modo para controle de botões de vant e fraq / Seta os efeitos prós e contra
            } else if(cbx_type1.SelectedIndex==18 & cbx_type2.SelectedIndex==18) { //cbx1 e cbx2 forem None
                cbx_type2.Enabled=false;

                SetEffect(0, 3, true); //Seta o modo para controle de botões de vant e fraq / Seta os efeitos prós e contra
            } else if(cbx_type1.SelectedIndex == cbx_type2.SelectedIndex) { //cbx1 e cbx2 forem iguais
                cbx_type2.SelectedIndex=18;
                cbx_type2.Enabled=true;
                SetEffect(cbx_type1.SelectedIndex, 0, true);
            } else { //cbx1 == 0-17
                cbx_type2.Enabled=true;
                if(cbx_type2.SelectedIndex == 18) SetEffect(cbx_type1.SelectedIndex, 0, true);
                else SetEffect(cbx_type1.SelectedIndex, 0, false);
            }
        }
        private void PokeType2_SelectedIndexChanged(object sender, EventArgs e) {
            img_type2.Image=typeImages[cbx_type2.SelectedIndex];

            if(cbx_type1.SelectedIndex == cbx_type2.SelectedIndex) { //cbx1 e cbx2 forem iguais
                SetEffect(cbx_type1.SelectedIndex, 0, true);
                cbx_type2.SelectedIndex=18;
                cbx_type2.Enabled=true;
            } else if(cbx_type1.SelectedIndex != 18 & cbx_type2.SelectedIndex != 18) {
                SetEffect(cbx_type1.SelectedIndex, 0, false);
            }else if(cbx_type1.SelectedIndex!=18 & cbx_type1.SelectedIndex != -1 & cbx_type2.SelectedIndex == 18) {
                SetEffect(cbx_type1.SelectedIndex, 0, true);
            }
        }

        private void form_weak_LocationChanged(object sender, EventArgs e) {
            form_weakList.SetLocation(this.Width, this.Location.X, this.Location.Y);
            form_weakList.staticThis.Focus();
        }

        private void form_weak_FormClosed(object sender, FormClosedEventArgs e) {
            form_weakList.staticThis.Close();
        }

        private void form_weak_Click(object sender, EventArgs e) {
            form_weakList.staticThis.Focus(); //...Focar também no weakList
            this.Focus();
        }
    }
}
