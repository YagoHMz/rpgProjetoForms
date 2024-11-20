using System.ComponentModel;

namespace rpgProjetoForms
{
    partial class LutaTela
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
            nomeLabel = new Label();
            habilidadesEscolha = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            habilidade1BoxPicture = new PictureBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            habilidade2Picture = new PictureBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            habilidade4Picture = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            habilidade5Picture = new PictureBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            habilidade3Picture = new PictureBox();
            label3 = new Label();
            habilidadeBot = new PictureBox();
            usarBt = new Button();
            pularBt = new Button();
            nomeHabilidadeLabel = new Label();
            tipoLabel = new Label();
            danoCuraLabel = new Label();
            custoLabel = new Label();
            roundsUso = new Label();
            vidaLabel = new Label();
            defesaLabel = new Label();
            forcaBuffDebuff = new Label();
            defesaBuffDebuff = new Label();
            progressBar1 = new ProgressBar();
            defesabuffdebuff2Label = new Label();
            forcabuffdebuff2label = new Label();
            defesa2Label = new Label();
            vida2Label = new Label();
            nome2PersonagemLabel = new Label();
            rounds2Label = new Label();
            custo2Label = new Label();
            danocura2Label = new Label();
            tipo2HabilidadeLabel = new Label();
            nome2HabilidadeLabel = new Label();
            label20 = new Label();
            pontosLabel = new Label();
            pontos2Label = new Label();
            groupBoxPlayer1 = new GroupBox();
            groupBoxBot = new GroupBox();
            presencaBot = new Label();
            forcaBot = new Label();
            vigorBot = new Label();
            intelectoBot = new Label();
            agilidadeBot = new Label();
            agilidadePlayer = new Label();
            intelectoPlayer = new Label();
            vigorPlayer = new Label();
            forcaPlayer = new Label();
            presencaPlayer = new Label();
            sairBt = new Button();
            habilidadesEscolha.SuspendLayout();
            groupBox5.SuspendLayout();
            ((ISupportInitialize)habilidade1BoxPicture).BeginInit();
            groupBox4.SuspendLayout();
            ((ISupportInitialize)habilidade2Picture).BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)habilidade4Picture).BeginInit();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)habilidade5Picture).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)habilidade3Picture).BeginInit();
            ((ISupportInitialize)habilidadeBot).BeginInit();
            groupBoxPlayer1.SuspendLayout();
            groupBoxBot.SuspendLayout();
            SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(19, 319);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(117, 15);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome - Personagem";
            // 
            // habilidadesEscolha
            // 
            habilidadesEscolha.AutoScroll = true;
            habilidadesEscolha.ColumnCount = 5;
            habilidadesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            habilidadesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            habilidadesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            habilidadesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            habilidadesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            habilidadesEscolha.Controls.Add(groupBox5, 0, 0);
            habilidadesEscolha.Controls.Add(groupBox4, 1, 0);
            habilidadesEscolha.Controls.Add(groupBox1, 3, 0);
            habilidadesEscolha.Controls.Add(groupBox2, 4, 0);
            habilidadesEscolha.Controls.Add(groupBox3, 2, 0);
            habilidadesEscolha.Location = new Point(12, 446);
            habilidadesEscolha.Name = "habilidadesEscolha";
            habilidadesEscolha.RowCount = 1;
            habilidadesEscolha.RowStyles.Add(new RowStyle());
            habilidadesEscolha.Size = new Size(520, 226);
            habilidadesEscolha.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(habilidade1BoxPicture);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(121, 173);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            // 
            // habilidade1BoxPicture
            // 
            habilidade1BoxPicture.ErrorImage = Properties.Resources.nenhum;
            habilidade1BoxPicture.Image = Properties.Resources.nenhum;
            habilidade1BoxPicture.InitialImage = Properties.Resources.nenhum;
            habilidade1BoxPicture.Location = new Point(0, 47);
            habilidade1BoxPicture.Name = "habilidade1BoxPicture";
            habilidade1BoxPicture.Size = new Size(121, 121);
            habilidade1BoxPicture.SizeMode = PictureBoxSizeMode.Zoom;
            habilidade1BoxPicture.TabIndex = 7;
            habilidade1BoxPicture.TabStop = false;
            habilidade1BoxPicture.Click += habilidade1BoxPicture_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-3, 26);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 6;
            label5.Text = "Habilidade 1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(habilidade2Picture);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(138, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(121, 173);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            // 
            // habilidade2Picture
            // 
            habilidade2Picture.BackColor = SystemColors.ControlDark;
            habilidade2Picture.BorderStyle = BorderStyle.FixedSingle;
            habilidade2Picture.ErrorImage = Properties.Resources.nenhum;
            habilidade2Picture.Image = Properties.Resources.nenhum;
            habilidade2Picture.InitialImage = Properties.Resources.nenhum;
            habilidade2Picture.Location = new Point(0, 47);
            habilidade2Picture.MaximumSize = new Size(121, 121);
            habilidade2Picture.MinimumSize = new Size(121, 121);
            habilidade2Picture.Name = "habilidade2Picture";
            habilidade2Picture.Size = new Size(121, 121);
            habilidade2Picture.SizeMode = PictureBoxSizeMode.Zoom;
            habilidade2Picture.TabIndex = 7;
            habilidade2Picture.TabStop = false;
            habilidade2Picture.Click += habilidade2Picture_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 26);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Habilidade 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(habilidade4Picture);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(408, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 173);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // habilidade4Picture
            // 
            habilidade4Picture.BackColor = SystemColors.ControlDark;
            habilidade4Picture.BorderStyle = BorderStyle.FixedSingle;
            habilidade4Picture.ErrorImage = Properties.Resources.nenhum;
            habilidade4Picture.Image = Properties.Resources.nenhum;
            habilidade4Picture.InitialImage = Properties.Resources.nenhum;
            habilidade4Picture.Location = new Point(0, 47);
            habilidade4Picture.MaximumSize = new Size(121, 121);
            habilidade4Picture.MinimumSize = new Size(121, 121);
            habilidade4Picture.Name = "habilidade4Picture";
            habilidade4Picture.Size = new Size(121, 121);
            habilidade4Picture.SizeMode = PictureBoxSizeMode.Zoom;
            habilidade4Picture.TabIndex = 7;
            habilidade4Picture.TabStop = false;
            habilidade4Picture.Click += habilidade4Picture_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Habilidade 4";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(habilidade5Picture);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(543, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(121, 173);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // habilidade5Picture
            // 
            habilidade5Picture.BackColor = SystemColors.ControlDark;
            habilidade5Picture.BorderStyle = BorderStyle.FixedSingle;
            habilidade5Picture.ErrorImage = Properties.Resources.nenhum;
            habilidade5Picture.Image = Properties.Resources.nenhum;
            habilidade5Picture.InitialImage = Properties.Resources.nenhum;
            habilidade5Picture.Location = new Point(0, 47);
            habilidade5Picture.MaximumSize = new Size(121, 121);
            habilidade5Picture.MinimumSize = new Size(121, 121);
            habilidade5Picture.Name = "habilidade5Picture";
            habilidade5Picture.Size = new Size(121, 121);
            habilidade5Picture.SizeMode = PictureBoxSizeMode.Zoom;
            habilidade5Picture.TabIndex = 7;
            habilidade5Picture.TabStop = false;
            habilidade5Picture.Click += habilidade5Picture_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 26);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Habilidade 5";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(habilidade3Picture);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(273, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(121, 173);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // habilidade3Picture
            // 
            habilidade3Picture.BackColor = SystemColors.ControlDark;
            habilidade3Picture.BorderStyle = BorderStyle.FixedSingle;
            habilidade3Picture.ErrorImage = Properties.Resources.nenhum;
            habilidade3Picture.Image = Properties.Resources.nenhum;
            habilidade3Picture.InitialImage = Properties.Resources.nenhum;
            habilidade3Picture.Location = new Point(0, 47);
            habilidade3Picture.MaximumSize = new Size(121, 121);
            habilidade3Picture.MinimumSize = new Size(121, 121);
            habilidade3Picture.Name = "habilidade3Picture";
            habilidade3Picture.Size = new Size(121, 121);
            habilidade3Picture.SizeMode = PictureBoxSizeMode.Zoom;
            habilidade3Picture.TabIndex = 7;
            habilidade3Picture.TabStop = false;
            habilidade3Picture.Click += habilidade3Picture_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Habilidade 3";
            // 
            // habilidadeBot
            // 
            habilidadeBot.BackColor = SystemColors.ControlDark;
            habilidadeBot.BorderStyle = BorderStyle.FixedSingle;
            habilidadeBot.ErrorImage = Properties.Resources.nenhum;
            habilidadeBot.Image = Properties.Resources.nenhum;
            habilidadeBot.InitialImage = Properties.Resources.nenhum;
            habilidadeBot.Location = new Point(19, 15);
            habilidadeBot.MaximumSize = new Size(121, 121);
            habilidadeBot.MinimumSize = new Size(121, 121);
            habilidadeBot.Name = "habilidadeBot";
            habilidadeBot.Size = new Size(121, 121);
            habilidadeBot.SizeMode = PictureBoxSizeMode.Zoom;
            habilidadeBot.TabIndex = 8;
            habilidadeBot.TabStop = false;
            // 
            // usarBt
            // 
            usarBt.Enabled = false;
            usarBt.Location = new Point(547, 454);
            usarBt.Name = "usarBt";
            usarBt.Size = new Size(125, 23);
            usarBt.TabIndex = 9;
            usarBt.Text = "Usar";
            usarBt.UseVisualStyleBackColor = true;
            usarBt.Click += usarBt_Click;
            // 
            // pularBt
            // 
            pularBt.Enabled = false;
            pularBt.Location = new Point(547, 496);
            pularBt.Name = "pularBt";
            pularBt.Size = new Size(125, 23);
            pularBt.TabIndex = 10;
            pularBt.Text = "Pular Round";
            pularBt.UseVisualStyleBackColor = true;
            pularBt.Click += pularBt_Click;
            // 
            // nomeHabilidadeLabel
            // 
            nomeHabilidadeLabel.AutoSize = true;
            nomeHabilidadeLabel.Location = new Point(6, 15);
            nomeHabilidadeLabel.Name = "nomeHabilidadeLabel";
            nomeHabilidadeLabel.Size = new Size(43, 15);
            nomeHabilidadeLabel.TabIndex = 11;
            nomeHabilidadeLabel.Text = "Nome:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new Point(6, 38);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(33, 15);
            tipoLabel.TabIndex = 12;
            tipoLabel.Text = "Tipo:";
            // 
            // danoCuraLabel
            // 
            danoCuraLabel.AutoSize = true;
            danoCuraLabel.Location = new Point(6, 63);
            danoCuraLabel.Name = "danoCuraLabel";
            danoCuraLabel.Size = new Size(65, 15);
            danoCuraLabel.TabIndex = 13;
            danoCuraLabel.Text = "Dano/Cura";
            // 
            // custoLabel
            // 
            custoLabel.AutoSize = true;
            custoLabel.Location = new Point(6, 88);
            custoLabel.Name = "custoLabel";
            custoLabel.Size = new Size(41, 15);
            custoLabel.TabIndex = 14;
            custoLabel.Text = "Custo:";
            // 
            // roundsUso
            // 
            roundsUso.AutoSize = true;
            roundsUso.Location = new Point(6, 113);
            roundsUso.Name = "roundsUso";
            roundsUso.Size = new Size(50, 15);
            roundsUso.TabIndex = 15;
            roundsUso.Text = "Rounds:";
            // 
            // vidaLabel
            // 
            vidaLabel.AutoSize = true;
            vidaLabel.Location = new Point(19, 345);
            vidaLabel.Name = "vidaLabel";
            vidaLabel.Size = new Size(33, 15);
            vidaLabel.TabIndex = 17;
            vidaLabel.Text = "Vida:";
            // 
            // defesaLabel
            // 
            defesaLabel.AutoSize = true;
            defesaLabel.Location = new Point(19, 370);
            defesaLabel.Name = "defesaLabel";
            defesaLabel.Size = new Size(45, 15);
            defesaLabel.TabIndex = 18;
            defesaLabel.Text = "Defesa:";
            // 
            // forcaBuffDebuff
            // 
            forcaBuffDebuff.AutoSize = true;
            forcaBuffDebuff.Location = new Point(19, 396);
            forcaBuffDebuff.Name = "forcaBuffDebuff";
            forcaBuffDebuff.Size = new Size(105, 15);
            forcaBuffDebuff.TabIndex = 19;
            forcaBuffDebuff.Text = "Força Buff/Debuff:";
            // 
            // defesaBuffDebuff
            // 
            defesaBuffDebuff.AutoSize = true;
            defesaBuffDebuff.Location = new Point(19, 420);
            defesaBuffDebuff.Name = "defesaBuffDebuff";
            defesaBuffDebuff.Size = new Size(111, 15);
            defesaBuffDebuff.TabIndex = 20;
            defesaBuffDebuff.Text = "Defesa Buff/Debuff:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(804, 10);
            progressBar1.TabIndex = 21;
            // 
            // defesabuffdebuff2Label
            // 
            defesabuffdebuff2Label.AutoSize = true;
            defesabuffdebuff2Label.Location = new Point(215, 256);
            defesabuffdebuff2Label.Name = "defesabuffdebuff2Label";
            defesabuffdebuff2Label.Size = new Size(111, 15);
            defesabuffdebuff2Label.TabIndex = 26;
            defesabuffdebuff2Label.Text = "Defesa Buff/Debuff:";
            // 
            // forcabuffdebuff2label
            // 
            forcabuffdebuff2label.AutoSize = true;
            forcabuffdebuff2label.Location = new Point(215, 232);
            forcabuffdebuff2label.Name = "forcabuffdebuff2label";
            forcabuffdebuff2label.Size = new Size(105, 15);
            forcabuffdebuff2label.TabIndex = 25;
            forcabuffdebuff2label.Text = "Força Buff/Debuff:";
            // 
            // defesa2Label
            // 
            defesa2Label.AutoSize = true;
            defesa2Label.Location = new Point(215, 206);
            defesa2Label.Name = "defesa2Label";
            defesa2Label.Size = new Size(45, 15);
            defesa2Label.TabIndex = 24;
            defesa2Label.Text = "Defesa:";
            // 
            // vida2Label
            // 
            vida2Label.AutoSize = true;
            vida2Label.Location = new Point(215, 181);
            vida2Label.Name = "vida2Label";
            vida2Label.Size = new Size(33, 15);
            vida2Label.TabIndex = 23;
            vida2Label.Text = "Vida:";
            // 
            // nome2PersonagemLabel
            // 
            nome2PersonagemLabel.AutoSize = true;
            nome2PersonagemLabel.Location = new Point(169, 15);
            nome2PersonagemLabel.Name = "nome2PersonagemLabel";
            nome2PersonagemLabel.Size = new Size(117, 15);
            nome2PersonagemLabel.TabIndex = 22;
            nome2PersonagemLabel.Text = "Nome - Personagem";
            // 
            // rounds2Label
            // 
            rounds2Label.AutoSize = true;
            rounds2Label.Location = new Point(6, 113);
            rounds2Label.Name = "rounds2Label";
            rounds2Label.Size = new Size(50, 15);
            rounds2Label.TabIndex = 31;
            rounds2Label.Text = "Rounds:";
            // 
            // custo2Label
            // 
            custo2Label.AutoSize = true;
            custo2Label.Location = new Point(6, 88);
            custo2Label.Name = "custo2Label";
            custo2Label.Size = new Size(41, 15);
            custo2Label.TabIndex = 30;
            custo2Label.Text = "Custo:";
            // 
            // danocura2Label
            // 
            danocura2Label.AutoSize = true;
            danocura2Label.Location = new Point(6, 63);
            danocura2Label.Name = "danocura2Label";
            danocura2Label.Size = new Size(65, 15);
            danocura2Label.TabIndex = 29;
            danocura2Label.Text = "Dano/Cura";
            // 
            // tipo2HabilidadeLabel
            // 
            tipo2HabilidadeLabel.AutoSize = true;
            tipo2HabilidadeLabel.Location = new Point(6, 38);
            tipo2HabilidadeLabel.Name = "tipo2HabilidadeLabel";
            tipo2HabilidadeLabel.Size = new Size(33, 15);
            tipo2HabilidadeLabel.TabIndex = 28;
            tipo2HabilidadeLabel.Text = "Tipo:";
            // 
            // nome2HabilidadeLabel
            // 
            nome2HabilidadeLabel.AutoSize = true;
            nome2HabilidadeLabel.Location = new Point(6, 15);
            nome2HabilidadeLabel.Name = "nome2HabilidadeLabel";
            nome2HabilidadeLabel.Size = new Size(43, 15);
            nome2HabilidadeLabel.TabIndex = 27;
            nome2HabilidadeLabel.Text = "Nome:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(215, 157);
            label20.Name = "label20";
            label20.Size = new Size(42, 15);
            label20.TabIndex = 32;
            label20.Text = "Status:";
            // 
            // pontosLabel
            // 
            pontosLabel.AutoSize = true;
            pontosLabel.Location = new Point(547, 419);
            pontosLabel.Name = "pontosLabel";
            pontosLabel.Size = new Size(105, 15);
            pontosLabel.TabIndex = 33;
            pontosLabel.Text = "Pontos de Esforço:";
            // 
            // pontos2Label
            // 
            pontos2Label.AutoSize = true;
            pontos2Label.Location = new Point(513, 256);
            pontos2Label.Name = "pontos2Label";
            pontos2Label.Size = new Size(105, 15);
            pontos2Label.TabIndex = 34;
            pontos2Label.Text = "Pontos de Esforço:";
            // 
            // groupBoxPlayer1
            // 
            groupBoxPlayer1.Controls.Add(tipoLabel);
            groupBoxPlayer1.Controls.Add(nomeHabilidadeLabel);
            groupBoxPlayer1.Controls.Add(danoCuraLabel);
            groupBoxPlayer1.Controls.Add(custoLabel);
            groupBoxPlayer1.Controls.Add(roundsUso);
            groupBoxPlayer1.Location = new Point(547, 525);
            groupBoxPlayer1.Name = "groupBoxPlayer1";
            groupBoxPlayer1.Size = new Size(171, 135);
            groupBoxPlayer1.TabIndex = 35;
            groupBoxPlayer1.TabStop = false;
            groupBoxPlayer1.Visible = false;
            // 
            // groupBoxBot
            // 
            groupBoxBot.Controls.Add(nome2HabilidadeLabel);
            groupBoxBot.Controls.Add(tipo2HabilidadeLabel);
            groupBoxBot.Controls.Add(danocura2Label);
            groupBoxBot.Controls.Add(custo2Label);
            groupBoxBot.Controls.Add(rounds2Label);
            groupBoxBot.Location = new Point(21, 143);
            groupBoxBot.Name = "groupBoxBot";
            groupBoxBot.Size = new Size(171, 135);
            groupBoxBot.TabIndex = 36;
            groupBoxBot.TabStop = false;
            // 
            // presencaBot
            // 
            presencaBot.AutoSize = true;
            presencaBot.Location = new Point(378, 158);
            presencaBot.Name = "presencaBot";
            presencaBot.Size = new Size(57, 15);
            presencaBot.TabIndex = 37;
            presencaBot.Text = "Presença:";
            // 
            // forcaBot
            // 
            forcaBot.AutoSize = true;
            forcaBot.Location = new Point(378, 181);
            forcaBot.Name = "forcaBot";
            forcaBot.Size = new Size(42, 15);
            forcaBot.TabIndex = 38;
            forcaBot.Text = "Força: ";
            // 
            // vigorBot
            // 
            vigorBot.AutoSize = true;
            vigorBot.Location = new Point(378, 206);
            vigorBot.Name = "vigorBot";
            vigorBot.Size = new Size(38, 15);
            vigorBot.TabIndex = 39;
            vigorBot.Text = "Vigor:";
            // 
            // intelectoBot
            // 
            intelectoBot.AutoSize = true;
            intelectoBot.Location = new Point(378, 232);
            intelectoBot.Name = "intelectoBot";
            intelectoBot.Size = new Size(56, 15);
            intelectoBot.TabIndex = 40;
            intelectoBot.Text = "Intelecto:";
            // 
            // agilidadeBot
            // 
            agilidadeBot.AutoSize = true;
            agilidadeBot.Location = new Point(378, 256);
            agilidadeBot.Name = "agilidadeBot";
            agilidadeBot.Size = new Size(60, 15);
            agilidadeBot.TabIndex = 41;
            agilidadeBot.Text = "Agilidade:";
            // 
            // agilidadePlayer
            // 
            agilidadePlayer.AutoSize = true;
            agilidadePlayer.Location = new Point(211, 417);
            agilidadePlayer.Name = "agilidadePlayer";
            agilidadePlayer.Size = new Size(60, 15);
            agilidadePlayer.TabIndex = 46;
            agilidadePlayer.Text = "Agilidade:";
            // 
            // intelectoPlayer
            // 
            intelectoPlayer.AutoSize = true;
            intelectoPlayer.Location = new Point(211, 393);
            intelectoPlayer.Name = "intelectoPlayer";
            intelectoPlayer.Size = new Size(56, 15);
            intelectoPlayer.TabIndex = 45;
            intelectoPlayer.Text = "Intelecto:";
            // 
            // vigorPlayer
            // 
            vigorPlayer.AutoSize = true;
            vigorPlayer.Location = new Point(211, 367);
            vigorPlayer.Name = "vigorPlayer";
            vigorPlayer.Size = new Size(38, 15);
            vigorPlayer.TabIndex = 44;
            vigorPlayer.Text = "Vigor:";
            // 
            // forcaPlayer
            // 
            forcaPlayer.AutoSize = true;
            forcaPlayer.Location = new Point(211, 342);
            forcaPlayer.Name = "forcaPlayer";
            forcaPlayer.Size = new Size(42, 15);
            forcaPlayer.TabIndex = 43;
            forcaPlayer.Text = "Força: ";
            // 
            // presencaPlayer
            // 
            presencaPlayer.AutoSize = true;
            presencaPlayer.Location = new Point(211, 319);
            presencaPlayer.Name = "presencaPlayer";
            presencaPlayer.Size = new Size(57, 15);
            presencaPlayer.TabIndex = 42;
            presencaPlayer.Text = "Presença:";
            // 
            // sairBt
            // 
            sairBt.Location = new Point(715, 7);
            sairBt.Name = "sairBt";
            sairBt.Size = new Size(73, 23);
            sairBt.TabIndex = 47;
            sairBt.Text = "Sair";
            sairBt.UseVisualStyleBackColor = true;
            sairBt.Click += sairBt_Click;
            // 
            // LutaTela
            // 
            ClientSize = new Size(800, 672);
            Controls.Add(sairBt);
            Controls.Add(agilidadePlayer);
            Controls.Add(intelectoPlayer);
            Controls.Add(vigorPlayer);
            Controls.Add(forcaPlayer);
            Controls.Add(presencaPlayer);
            Controls.Add(agilidadeBot);
            Controls.Add(intelectoBot);
            Controls.Add(vigorBot);
            Controls.Add(forcaBot);
            Controls.Add(presencaBot);
            Controls.Add(groupBoxBot);
            Controls.Add(groupBoxPlayer1);
            Controls.Add(pontos2Label);
            Controls.Add(pontosLabel);
            Controls.Add(label20);
            Controls.Add(defesabuffdebuff2Label);
            Controls.Add(forcabuffdebuff2label);
            Controls.Add(defesa2Label);
            Controls.Add(vida2Label);
            Controls.Add(nome2PersonagemLabel);
            Controls.Add(progressBar1);
            Controls.Add(defesaBuffDebuff);
            Controls.Add(forcaBuffDebuff);
            Controls.Add(defesaLabel);
            Controls.Add(vidaLabel);
            Controls.Add(pularBt);
            Controls.Add(usarBt);
            Controls.Add(habilidadeBot);
            Controls.Add(habilidadesEscolha);
            Controls.Add(nomeLabel);
            MaximumSize = new Size(816, 3000);
            MinimumSize = new Size(816, 711);
            Name = "LutaTela";
            Text = "Luta - ";
            habilidadesEscolha.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((ISupportInitialize)habilidade1BoxPicture).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((ISupportInitialize)habilidade2Picture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)habilidade4Picture).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)habilidade5Picture).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)habilidade3Picture).EndInit();
            ((ISupportInitialize)habilidadeBot).EndInit();
            groupBoxPlayer1.ResumeLayout(false);
            groupBoxPlayer1.PerformLayout();
            groupBoxBot.ResumeLayout(false);
            groupBoxBot.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel habilidadesEscolha;
        private GroupBox groupBox5;
        private PictureBox habilidade1BoxPicture;
        private Label label5;
        private GroupBox groupBox4;
        private PictureBox habilidade2Picture;
        private Label label4;
        private GroupBox groupBox3;
        private PictureBox habilidade3Picture;
        private Label label3;
        private GroupBox groupBox1;
        private PictureBox habilidade4Picture;
        private GroupBox groupBox2;
        private PictureBox habilidade5Picture;
        private Label label2;
        private Label label1;
        private PictureBox habilidadeBot;
        private Button usarBt;
        private Button pularBt;
        private Label nomeHabilidadeLabel;
        private Label tipoLabel;
        private Label danoCuraLabel;
        private Label custoLabel;
        private Label roundsUso;
        private Label vidaLabel;
        private Label defesaLabel;
        private Label forcaBuffDebuff;
        private Label defesaBuffDebuff;
        private ProgressBar progressBar1;
        private Label defesabuffdebuff2Label;
        private Label forcabuffdebuff2label;
        private Label defesa2Label;
        private Label vida2Label;
        private Label nome2PersonagemLabel;
        private Label rounds2Label;
        private Label custo2Label;
        private Label danocura2Label;
        private Label tipo2HabilidadeLabel;
        private Label nome2HabilidadeLabel;
        private Label label20;
        private Label nomeLabel;
        private Label pontosLabel;
        private Label pontos2Label;
        private GroupBox groupBoxPlayer1;
        private GroupBox groupBoxBot;
        private Label presencaBot;
        private Label forcaBot;
        private Label vigorBot;
        private Label intelectoBot;
        private Label agilidadeBot;
        private Label agilidadePlayer;
        private Label intelectoPlayer;
        private Label vigorPlayer;
        private Label forcaPlayer;
        private Label presencaPlayer;
        private Button sairBt;
    }

        #endregion
    }

