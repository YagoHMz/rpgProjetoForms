namespace rpgProjetoForms
{
    partial class NovoPersonagem
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
            label1 = new Label();
            nomeTbox = new TextBox();
            origemLabel = new Label();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            origemCombo = new ComboBox();
            agilidadeNum = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            forcaNum = new NumericUpDown();
            label5 = new Label();
            intelectoNum = new NumericUpDown();
            label6 = new Label();
            presencaNum = new NumericUpDown();
            label7 = new Label();
            vigorNum = new NumericUpDown();
            pvLabel = new Label();
            atributosLabel = new Label();
            criarBt = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)agilidadeNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forcaNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intelectoNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presencaNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vigorNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // nomeTbox
            // 
            nomeTbox.Location = new Point(79, 71);
            nomeTbox.Name = "nomeTbox";
            nomeTbox.Size = new Size(258, 23);
            nomeTbox.TabIndex = 4;
            // 
            // origemLabel
            // 
            origemLabel.AutoSize = true;
            origemLabel.Location = new Point(79, 114);
            origemLabel.Name = "origemLabel";
            origemLabel.Size = new Size(47, 15);
            origemLabel.TabIndex = 7;
            origemLabel.Text = "Origem";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem, infoToolStripMenuItem });
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
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.AutoToolTip = true;
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(85, 20);
            infoToolStripMenuItem.Text = "Informações";
            infoToolStripMenuItem.ToolTipText = "Quando você cria um personagem, todos os seus atributos começam em 1 e você recebe 4 pontos para distribuir entre eles";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // origemCombo
            // 
            origemCombo.FormattingEnabled = true;
            origemCombo.Items.AddRange(new object[] { "Atleta", "Professor", "Lutador", "Sobrevivente de Guerra", "Soldado" });
            origemCombo.Location = new Point(79, 138);
            origemCombo.Name = "origemCombo";
            origemCombo.Size = new Size(258, 23);
            origemCombo.TabIndex = 25;
            origemCombo.SelectedIndexChanged += origemCombo_SelectedIndexChanged;
            // 
            // agilidadeNum
            // 
            agilidadeNum.Location = new Point(177, 194);
            agilidadeNum.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            agilidadeNum.Name = "agilidadeNum";
            agilidadeNum.Size = new Size(47, 23);
            agilidadeNum.TabIndex = 26;
            agilidadeNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            agilidadeNum.ValueChanged += agilidadeNum_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 27;
            label3.Text = "Agilidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 217);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 29;
            label4.Text = "Força";
            // 
            // forcaNum
            // 
            forcaNum.Location = new Point(69, 234);
            forcaNum.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            forcaNum.Name = "forcaNum";
            forcaNum.Size = new Size(47, 23);
            forcaNum.TabIndex = 28;
            forcaNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            forcaNum.ValueChanged += forcaNum_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 216);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 31;
            label5.Text = "Intelecto";
            // 
            // intelectoNum
            // 
            intelectoNum.Location = new Point(298, 233);
            intelectoNum.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            intelectoNum.Name = "intelectoNum";
            intelectoNum.Size = new Size(47, 23);
            intelectoNum.TabIndex = 30;
            intelectoNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            intelectoNum.ValueChanged += intelectoNum_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 285);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 33;
            label6.Text = "Presença";
            // 
            // presencaNum
            // 
            presencaNum.Location = new Point(99, 303);
            presencaNum.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            presencaNum.Name = "presencaNum";
            presencaNum.Size = new Size(47, 23);
            presencaNum.TabIndex = 32;
            presencaNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            presencaNum.ValueChanged += presencaNum_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 285);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 35;
            label7.Text = "Vigor";
            // 
            // vigorNum
            // 
            vigorNum.Location = new Point(266, 303);
            vigorNum.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            vigorNum.Name = "vigorNum";
            vigorNum.Size = new Size(47, 23);
            vigorNum.TabIndex = 34;
            vigorNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            vigorNum.ValueChanged += vigorNum_ValueChanged;
            // 
            // pvLabel
            // 
            pvLabel.AutoSize = true;
            pvLabel.Location = new Point(154, 372);
            pvLabel.Name = "pvLabel";
            pvLabel.Size = new Size(104, 15);
            pvLabel.TabIndex = 36;
            pvLabel.Text = "Pontos de Vida: 50";
            // 
            // atributosLabel
            // 
            atributosLabel.AutoSize = true;
            atributosLabel.Location = new Point(110, 345);
            atributosLabel.Name = "atributosLabel";
            atributosLabel.Size = new Size(186, 15);
            atributosLabel.TabIndex = 37;
            atributosLabel.Text = "Pontos de Atributos disponíveis: 4";
            // 
            // criarBt
            // 
            criarBt.Location = new Point(96, 402);
            criarBt.Name = "criarBt";
            criarBt.Size = new Size(217, 23);
            criarBt.TabIndex = 38;
            criarBt.Text = "Criar Personagem";
            criarBt.UseVisualStyleBackColor = true;
            criarBt.Click += criarBt_Click;
            // 
            // NovoPersonagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(criarBt);
            Controls.Add(atributosLabel);
            Controls.Add(pvLabel);
            Controls.Add(label7);
            Controls.Add(vigorNum);
            Controls.Add(label6);
            Controls.Add(presencaNum);
            Controls.Add(label5);
            Controls.Add(intelectoNum);
            Controls.Add(label4);
            Controls.Add(forcaNum);
            Controls.Add(label3);
            Controls.Add(agilidadeNum);
            Controls.Add(origemCombo);
            Controls.Add(menuStrip1);
            Controls.Add(origemLabel);
            Controls.Add(label1);
            Controls.Add(nomeTbox);
            MaximumSize = new Size(432, 489);
            MinimumSize = new Size(432, 489);
            Name = "NovoPersonagem";
            Text = "Novo Personagem";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)agilidadeNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)forcaNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)intelectoNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)presencaNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)vigorNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeTbox;
        private Label origemLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private ComboBox origemCombo;
        private ToolStripMenuItem infoToolStripMenuItem;
        private NumericUpDown agilidadeNum;
        private Label label3;
        private Label label4;
        private NumericUpDown forcaNum;
        private Label label5;
        private NumericUpDown intelectoNum;
        private Label label6;
        private NumericUpDown presencaNum;
        private Label label7;
        private NumericUpDown vigorNum;
        private Label pvLabel;
        private Label atributosLabel;
        private Button criarBt;
    }
}