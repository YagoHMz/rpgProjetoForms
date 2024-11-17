namespace rpgProjetoForms
{
    partial class InventárioMenu
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
            inventarioDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            origemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defesaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            agilidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            forcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            presencaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vigorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intelectoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defesabuffDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            forcabuffDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personagemBindingSource2 = new BindingSource(components);
            personagemBindingSource = new BindingSource(components);
            novoPersonagemBt = new Button();
            selecionarBt = new Button();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            personagemBindingSource1 = new BindingSource(components);
            editarHabilidadesBt = new Button();
            excluirBt = new Button();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)inventarioDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // inventarioDataGrid
            // 
            inventarioDataGrid.AllowUserToAddRows = false;
            inventarioDataGrid.AllowUserToDeleteRows = false;
            inventarioDataGrid.AutoGenerateColumns = false;
            inventarioDataGrid.BackgroundColor = SystemColors.ControlDarkDark;
            inventarioDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventarioDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, origemDataGridViewTextBoxColumn, defesaDataGridViewTextBoxColumn, vidaDataGridViewTextBoxColumn, agilidadeDataGridViewTextBoxColumn, forcaDataGridViewTextBoxColumn, presencaDataGridViewTextBoxColumn, vigorDataGridViewTextBoxColumn, intelectoDataGridViewTextBoxColumn, defesabuffDataGridViewTextBoxColumn, forcabuffDataGridViewTextBoxColumn });
            inventarioDataGrid.DataSource = personagemBindingSource2;
            inventarioDataGrid.Location = new Point(12, 31);
            inventarioDataGrid.Name = "inventarioDataGrid";
            inventarioDataGrid.ReadOnly = true;
            inventarioDataGrid.Size = new Size(627, 251);
            inventarioDataGrid.TabIndex = 0;
            inventarioDataGrid.CellContentClick += inventarioDataGrid_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origemDataGridViewTextBoxColumn
            // 
            origemDataGridViewTextBoxColumn.DataPropertyName = "Origem";
            origemDataGridViewTextBoxColumn.HeaderText = "Origem";
            origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            origemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defesaDataGridViewTextBoxColumn
            // 
            defesaDataGridViewTextBoxColumn.DataPropertyName = "Defesa";
            defesaDataGridViewTextBoxColumn.HeaderText = "Defesa";
            defesaDataGridViewTextBoxColumn.Name = "defesaDataGridViewTextBoxColumn";
            defesaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vidaDataGridViewTextBoxColumn
            // 
            vidaDataGridViewTextBoxColumn.DataPropertyName = "Vida";
            vidaDataGridViewTextBoxColumn.HeaderText = "Vida";
            vidaDataGridViewTextBoxColumn.Name = "vidaDataGridViewTextBoxColumn";
            vidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agilidadeDataGridViewTextBoxColumn
            // 
            agilidadeDataGridViewTextBoxColumn.DataPropertyName = "Agilidade";
            agilidadeDataGridViewTextBoxColumn.HeaderText = "Agilidade";
            agilidadeDataGridViewTextBoxColumn.Name = "agilidadeDataGridViewTextBoxColumn";
            agilidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forcaDataGridViewTextBoxColumn
            // 
            forcaDataGridViewTextBoxColumn.DataPropertyName = "Forca";
            forcaDataGridViewTextBoxColumn.HeaderText = "Forca";
            forcaDataGridViewTextBoxColumn.Name = "forcaDataGridViewTextBoxColumn";
            forcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presencaDataGridViewTextBoxColumn
            // 
            presencaDataGridViewTextBoxColumn.DataPropertyName = "Presenca";
            presencaDataGridViewTextBoxColumn.HeaderText = "Presenca";
            presencaDataGridViewTextBoxColumn.Name = "presencaDataGridViewTextBoxColumn";
            presencaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vigorDataGridViewTextBoxColumn
            // 
            vigorDataGridViewTextBoxColumn.DataPropertyName = "Vigor";
            vigorDataGridViewTextBoxColumn.HeaderText = "Vigor";
            vigorDataGridViewTextBoxColumn.Name = "vigorDataGridViewTextBoxColumn";
            vigorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intelectoDataGridViewTextBoxColumn
            // 
            intelectoDataGridViewTextBoxColumn.DataPropertyName = "Intelecto";
            intelectoDataGridViewTextBoxColumn.HeaderText = "Intelecto";
            intelectoDataGridViewTextBoxColumn.Name = "intelectoDataGridViewTextBoxColumn";
            intelectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defesabuffDataGridViewTextBoxColumn
            // 
            defesabuffDataGridViewTextBoxColumn.DataPropertyName = "Defesa_buff";
            defesabuffDataGridViewTextBoxColumn.HeaderText = "Defesa_buff";
            defesabuffDataGridViewTextBoxColumn.Name = "defesabuffDataGridViewTextBoxColumn";
            defesabuffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forcabuffDataGridViewTextBoxColumn
            // 
            forcabuffDataGridViewTextBoxColumn.DataPropertyName = "Forca_buff";
            forcabuffDataGridViewTextBoxColumn.HeaderText = "Forca_buff";
            forcabuffDataGridViewTextBoxColumn.Name = "forcabuffDataGridViewTextBoxColumn";
            forcabuffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personagemBindingSource2
            // 
            personagemBindingSource2.DataSource = typeof(Models.Personagem);
            // 
            // personagemBindingSource
            // 
            personagemBindingSource.DataSource = typeof(Models.Personagem);
            // 
            // novoPersonagemBt
            // 
            novoPersonagemBt.Location = new Point(12, 298);
            novoPersonagemBt.Name = "novoPersonagemBt";
            novoPersonagemBt.Size = new Size(170, 23);
            novoPersonagemBt.TabIndex = 1;
            novoPersonagemBt.Text = "Novo Personagem";
            novoPersonagemBt.UseVisualStyleBackColor = true;
            novoPersonagemBt.Click += novoPersonagemBt_Click;
            // 
            // selecionarBt
            // 
            selecionarBt.Enabled = false;
            selecionarBt.Location = new Point(469, 298);
            selecionarBt.Name = "selecionarBt";
            selecionarBt.Size = new Size(170, 23);
            selecionarBt.TabIndex = 2;
            selecionarBt.Text = "Selecionar Personagem";
            selecionarBt.UseVisualStyleBackColor = true;
            selecionarBt.Click += selecionarBt_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(651, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // personagemBindingSource1
            // 
            personagemBindingSource1.DataSource = typeof(Models.Personagem);
            // 
            // editarHabilidadesBt
            // 
            editarHabilidadesBt.Enabled = false;
            editarHabilidadesBt.Location = new Point(240, 298);
            editarHabilidadesBt.Name = "editarHabilidadesBt";
            editarHabilidadesBt.Size = new Size(170, 23);
            editarHabilidadesBt.TabIndex = 24;
            editarHabilidadesBt.Text = "Editar Habilidades";
            editarHabilidadesBt.UseVisualStyleBackColor = true;
            editarHabilidadesBt.Click += editarHabilidadesBt_Click;
            // 
            // excluirBt
            // 
            excluirBt.Enabled = false;
            excluirBt.Location = new Point(240, 415);
            excluirBt.Name = "excluirBt";
            excluirBt.Size = new Size(170, 23);
            excluirBt.TabIndex = 25;
            excluirBt.Text = "Excluir Personagem";
            excluirBt.UseVisualStyleBackColor = true;
            excluirBt.Click += excluirBt_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(58, 20);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // InventárioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(excluirBt);
            Controls.Add(editarHabilidadesBt);
            Controls.Add(menuStrip1);
            Controls.Add(selecionarBt);
            Controls.Add(novoPersonagemBt);
            Controls.Add(inventarioDataGrid);
            MinimumSize = new Size(432, 489);
            Name = "InventárioMenu";
            Text = "Inventário";
            ((System.ComponentModel.ISupportInitialize)inventarioDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personagemBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventarioDataGrid;
        private Button novoPersonagemBt;
        private Button selecionarBt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private BindingSource personagemBindingSource;
        private BindingSource personagemBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn agilidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn forcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn presencaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vigorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intelectoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defesabuffDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn forcabuffDataGridViewTextBoxColumn;
        private BindingSource personagemBindingSource2;
        private Button editarHabilidadesBt;
        private Button excluirBt;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}