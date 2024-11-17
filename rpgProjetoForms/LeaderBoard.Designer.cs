namespace rpgProjetoForms
{
    partial class LeaderBoard
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
            components = new System.ComponentModel.Container();
            leaderBoardDataGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            personagemBindingSource = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            Vitorias = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)leaderBoardDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // leaderBoardDataGrid
            // 
            leaderBoardDataGrid.AllowUserToAddRows = false;
            leaderBoardDataGrid.AllowUserToDeleteRows = false;
            leaderBoardDataGrid.AutoGenerateColumns = false;
            leaderBoardDataGrid.BackgroundColor = SystemColors.ControlDarkDark;
            leaderBoardDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaderBoardDataGrid.Columns.AddRange(new DataGridViewColumn[] { Vitorias, nomeDataGridViewTextBoxColumn });
            leaderBoardDataGrid.DataSource = playerBindingSource;
            leaderBoardDataGrid.Location = new Point(12, 27);
            leaderBoardDataGrid.Name = "leaderBoardDataGrid";
            leaderBoardDataGrid.ReadOnly = true;
            leaderBoardDataGrid.Size = new Size(627, 411);
            leaderBoardDataGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
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
            // personagemBindingSource
            // 
            personagemBindingSource.DataSource = typeof(Models.Personagem);
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Models.Player);
            // 
            // Vitorias
            // 
            Vitorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vitorias.DataPropertyName = "Vitorias";
            Vitorias.HeaderText = "Vitorias";
            Vitorias.Name = "Vitorias";
            Vitorias.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(menuStrip1);
            Controls.Add(leaderBoardDataGrid);
            MaximumSize = new Size(667, 489);
            MinimumSize = new Size(667, 489);
            Name = "LeaderBoard";
            Text = "LeaderBoard";
            ((System.ComponentModel.ISupportInitialize)leaderBoardDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView leaderBoardDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private DataGridViewTextBoxColumn Vitorias;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource playerBindingSource;
        private BindingSource personagemBindingSource;
    }
}