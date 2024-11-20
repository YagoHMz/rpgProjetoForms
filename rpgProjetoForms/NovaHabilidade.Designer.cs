namespace rpgProjetoForms
{
    partial class NovaHabilidade
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
            imgBox = new PictureBox();
            habilidadeNomeTbox = new TextBox();
            label1 = new Label();
            uploadBt = new Button();
            tipoCombo = new ComboBox();
            label2 = new Label();
            danotipoLabel = new Label();
            danotipoNum = new NumericUpDown();
            roundsNum = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            custoNum = new NumericUpDown();
            criarBt = new Button();
            roundsGroup = new GroupBox();
            tudoGroupBox = new GroupBox();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)imgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danotipoNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)custoNum).BeginInit();
            roundsGroup.SuspendLayout();
            tudoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // imgBox
            // 
            imgBox.Image = Properties.Resources.nenhum;
            imgBox.Location = new Point(12, 78);
            imgBox.Name = "imgBox";
            imgBox.Size = new Size(121, 121);
            imgBox.SizeMode = PictureBoxSizeMode.Zoom;
            imgBox.TabIndex = 25;
            imgBox.TabStop = false;
            // 
            // habilidadeNomeTbox
            // 
            habilidadeNomeTbox.Location = new Point(61, 38);
            habilidadeNomeTbox.Name = "habilidadeNomeTbox";
            habilidadeNomeTbox.Size = new Size(343, 23);
            habilidadeNomeTbox.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 27;
            label1.Text = "Nome:";
            // 
            // uploadBt
            // 
            uploadBt.Location = new Point(9, 205);
            uploadBt.Name = "uploadBt";
            uploadBt.Size = new Size(124, 23);
            uploadBt.TabIndex = 28;
            uploadBt.Text = "Upload Foto";
            uploadBt.UseVisualStyleBackColor = true;
            uploadBt.Click += uploadBt_Click;
            // 
            // tipoCombo
            // 
            tipoCombo.FormattingEnabled = true;
            tipoCombo.Items.AddRange(new object[] { "Cura", "Veneno", "Dano", "Buff Dano", "Debuff Dano", "Buff Defesa", "Debuff Defesa" });
            tipoCombo.Location = new Point(148, 96);
            tipoCombo.Name = "tipoCombo";
            tipoCombo.Size = new Size(256, 23);
            tipoCombo.TabIndex = 29;
            tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 78);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 30;
            label2.Text = "Tipo:";
            // 
            // danotipoLabel
            // 
            danotipoLabel.AutoSize = true;
            danotipoLabel.Location = new Point(0, 10);
            danotipoLabel.Name = "danotipoLabel";
            danotipoLabel.Size = new Size(81, 15);
            danotipoLabel.TabIndex = 32;
            danotipoLabel.Text = "dano/tipo/etc";
            // 
            // danotipoNum
            // 
            danotipoNum.Location = new Point(0, 28);
            danotipoNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            danotipoNum.Name = "danotipoNum";
            danotipoNum.Size = new Size(120, 23);
            danotipoNum.TabIndex = 33;
            danotipoNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            danotipoNum.ValueChanged += danotipoNum_ValueChanged;
            // 
            // roundsNum
            // 
            roundsNum.Location = new Point(0, 22);
            roundsNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            roundsNum.Name = "roundsNum";
            roundsNum.Size = new Size(120, 23);
            roundsNum.TabIndex = 34;
            roundsNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            roundsNum.ValueChanged += roundsNum_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 4);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 35;
            label4.Text = "Rounds";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 10);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 37;
            label5.Text = "Custo:";
            // 
            // custoNum
            // 
            custoNum.Enabled = false;
            custoNum.Location = new Point(135, 28);
            custoNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            custoNum.Name = "custoNum";
            custoNum.Size = new Size(120, 23);
            custoNum.TabIndex = 36;
            custoNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // criarBt
            // 
            criarBt.Enabled = false;
            criarBt.Location = new Point(9, 241);
            criarBt.Name = "criarBt";
            criarBt.Size = new Size(124, 23);
            criarBt.TabIndex = 38;
            criarBt.Text = "Criar Habilidade";
            criarBt.UseVisualStyleBackColor = true;
            criarBt.Click += criarBt_Click;
            // 
            // roundsGroup
            // 
            roundsGroup.Controls.Add(roundsNum);
            roundsGroup.Controls.Add(label4);
            roundsGroup.Location = new Point(0, 57);
            roundsGroup.Name = "roundsGroup";
            roundsGroup.Size = new Size(200, 46);
            roundsGroup.TabIndex = 39;
            roundsGroup.TabStop = false;
            roundsGroup.Visible = false;
            // 
            // tudoGroupBox
            // 
            tudoGroupBox.Controls.Add(roundsGroup);
            tudoGroupBox.Controls.Add(label5);
            tudoGroupBox.Controls.Add(custoNum);
            tudoGroupBox.Controls.Add(danotipoNum);
            tudoGroupBox.Controls.Add(danotipoLabel);
            tudoGroupBox.Location = new Point(148, 125);
            tudoGroupBox.Name = "tudoGroupBox";
            tudoGroupBox.Size = new Size(256, 156);
            tudoGroupBox.TabIndex = 40;
            tudoGroupBox.TabStop = false;
            tudoGroupBox.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(416, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // NovaHabilidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(criarBt);
            Controls.Add(label2);
            Controls.Add(tipoCombo);
            Controls.Add(uploadBt);
            Controls.Add(label1);
            Controls.Add(habilidadeNomeTbox);
            Controls.Add(imgBox);
            Controls.Add(menuStrip1);
            Controls.Add(tudoGroupBox);
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "NovaHabilidade";
            Text = "Nova Habilidade";
            ((System.ComponentModel.ISupportInitialize)imgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)danotipoNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)custoNum).EndInit();
            roundsGroup.ResumeLayout(false);
            roundsGroup.PerformLayout();
            tudoGroupBox.ResumeLayout(false);
            tudoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imgBox;
        private TextBox habilidadeNomeTbox;
        private Label label1;
        private Button uploadBt;
        private ComboBox tipoCombo;
        private Label label2;
        private Label danotipoLabel;
        private NumericUpDown danotipoNum;
        private NumericUpDown roundsNum;
        private Label label4;
        private Label label5;
        private NumericUpDown custoNum;
        private Button criarBt;
        private GroupBox roundsGroup;
        private GroupBox tudoGroupBox;
        private MenuStrip menuStrip1;
    }
}