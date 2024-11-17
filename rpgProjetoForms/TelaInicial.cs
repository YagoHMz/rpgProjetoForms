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
    public partial class TelaInicial : Form
    {
        Player p;
        Contexto db;
        public TelaInicial(Player player)
        {
            InitializeComponent();
            db = new Contexto();
            this.p = player;

            this.Text = "Início - Bem vindo, " + p.Nome;
            personagemLabel.Text = db.Personagem.Find(p.Fk_personagem_id).Nome;
            vitoriasLabel.Text = "Vitórias: " + p.Vitorias.ToString();
            derrotasLabel.Text = "Derrotas: " + p.Derrotas.ToString();

        }

        private void perfilBt_Click(object sender, EventArgs e)
        {
            PerfilEditar perfil = new PerfilEditar(p);
            this.Hide();
            perfil.Show();
        }

        private void inventarioBt_Click(object sender, EventArgs e)
        {
            InventárioMenu inventario = new InventárioMenu(p);
            this.Hide();
            inventario.Show();
        }

        private void lutasBt_Click(object sender, EventArgs e)
        {
            LutaMenu l = new LutaMenu(p, db.Personagem.First(perso => perso.Id == p.Fk_personagem_id));
            this.Hide();
            l.Show();
        }
    }
}
