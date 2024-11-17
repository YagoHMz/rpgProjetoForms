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
    public partial class Login : Form
    {
        Contexto db;
        public Login()
        {
            InitializeComponent();
            db = new Contexto();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            if (db.Player.Any(p => p.Email == emailTbox.Text))
            {

                if (db.Player.Any(p => p.Email == emailTbox.Text && p.Senha == senhaTbox.Text))
                {
                    TelaInicial tela = new TelaInicial(db.Player.First(p => p.Email == emailTbox.Text && p.Senha == senhaTbox.Text));
                    this.Hide();
                    tela.Show();
                }
                else
                {
                    MessageBox.Show("Senha incorreta...");
                }
            }
            else
            {
                MessageBox.Show("Email não cadastrado...");
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
