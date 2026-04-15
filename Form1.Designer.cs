namespace BingoMaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumeroGrande = new Label();
            btnSortear = new Button();
            btnReiniciar = new Button();
            lsthistorico = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNumeroGrande
            // 
            lblNumeroGrande.AutoSize = true;
            lblNumeroGrande.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroGrande.Location = new Point(270, 9);
            lblNumeroGrande.Name = "lblNumeroGrande";
            lblNumeroGrande.Size = new Size(246, 191);
            lblNumeroGrande.TabIndex = 0;
            lblNumeroGrande.Text = "00";
            lblNumeroGrande.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(22, 232);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(189, 64);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "SORTEAR PRÓXMO";
            btnSortear.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(552, 232);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(189, 64);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "REINICIAR JOGO";
            btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // lsthistorico
            // 
            lsthistorico.FormattingEnabled = true;
            lsthistorico.Location = new Point(9, 359);
            lsthistorico.Name = "lsthistorico";
            lsthistorico.Size = new Size(778, 304);
            lsthistorico.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 331);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 4;
            label1.Text = "HISTÓRICO DE SORTEIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 685);
            Controls.Add(label1);
            Controls.Add(lsthistorico);
            Controls.Add(btnReiniciar);
            Controls.Add(btnSortear);
            Controls.Add(lblNumeroGrande);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroGrande;
        private Button btnSortear;
        private Button btnReiniciar;
        private ListBox lsthistorico;
        private Label label1;
    }
}
