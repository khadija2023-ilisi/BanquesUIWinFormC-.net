
namespace BanquesUI24
{
    partial class AddCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ajouter = new FontAwesome.Sharp.IconButton();
            this.solde = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.num = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.IndianRed;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(136, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter Compte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom3;
            this.kryptonLabel4.Location = new System.Drawing.Point(136, 203);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(81, 20);
            this.kryptonLabel4.TabIndex = 20;
            this.kryptonLabel4.Values.Text = "Solde Initiale";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom3;
            this.kryptonLabel3.Location = new System.Drawing.Point(136, 113);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel3.TabIndex = 19;
            this.kryptonLabel3.Values.Text = "Numero de compte";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.IndianRed;
            this.ajouter.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.ajouter.IconColor = System.Drawing.Color.Black;
            this.ajouter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ajouter.IconSize = 40;
            this.ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ajouter.Location = new System.Drawing.Point(177, 311);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(147, 45);
            this.ajouter.TabIndex = 17;
            this.ajouter.Text = "Ajouter";
            this.ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.UseWaitCursor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // solde
            // 
            this.solde.Location = new System.Drawing.Point(142, 245);
            this.solde.Name = "solde";
            this.solde.Palette = this.kryptonPalette1;
            this.solde.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.solde.Size = new System.Drawing.Size(221, 23);
            this.solde.TabIndex = 14;
            this.solde.UseWaitCursor = true;
            this.solde.TextChanged += new System.EventHandler(this.CIN_TextChanged);
            this.solde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solde_KeyPress);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(136, 152);
            this.num.Name = "num";
            this.num.Palette = this.kryptonPalette1;
            this.num.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.num.Size = new System.Drawing.Size(227, 23);
            this.num.TabIndex = 13;
            this.num.UseWaitCursor = true;
            this.num.TextChanged += new System.EventHandler(this.Prenom_TextChanged);
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // AddCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 430);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label1);
            this.Name = "AddCompte";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompte";
            this.Load += new System.EventHandler(this.AddCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private FontAwesome.Sharp.IconButton ajouter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox solde;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox num;
    }
}