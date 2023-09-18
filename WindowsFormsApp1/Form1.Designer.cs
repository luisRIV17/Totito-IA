namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbturno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcp = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.gato;
            this.pictureBox1.Location = new System.Drawing.Point(122, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turno:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbturno
            // 
            this.lbturno.AutoSize = true;
            this.lbturno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbturno.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbturno.Location = new System.Drawing.Point(181, 18);
            this.lbturno.Name = "lbturno";
            this.lbturno.Size = new System.Drawing.Size(75, 19);
            this.lbturno.TabIndex = 2;
            this.lbturno.Text = "Jugador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(797, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jugador:";
            // 
            // lbpj
            // 
            this.lbpj.AutoSize = true;
            this.lbpj.BackColor = System.Drawing.Color.Transparent;
            this.lbpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpj.ForeColor = System.Drawing.Color.Red;
            this.lbpj.Location = new System.Drawing.Point(885, 83);
            this.lbpj.Name = "lbpj";
            this.lbpj.Size = new System.Drawing.Size(18, 19);
            this.lbpj.TabIndex = 4;
            this.lbpj.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(752, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Computadora:";
            // 
            // lbcp
            // 
            this.lbcp.AutoSize = true;
            this.lbcp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcp.ForeColor = System.Drawing.Color.Yellow;
            this.lbcp.Location = new System.Drawing.Point(885, 140);
            this.lbcp.Name = "lbcp";
            this.lbcp.Size = new System.Drawing.Size(18, 19);
            this.lbcp.TabIndex = 6;
            this.lbcp.Text = "0";
            // 
            // btn00
            // 
            this.btn00.FlatAppearance.BorderSize = 0;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.ForeColor = System.Drawing.Color.Orange;
            this.btn00.Location = new System.Drawing.Point(155, 109);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(127, 146);
            this.btn00.TabIndex = 7;
            this.btn00.Tag = "1";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btna1_Click);
            // 
            // btn01
            // 
            this.btn01.FlatAppearance.BorderSize = 0;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.ForeColor = System.Drawing.Color.Orange;
            this.btn01.Location = new System.Drawing.Point(313, 109);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(233, 146);
            this.btn01.TabIndex = 8;
            this.btn01.Tag = "1";
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.ForeColor = System.Drawing.Color.Orange;
            this.btn11.Location = new System.Drawing.Point(313, 277);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(233, 146);
            this.btn11.TabIndex = 9;
            this.btn11.Tag = "2";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.FlatAppearance.BorderSize = 0;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.ForeColor = System.Drawing.Color.Orange;
            this.btn21.Location = new System.Drawing.Point(313, 446);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(233, 133);
            this.btn21.TabIndex = 10;
            this.btn21.Tag = "3";
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.ForeColor = System.Drawing.Color.Orange;
            this.btn10.Location = new System.Drawing.Point(155, 277);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(127, 146);
            this.btn10.TabIndex = 11;
            this.btn10.Tag = "2";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.FlatAppearance.BorderSize = 0;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.ForeColor = System.Drawing.Color.Orange;
            this.btn20.Location = new System.Drawing.Point(155, 446);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(127, 133);
            this.btn20.TabIndex = 12;
            this.btn20.Tag = "3";
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.FlatAppearance.BorderSize = 0;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.ForeColor = System.Drawing.Color.Orange;
            this.btn12.Location = new System.Drawing.Point(580, 277);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(139, 146);
            this.btn12.TabIndex = 13;
            this.btn12.Tag = "2";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.FlatAppearance.BorderSize = 0;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.ForeColor = System.Drawing.Color.Orange;
            this.btn02.Location = new System.Drawing.Point(580, 109);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(139, 146);
            this.btn02.TabIndex = 14;
            this.btn02.Tag = "1";
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.FlatAppearance.BorderSize = 0;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.ForeColor = System.Drawing.Color.Orange;
            this.btn22.Location = new System.Drawing.Point(581, 450);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(139, 133);
            this.btn22.TabIndex = 16;
            this.btn22.Tag = "3";
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGreen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(777, 510);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 82);
            this.button9.TabIndex = 17;
            this.button9.Text = "Reiniciar";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 613);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.lbcp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbpj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbturno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOTITO IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbturno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcp;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
    }
}

