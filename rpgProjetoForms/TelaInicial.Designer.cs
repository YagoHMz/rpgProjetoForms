namespace rpgProjetoForms
{
    partial class TelaInicial
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
            inventarioBt = new Button();
            lutasBt = new Button();
            perfilBt = new PictureBox();
            vitoriasLabel = new Label();
            derrotasLabel = new Label();
            label1 = new Label();
            personagemLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilBt).BeginInit();
            SuspendLayout();
            // 
            // inventarioBt
            // 
            inventarioBt.Location = new Point(78, 212);
            inventarioBt.Name = "inventarioBt";
            inventarioBt.Size = new Size(258, 27);
            inventarioBt.TabIndex = 2;
            inventarioBt.Text = "Inventário";
            inventarioBt.UseVisualStyleBackColor = true;
            inventarioBt.Click += inventarioBt_Click;
            // 
            // lutasBt
            // 
            lutasBt.Location = new Point(78, 245);
            lutasBt.Name = "lutasBt";
            lutasBt.Size = new Size(258, 27);
            lutasBt.TabIndex = 3;
            lutasBt.Text = "Lutas";
            lutasBt.UseVisualStyleBackColor = true;
            lutasBt.Click += lutasBt_Click;
            // 
            // perfilBt
            // 
            perfilBt.Cursor = Cursors.Hand;
            perfilBt.Image = Properties.Resources.perfil;
            perfilBt.Location = new Point(78, 38);
            perfilBt.Name = "perfilBt";
            perfilBt.Size = new Size(258, 148);
            perfilBt.SizeMode = PictureBoxSizeMode.Zoom;
            perfilBt.TabIndex = 4;
            perfilBt.TabStop = false;
            perfilBt.Click += perfilBt_Click;
            // 
            // vitoriasLabel
            // 
            vitoriasLabel.AutoSize = true;
            vitoriasLabel.Location = new Point(172, 351);
            vitoriasLabel.Name = "vitoriasLabel";
            vitoriasLabel.Size = new Size(70, 15);
            vitoriasLabel.TabIndex = 5;
            vitoriasLabel.Text = "Vitórias: 999";
            // 
            // derrotasLabel
            // 
            derrotasLabel.AutoSize = true;
            derrotasLabel.Location = new Point(170, 376);
            derrotasLabel.Name = "derrotasLabel";
            derrotasLabel.Size = new Size(75, 15);
            derrotasLabel.TabIndex = 6;
            derrotasLabel.Text = "Derrotas: 999";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 287);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 7;
            label1.Text = "Personagem Selecionado:";
            // 
            // personagemLabel
            // 
            personagemLabel.AutoSize = true;
            personagemLabel.BackColor = SystemColors.Control;
            personagemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personagemLabel.Location = new Point(58, 313);
            personagemLabel.MinimumSize = new Size(300, 0);
            personagemLabel.Name = "personagemLabel";
            personagemLabel.RightToLeft = RightToLeft.No;
            personagemLabel.Size = new Size(300, 15);
            personagemLabel.TabIndex = 8;
            personagemLabel.Text = "Boneco";
            personagemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(personagemLabel);
            Controls.Add(label1);
            Controls.Add(derrotasLabel);
            Controls.Add(vitoriasLabel);
            Controls.Add(perfilBt);
            Controls.Add(lutasBt);
            Controls.Add(inventarioBt);
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "TelaInicial";
            Text = "Início";
            ((System.ComponentModel.ISupportInitialize)perfilBt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventarioBt;
        private Button lutasBt;
        private PictureBox perfilBt;
        private Label vitoriasLabel;
        private Label derrotasLabel;
        private Label label1;
        private Label personagemLabel;
    }
}