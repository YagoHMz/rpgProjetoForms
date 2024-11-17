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
    public partial class LeaderBoard : Form
    {
        Player p = new Player();
        Personagem pers = new Personagem();
        Contexto db;
        public LeaderBoard(Player p, Personagem per)
        {
            InitializeComponent();
            this.p = p;
            pers = per;
            db = new Contexto();
            var personagens = db.Player
                .Where(p => p.Nome != "Bot1")
                .OrderByDescending(p => p.Vitorias )
                .Select(p => new { p.Vitorias, p.Nome })
                .ToList();

            this.leaderBoardDataGrid.DataSource = personagens;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LutaMenu l = new LutaMenu(p, pers);
            this.Hide();
            l.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
