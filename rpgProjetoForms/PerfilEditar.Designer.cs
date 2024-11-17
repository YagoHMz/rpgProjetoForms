namespace rpgProjetoForms
{
    partial class PerfilEditar
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
            senhaTbox = new TextBox();
            label5 = new Label();
            confirmarSenhaTbox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            emailTbox = new TextBox();
            label1 = new Label();
            nomeTbox = new TextBox();
            salvarBt = new Button();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // senhaTbox
            // 
            senhaTbox.Location = new Point(79, 235);
            senhaTbox.Name = "senhaTbox";
            senhaTbox.PasswordChar = '*';
            senhaTbox.PlaceholderText = "Digite sua senha...";
            senhaTbox.Size = new Size(258, 23);
            senhaTbox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 273);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 20;
            label5.Text = "Confirmar Senha";
            // 
            // confirmarSenhaTbox
            // 
            confirmarSenhaTbox.Location = new Point(79, 300);
            confirmarSenhaTbox.Name = "confirmarSenhaTbox";
            confirmarSenhaTbox.PasswordChar = '*';
            confirmarSenhaTbox.PlaceholderText = "Digite a mesma senha acima...";
            confirmarSenhaTbox.Size = new Size(258, 23);
            confirmarSenhaTbox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 208);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 141);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "Email";
            // 
            // emailTbox
            // 
            emailTbox.Location = new Point(79, 168);
            emailTbox.Name = "emailTbox";
            emailTbox.ReadOnly = true;
            emailTbox.Size = new Size(258, 23);
            emailTbox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 75);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // nomeTbox
            // 
            nomeTbox.Location = new Point(79, 102);
            nomeTbox.Name = "nomeTbox";
            nomeTbox.Size = new Size(258, 23);
            nomeTbox.TabIndex = 14;
            // 
            // salvarBt
            // 
            salvarBt.Location = new Point(80, 348);
            salvarBt.Name = "salvarBt";
            salvarBt.Size = new Size(258, 27);
            salvarBt.TabIndex = 13;
            salvarBt.Text = "Salvar";
            salvarBt.UseVisualStyleBackColor = true;
            salvarBt.Click += salvarBt_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(416, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // PerfilEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(senhaTbox);
            Controls.Add(label5);
            Controls.Add(confirmarSenhaTbox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(emailTbox);
            Controls.Add(label1);
            Controls.Add(nomeTbox);
            Controls.Add(salvarBt);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "PerfilEditar";
            Text = "PerfilEditar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senhaTbox;
        private Label label5;
        private TextBox confirmarSenhaTbox;
        private Label label4;
        private Label label2;
        private TextBox emailTbox;
        private Label label1;
        private TextBox nomeTbox;
        private Button salvarBt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}