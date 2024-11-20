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
    public partial class LutaMenu : Form
    {
        Player p;
        Personagem perso;
        Contexto db;
        public LutaMenu(Player player, Personagem personagem)
        {
            InitializeComponent();
            p = player;
            perso = personagem;
            db = new Contexto();

            try
            {
                lutasDataGrid.DataSource = db.Luta.Where(l => l.Fk_desafiado_id == p.Id || l.Fk_desafiante_id == p.Id).ToList();
            }
            catch (Exception)
            {

            }

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial i = new TelaInicial(p);
            this.Hide();
            i.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(p.Fk_personagem_id != 0 && p.Fk_personagem_id != null)
            {
                LutaTela novaLuta = new LutaTela(p, perso, db.Personagem.First(perso => perso.Id == 5));
                this.Hide();
                novaLuta.Show();
            }
            else
            {
                MessageBox.Show("Crie um personagem para lutar!");
            }
        }

        private void leaderBt_Click(object sender, EventArgs e)
        {
            LeaderBoard l = new LeaderBoard(p, perso);
            l.Show();
            this.Hide();
        }
    }
}
