namespace BingoMaster
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            lblNumeroGrande.ForeColor = Color.Green;
            lblNumeroGrande.Location = new Point(189, 5);
            lblNumeroGrande.Margin = new Padding(2, 0, 2, 0);
            lblNumeroGrande.Name = "lblNumeroGrande";
            lblNumeroGrande.Size = new Size(164, 128);
            lblNumeroGrande.TabIndex = 0;
            lblNumeroGrande.Text = "00";
            lblNumeroGrande.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSortear
            // 
            btnSortear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortear.ForeColor = SystemColors.HotTrack;
            btnSortear.Location = new Point(15, 139);
            btnSortear.Margin = new Padding(2);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(132, 38);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "SORTEAR PRÓXIMO";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += BtnSortear_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = Color.Red;
            btnReiniciar.Location = new Point(386, 139);
            btnReiniciar.Margin = new Padding(2);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(132, 38);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "REINICIAR JOGO";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lsthistorico
            // 
            lsthistorico.FormattingEnabled = true;
            lsthistorico.Location = new Point(6, 215);
            lsthistorico.Margin = new Padding(2);
            lsthistorico.Name = "lsthistorico";
            lsthistorico.Size = new Size(546, 184);
            lsthistorico.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 199);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 4;
            label1.Text = "HISTÓRICO DE SORTEIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 411);
            Controls.Add(label1);
            Controls.Add(lsthistorico);
            Controls.Add(btnReiniciar);
            Controls.Add(btnSortear);
            Controls.Add(lblNumeroGrande);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "BingoMaster";
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
