namespace rpgProjetoForms
{
    partial class LutaMenu
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
            lutasDataGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            novaLutaBt = new Button();
            ((System.ComponentModel.ISupportInitialize)lutasDataGrid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lutasDataGrid
            // 
            lutasDataGrid.AllowUserToAddRows = false;
            lutasDataGrid.AllowUserToDeleteRows = false;
            lutasDataGrid.BackgroundColor = SystemColors.ControlDarkDark;
            lutasDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lutasDataGrid.Location = new Point(12, 47);
            lutasDataGrid.Name = "lutasDataGrid";
            lutasDataGrid.ReadOnly = true;
            lutasDataGrid.Size = new Size(627, 251);
            lutasDataGrid.TabIndex = 1;
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
            // novaLutaBt
            // 
            novaLutaBt.Location = new Point(12, 304);
            novaLutaBt.Name = "novaLutaBt";
            novaLutaBt.Size = new Size(297, 34);
            novaLutaBt.TabIndex = 25;
            novaLutaBt.Text = "Nova Luta";
            novaLutaBt.UseVisualStyleBackColor = true;
            novaLutaBt.Click += button1_Click;
            // 
            // LutaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(novaLutaBt);
            Controls.Add(menuStrip1);
            Controls.Add(lutasDataGrid);
            Name = "LutaMenu";
            Text = "Luta - Menu";
            ((System.ComponentModel.ISupportInitialize)lutasDataGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lutasDataGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Button novaLutaBt;
    }
}