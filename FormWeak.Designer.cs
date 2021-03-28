namespace Pokémon_Tools {
    partial class form_weak {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_weak));
            this.lbl_mais = new System.Windows.Forms.Label();
            this.img_type2 = new System.Windows.Forms.PictureBox();
            this.img_type1 = new System.Windows.Forms.PictureBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
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
            // img_type2
            // 
            this.img_type2.Image = ((System.Drawing.Image)(resources.GetObject("img_type2.Image")));
            this.img_type2.Location = new System.Drawing.Point(286, 12);
            this.img_type2.Name = "img_type2";
            this.img_type2.Size = new System.Drawing.Size(80, 80);
            this.img_type2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_type2.TabIndex = 1;
            this.img_type2.TabStop = false;
            // 
            // img_type1
            // 
            this.img_type1.Image = ((System.Drawing.Image)(resources.GetObject("img_type1.Image")));
            this.img_type1.Location = new System.Drawing.Point(12, 12);
            this.img_type1.Name = "img_type1";
            this.img_type1.Size = new System.Drawing.Size(80, 80);
            this.img_type1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_type1.TabIndex = 0;
            this.img_type1.TabStop = false;
            // 
            // BGWorker
            // 
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            // 
            // form_weak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(378, 141);
            this.Controls.Add(this.lbl_mais);
            this.Controls.Add(this.img_type2);
            this.Controls.Add(this.img_type1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_weak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokémon Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_weak_FormClosed);
            this.LocationChanged += new System.EventHandler(this.form_weak_LocationChanged);
            this.Click += new System.EventHandler(this.form_weak_Click);
            ((System.ComponentModel.ISupportInitialize)(this.img_type2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_type1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_type1;
        private System.Windows.Forms.PictureBox img_type2;
        private System.Windows.Forms.Label lbl_mais;
        private System.ComponentModel.BackgroundWorker BGWorker;
    }
}