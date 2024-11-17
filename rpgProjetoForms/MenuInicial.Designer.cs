namespace rpgProjetoForms
{
    partial class MenuInicial
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
            loginBt = new Button();
            registrarBt = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginBt
            // 
            loginBt.Location = new Point(64, 228);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(289, 23);
            loginBt.TabIndex = 0;
            loginBt.Text = "Login";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += loginBt_Click;
            // 
            // registrarBt
            // 
            registrarBt.Location = new Point(64, 267);
            registrarBt.Name = "registrarBt";
            registrarBt.Size = new Size(289, 23);
            registrarBt.TabIndex = 1;
            registrarBt.Text = "Registrar";
            registrarBt.UseVisualStyleBackColor = true;
            registrarBt.Click += registrarBt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logosla;
            pictureBox1.Location = new Point(93, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(416, 450);
            Controls.Add(pictureBox1);
            Controls.Add(registrarBt);
            Controls.Add(loginBt);
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "MenuInicial";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "RPG";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button loginBt;
        private Button registrarBt;
        private PictureBox pictureBox1;
    }
}
