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
    public partial class form_weakList : Form {
        private static List<PictureBox> effectTable;
        private static List<Image> effectImages;
        public static int mode; //Modo de exibição de efeitos (se é vantagens ou fraquezas)
        public static form_weakList staticThis; //Referência static a esse form para o SetLocation()
        public static List<Button> staticButtons; //Referência static aos botões ( pro setMode() )
        public form_weakList(int width, int x, int y) {
            InitializeComponent();
            staticThis=this;
            SetLocation(width, x, y);

            mode=0; //Vantagens
            staticButtons=new List<Button>();
            staticButtons.Add(btn_vant); staticButtons.Add(btn_fraq);

            effectImages=new List<Image>();
            effectImages.Add(Resources.x0); effectImages.Add(Resources.x1_4); // 0 - 1
            effectImages.Add(Resources.x1_2); effectImages.Add(Resources.x1); // 2 - 3
            effectImages.Add(Resources.x2); effectImages.Add(Resources.x4);   // 4 - 5

            effectTable =new List<PictureBox>();
            effectTable.Add(img_norX); effectTable.Add(img_firX); // 0 - 1
            effectTable.Add(img_watX); effectTable.Add(img_graX); // 2 - 3
            effectTable.Add(img_eleX); effectTable.Add(img_iceX); // 4 - 5
            effectTable.Add(img_figX); effectTable.Add(img_poiX); // 6 - 7
            effectTable.Add(img_groX); effectTable.Add(img_flyX); // 8 - 9
            effectTable.Add(img_psyX); effectTable.Add(img_bugX); // 10 - 11
            effectTable.Add(img_rocX); effectTable.Add(img_ghoX); // 12 - 13
            effectTable.Add(img_draX); effectTable.Add(img_darX); // 14 - 15
            effectTable.Add(img_steX); effectTable.Add(img_faiX); // 16 - 17
        }

        public static void SetLocation(int width, int x, int y) {
            x=x+width;
            staticThis.Location=new Point(x, y);
        }

        public static void setMode(int noTypes) {
            if(!staticButtons[0].Enabled) mode=0; //Se botão vantagens não está ativo (ele não ativo significa que o botão clicável se torna o fraquezas)
            else mode=1;

            if(noTypes == 3) mode=3; //Se passou que não tem tipos selecionados
        }

        public static void SetEffects() {
            int x = 0;
            int pos=0;
            if(mode == 0) { //Vantagens
                foreach(PictureBox v in effectTable) {
                    pos=form_weak.strength.GetEffect(x++);
                    if(pos<0) pos=0; //Previnir de x0 + x0; x0 + x1/2
                    if(pos>5) pos=5; //Previnir de x2 + x2
                    v.Image=effectImages[pos];
                }
            }else if(mode == 1) {//Fraquezas
                foreach(PictureBox v in effectTable) {
                    pos=form_weak.weak.GetEffect(x++);
                    if(pos<0) pos=0; //Previnir de x0 + x0; x0 + x1/2
                    if(pos>5) pos=5; //Previnir de x2 + x2
                    v.Image=effectImages[pos];
                }
            } else { //None
                foreach(PictureBox v in effectTable) {
                    v.Image=null;
                }
            }
        }

        private void btn_vant_Click(object sender, EventArgs e) {
            if(mode !=3) {
                mode=0;
                SetEffects();
                btn_fraq.Enabled=true;
                btn_vant.Enabled=false;
            }
        }

        private void btn_fraq_Click(object sender, EventArgs e) {
            if(mode!=3) {
                mode=1;
                SetEffects();
                btn_vant.Enabled=true;
                btn_fraq.Enabled=false;
            }
        }
    }
}
