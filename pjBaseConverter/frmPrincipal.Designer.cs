namespace pjBaseConverter
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpConversão = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBase5 = new System.Windows.Forms.TextBox();
            this.labBase = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.labBinario = new System.Windows.Forms.Label();
            this.labOctal = new System.Windows.Forms.Label();
            this.labHex = new System.Windows.Forms.Label();
            this.labDecimal = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.gpConversão.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpConversão
            // 
            this.gpConversão.Controls.Add(this.btnSair);
            this.gpConversão.Controls.Add(this.txtBase5);
            this.gpConversão.Controls.Add(this.labBase);
            this.gpConversão.Controls.Add(this.txtBinary);
            this.gpConversão.Controls.Add(this.txtOctal);
            this.gpConversão.Controls.Add(this.txtHex);
            this.gpConversão.Controls.Add(this.labBinario);
            this.gpConversão.Controls.Add(this.labOctal);
            this.gpConversão.Controls.Add(this.labHex);
            this.gpConversão.Controls.Add(this.labDecimal);
            this.gpConversão.Controls.Add(this.txtDecimal);
            this.gpConversão.Location = new System.Drawing.Point(13, 12);
            this.gpConversão.Name = "gpConversão";
            this.gpConversão.Size = new System.Drawing.Size(285, 220);
            this.gpConversão.TabIndex = 0;
            this.gpConversão.TabStop = false;
            this.gpConversão.Text = "Conversão";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(191, 173);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBase5
            // 
            this.txtBase5.Location = new System.Drawing.Point(87, 133);
            this.txtBase5.MaxLength = 27;
            this.txtBase5.Name = "txtBase5";
            this.txtBase5.Size = new System.Drawing.Size(179, 20);
            this.txtBase5.TabIndex = 11;
            this.txtBase5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBase5_KeyPress);
            this.txtBase5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBase5_KeyUp);
            // 
            // labBase
            // 
            this.labBase.AutoSize = true;
            this.labBase.Location = new System.Drawing.Point(18, 139);
            this.labBase.Name = "labBase";
            this.labBase.Size = new System.Drawing.Size(40, 13);
            this.labBase.TabIndex = 9;
            this.labBase.Text = "Base 5";
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(87, 107);
            this.txtBinary.MaxLength = 63;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(179, 20);
            this.txtBinary.TabIndex = 8;
            this.txtBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinary_KeyPress);
            this.txtBinary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBinary_KeyUp);
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(87, 81);
            this.txtOctal.MaxLength = 21;
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(179, 20);
            this.txtOctal.TabIndex = 6;
            this.txtOctal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOctal_KeyPress);
            this.txtOctal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOctal_KeyUp);
            // 
            // txtHex
            // 
            this.txtHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHex.Location = new System.Drawing.Point(87, 55);
            this.txtHex.MaxLength = 15;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(179, 20);
            this.txtHex.TabIndex = 4;
            this.txtHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHex_KeyPress);
            this.txtHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHex_KeyUp);
            // 
            // labBinario
            // 
            this.labBinario.AutoSize = true;
            this.labBinario.Location = new System.Drawing.Point(18, 114);
            this.labBinario.Name = "labBinario";
            this.labBinario.Size = new System.Drawing.Size(36, 13);
            this.labBinario.TabIndex = 7;
            this.labBinario.Text = "Binary";
            // 
            // labOctal
            // 
            this.labOctal.AutoSize = true;
            this.labOctal.Location = new System.Drawing.Point(18, 88);
            this.labOctal.Name = "labOctal";
            this.labOctal.Size = new System.Drawing.Size(32, 13);
            this.labOctal.TabIndex = 5;
            this.labOctal.Text = "Octal";
            // 
            // labHex
            // 
            this.labHex.AutoSize = true;
            this.labHex.Location = new System.Drawing.Point(18, 62);
            this.labHex.Name = "labHex";
            this.labHex.Size = new System.Drawing.Size(26, 13);
            this.labHex.TabIndex = 3;
            this.labHex.Text = "Hex";
            // 
            // labDecimal
            // 
            this.labDecimal.AutoSize = true;
            this.labDecimal.Location = new System.Drawing.Point(18, 35);
            this.labDecimal.Name = "labDecimal";
            this.labDecimal.Size = new System.Drawing.Size(45, 13);
            this.labDecimal.TabIndex = 1;
            this.labDecimal.Text = "Decimal";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(87, 29);
            this.txtDecimal.MaxLength = 19;
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(179, 20);
            this.txtDecimal.TabIndex = 2;
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            this.txtDecimal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDecimal_KeyUp);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 244);
            this.Controls.Add(this.gpConversão);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Converter";
            this.gpConversão.ResumeLayout(false);
            this.gpConversão.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpConversão;
        private System.Windows.Forms.TextBox txtBase5;
        private System.Windows.Forms.Label labBase;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Label labBinario;
        private System.Windows.Forms.Label labOctal;
        private System.Windows.Forms.Label labHex;
        private System.Windows.Forms.Label labDecimal;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnSair;
    }
}

