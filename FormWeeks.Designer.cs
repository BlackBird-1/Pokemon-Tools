namespace Pokémon_Tools {
    partial class form_weeks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_mais = new System.Windows.Forms.Label();
            this.cbx_type1 = new System.Windows.Forms.ComboBox();
            this.cbx_type2 = new System.Windows.Forms.ComboBox();
            this.img_type2 = new System.Windows.Forms.PictureBox();
            this.img_type1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_type2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_type1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_mais
            // 
            this.lbl_mais.AutoSize = true;
            this.lbl_mais.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(181)))), ((int)(((byte)(172)))));
            this.lbl_mais.Location = new System.Drawing.Point(153, 13);
            this.lbl_mais.Name = "lbl_mais";
            this.lbl_mais.Size = new System.Drawing.Size(72, 77);
            this.lbl_mais.TabIndex = 2;
            this.lbl_mais.Text = "+";
            // 
            // cbx_type1
            // 
            this.cbx_type1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cbx_type1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_type1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_type1.ForeColor = System.Drawing.Color.White;
            this.cbx_type1.FormattingEnabled = true;
            this.cbx_type1.Items.AddRange(new object[] {
            "Selecionar",
            "Bug",
            "Dark ",
            "Dragon",
            "Eletric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Posion",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.cbx_type1.Location = new System.Drawing.Point(12, 98);
            this.cbx_type1.Name = "cbx_type1";
            this.cbx_type1.Size = new System.Drawing.Size(138, 30);
            this.cbx_type1.TabIndex = 3;
            this.cbx_type1.Text = "Selecionar";
            // 
            // cbx_type2
            // 
            this.cbx_type2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cbx_type2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_type2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_type2.ForeColor = System.Drawing.Color.White;
            this.cbx_type2.FormattingEnabled = true;
            this.cbx_type2.Items.AddRange(new object[] {
            "Selecionar",
            "Bug",
            "Dark ",
            "Dragon",
            "Eletric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Posion",
            "Psychic",
            "Rock",
            "Steel",
            "Water"});
            this.cbx_type2.Location = new System.Drawing.Point(228, 98);
            this.cbx_type2.Name = "cbx_type2";
            this.cbx_type2.Size = new System.Drawing.Size(138, 30);
            this.cbx_type2.TabIndex = 4;
            this.cbx_type2.Text = "Selecionar";
            // 
            // img_type2
            // 
            this.img_type2.Location = new System.Drawing.Point(286, 12);
            this.img_type2.Name = "img_type2";
            this.img_type2.Size = new System.Drawing.Size(80, 80);
            this.img_type2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_type2.TabIndex = 1;
            this.img_type2.TabStop = false;
            // 
            // img_type1
            // 
            this.img_type1.Image = global::Pokémon_Tools.Properties.Resources.Teste;
            this.img_type1.Location = new System.Drawing.Point(12, 12);
            this.img_type1.Name = "img_type1";
            this.img_type1.Size = new System.Drawing.Size(80, 80);
            this.img_type1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_type1.TabIndex = 0;
            this.img_type1.TabStop = false;
            // 
            // form_weeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(378, 141);
            this.Controls.Add(this.cbx_type2);
            this.Controls.Add(this.cbx_type1);
            this.Controls.Add(this.lbl_mais);
            this.Controls.Add(this.img_type2);
            this.Controls.Add(this.img_type1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_weeks";
            this.Text = "Pokémon Weeks";
            ((System.ComponentModel.ISupportInitialize)(this.img_type2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_type1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_type1;
        private System.Windows.Forms.PictureBox img_type2;
        private System.Windows.Forms.Label lbl_mais;
        private System.Windows.Forms.ComboBox cbx_type1;
        private System.Windows.Forms.ComboBox cbx_type2;
    }
}