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
    public partial class PerfilEditar : Form
    {
        Player p;
        Contexto db;
        public PerfilEditar(Player player)
        {
            InitializeComponent();
            this.p = player;
            db = new Contexto();

            nomeTbox.Text = p.Nome;
            emailTbox.Text = p.Email;
            senhaTbox.Text = p.Senha;

        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            p.Nome = nomeTbox.Text;
            p.Email = emailTbox.Text;
            p.Senha = senhaTbox.Text;
            db.Player.Update(p);
            db.SaveChanges();
            MessageBox.Show("Perfil alterado com sucesso!");
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial tela = new TelaInicial(p);
            tela.Show();
        }
    }
}
