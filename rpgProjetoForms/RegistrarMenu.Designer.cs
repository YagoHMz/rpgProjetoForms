namespace rpgProjetoForms
{
    partial class RegistrarMenu
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
            nomeTbox = new TextBox();
            label1 = new Label();
            registrarBt = new Button();
            label2 = new Label();
            emailTbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            confirmarSenhaTbox = new TextBox();
            senhaTbox = new TextBox();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nomeTbox
            // 
            nomeTbox.Location = new Point(79, 82);
            nomeTbox.Name = "nomeTbox";
            nomeTbox.Size = new Size(258, 23);
            nomeTbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 55);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // registrarBt
            // 
            registrarBt.Location = new Point(80, 328);
            registrarBt.Name = "registrarBt";
            registrarBt.Size = new Size(258, 27);
            registrarBt.TabIndex = 1;
            registrarBt.Text = "Registrar-se";
            registrarBt.UseVisualStyleBackColor = true;
            registrarBt.Click += registrarBt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 121);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // emailTbox
            // 
            emailTbox.Location = new Point(79, 148);
            emailTbox.Name = "emailTbox";
            emailTbox.Size = new Size(258, 23);
            emailTbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 188);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 253);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirmar Senha";
            // 
            // confirmarSenhaTbox
            // 
            confirmarSenhaTbox.Location = new Point(79, 280);
            confirmarSenhaTbox.Name = "confirmarSenhaTbox";
            confirmarSenhaTbox.PasswordChar = '*';
            confirmarSenhaTbox.PlaceholderText = "Digite a mesma senha acima...";
            confirmarSenhaTbox.Size = new Size(258, 23);
            confirmarSenhaTbox.TabIndex = 10;
            // 
            // senhaTbox
            // 
            senhaTbox.Location = new Point(79, 215);
            senhaTbox.Name = "senhaTbox";
            senhaTbox.PasswordChar = '*';
            senhaTbox.PlaceholderText = "Digite sua senha...";
            senhaTbox.Size = new Size(258, 23);
            senhaTbox.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(416, 24);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // RegistrarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(menuStrip1);
            Controls.Add(senhaTbox);
            Controls.Add(label5);
            Controls.Add(confirmarSenhaTbox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(emailTbox);
            Controls.Add(label1);
            Controls.Add(nomeTbox);
            Controls.Add(registrarBt);
            Name = "RegistrarMenu";
            Text = "Registre-se";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeTbox;
        private Label label1;
        private Button registrarBt;
        private Label label2;
        private TextBox emailTbox;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox confirmarSenhaTbox;
        private TextBox senhaTbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}