using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rpgProjetoForms.Models;

namespace rpgProjetoForms
{
    public partial class InventárioMenu : Form
    {
        Player p;
        Contexto db;
        public void Refresh()
        {
            var personagens = db.Personagem
            .Where(perso => db.ListaPersonagem.Any(lp => lp.FkRpgPlayerId == p.Id && lp.FkRpgPersonagemId == perso.Id))
            .OrderBy(perso => perso.Id)
            .ToList();

            inventarioDataGrid.DataSource = personagens;
        }
        public InventárioMenu(Player player)
        {
            InitializeComponent();
            p = player;
            db = new Contexto();
            Refresh();
        }

        private void novoPersonagemBt_Click(object sender, EventArgs e)
        {
            NovoPersonagem n = new NovoPersonagem(p);
            this.Hide();
            n.Show();
        }

        private void inventarioDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editarHabilidadesBt.Enabled = true;
            excluirBt.Enabled = true;
            selecionarBt.Enabled = true;
            if (inventarioDataGrid.CurrentRow == inventarioDataGrid.Rows[0])
            {
                editarHabilidadesBt.Enabled = false;
                excluirBt.Enabled = false;
                selecionarBt.Enabled = false;
            }
        }

        private void selecionarBt_Click(object sender, EventArgs e)
        {
            if (inventarioDataGrid.CurrentRow == inventarioDataGrid.Rows[0])
            {
                MessageBox.Show("Impossível selecionar este...");
            }
            else
            {
                p.Fk_personagem_id = (int)inventarioDataGrid.CurrentRow.Cells[0].Value;
                db.Player.Update(p);
                db.SaveChanges();
                TelaInicial t = new TelaInicial(p);
                this.Hide();
                t.Show();
            }

        }

        private void excluirBt_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja excluir o personagem?", "Excluir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (p.Fk_personagem_id == (int)inventarioDataGrid.CurrentRow.Cells[0].Value)
                {
                    p.Fk_personagem_id = (int)inventarioDataGrid.Rows[0].Cells[0].Value;
                }

                if (inventarioDataGrid.CurrentRow == inventarioDataGrid.Rows[0])
                {
                    MessageBox.Show("Impossível excluir este...");
                }
                else
                {
                    db.Personagem.Remove(db.Personagem.Find((int)inventarioDataGrid.CurrentRow.Cells[0].Value));
                    db.SaveChanges();

                    Refresh();
                }
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial t = new TelaInicial(p);
            t.Show();
            this.Hide();
        }

        private void editarHabilidadesBt_Click(object sender, EventArgs e)
        {
            Personagem perso = db.Personagem.Find((int)inventarioDataGrid.CurrentRow.Cells[0].Value);
            if (inventarioDataGrid.CurrentRow == inventarioDataGrid.Rows[0])
            {
                MessageBox.Show("Impossível editar este...");
            }
            else
            {
                EditarHabilidades h = new EditarHabilidades(p, perso);
                h.Show();
                this.Hide();

            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void inventarioDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editarHabilidadesBt.Enabled = true;
            excluirBt.Enabled = true;
            selecionarBt.Enabled = true;
            if (inventarioDataGrid.CurrentRow == inventarioDataGrid.Rows[0])
            {
                editarHabilidadesBt.Enabled = false;
                excluirBt.Enabled = false;
                selecionarBt.Enabled = false;
            }
        }
    }
}
