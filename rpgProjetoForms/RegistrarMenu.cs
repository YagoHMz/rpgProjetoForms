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
    public partial class RegistrarMenu : Form
    {
        Contexto db;
        public RegistrarMenu()
        {
            InitializeComponent();
            db = new Contexto();
        }

        private void registrarBt_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            ListaPersonagem lp = new ListaPersonagem();
            player.Nome = nomeTbox.Text;
            player.Email = emailTbox.Text;
            if (senhaTbox.Text == confirmarSenhaTbox.Text)
            {
                player.Senha = senhaTbox.Text;
                if (db.Player.Any(p => p.Email == player.Email))
                {
                    MessageBox.Show("Email já cadastrado...");
                }
                else
                {
                    db.Add(player);
                    db.SaveChanges();

                    lp.FkRpgPlayerId = player.Id;
                    lp.FkRpgPersonagemId = 0;


                    db.ListaPersonagem.Add(lp);
                    db.SaveChanges();
                    MessageBox.Show("Registrado com sucesso!");
                    TelaInicial tela = new TelaInicial(player);                        this.Hide();
                    tela.Show();
                    this.Hide();

                    }
            }
            else
            {
                MessageBox.Show("Digite a mesma senha...");
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuInicial m = new MenuInicial();
            m.Show();
            this.Hide();
        }
    }
}
