namespace Calculadora
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
            this.cbxOp = new System.Windows.Forms.ComboBox();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.buttonResul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxOp
            // 
            this.cbxOp.FormattingEnabled = true;
            this.cbxOp.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOp.Location = new System.Drawing.Point(261, 253);
            this.cbxOp.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOp.Name = "cbxOp";
            this.cbxOp.Size = new System.Drawing.Size(238, 34);
            this.cbxOp.TabIndex = 0;
            this.cbxOp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Location = new System.Drawing.Point(168, 69);
            this.lblv1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(78, 26);
            this.lblv1.TabIndex = 1;
            this.lblv1.Text = "Valor 1";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Location = new System.Drawing.Point(168, 165);
            this.lblv2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(83, 26);
            this.lblv2.TabIndex = 2;
            this.lblv2.Text = "Valor 2";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblres.Location = new System.Drawing.Point(381, 524);
            this.lblres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(26, 26);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "0";
            // 
            // txtv1
            // 
            this.txtv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtv1.Location = new System.Drawing.Point(306, 69);
            this.txtv1.Margin = new System.Windows.Forms.Padding(4);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(144, 27);
            this.txtv1.TabIndex = 4;
            // 
            // txtv2
            // 
            this.txtv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtv2.Location = new System.Drawing.Point(306, 165);
            this.txtv2.Margin = new System.Windows.Forms.Padding(4);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(144, 27);
            this.txtv2.TabIndex = 5;
            // 
            // buttonResul
            // 
            this.buttonResul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResul.Location = new System.Drawing.Point(248, 455);
            this.buttonResul.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResul.Name = "buttonResul";
            this.buttonResul.Size = new System.Drawing.Size(270, 44);
            this.buttonResul.TabIndex = 6;
            this.buttonResul.Text = "Resultado";
            this.buttonResul.UseVisualStyleBackColor = true;
            this.buttonResul.Click += new System.EventHandler(this.buttonResul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 593);
            this.Controls.Add(this.buttonResul);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.cbxOp);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOp;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Button buttonResul;
    }
}

