namespace rpgProjetoForms
{
    partial class Login
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
            label4 = new Label();
            label2 = new Label();
            emailTbox = new TextBox();
            loginBt = new Button();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // senhaTbox
            // 
            senhaTbox.Location = new Point(79, 156);
            senhaTbox.Name = "senhaTbox";
            senhaTbox.PasswordChar = '*';
            senhaTbox.PlaceholderText = "Digite sua senha...";
            senhaTbox.Size = new Size(258, 23);
            senhaTbox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 129);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 62);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // emailTbox
            // 
            emailTbox.Location = new Point(79, 89);
            emailTbox.Name = "emailTbox";
            emailTbox.Size = new Size(258, 23);
            emailTbox.TabIndex = 13;
            // 
            // loginBt
            // 
            loginBt.Location = new Point(79, 212);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(258, 27);
            loginBt.TabIndex = 17;
            loginBt.Text = "Login";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += loginBt_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(416, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(menuStrip1);
            Controls.Add(loginBt);
            Controls.Add(senhaTbox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(emailTbox);
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "Login";
            Text = "Login";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senhaTbox;
        private Label label4;
        private Label label2;
        private TextBox emailTbox;
        private Button loginBt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}