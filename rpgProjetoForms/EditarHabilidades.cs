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
    public partial class EditarHabilidades : Form
    {
        Contexto db;
        Player p;
        Personagem perso;
        Habilidade h1, h2, h3, h4, h5;

        public static Image ByteArrayToImage(byte[] byteArray, PictureBox p)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream(byteArray))
                {
                    return Image.FromStream(mStream);
                }
            }

            catch (Exception)
            {
                return p.ErrorImage;
            }
        }


        public void Refresh()
        {
            try
            {
                habilidade1Combo.DataSource = db.Habilidade.Where(h => h.FkIdPlayer == p.Id).Select(h => h.Nome).ToList();
                habilidade2Combo.DataSource = db.Habilidade.Where(h => h.FkIdPlayer == p.Id).Select(h => h.Nome).ToList();
                habilidade3Combo.DataSource = db.Habilidade.Where(h => h.FkIdPlayer == p.Id).Select(h => h.Nome).ToList();
                habilidade4Combo.DataSource = db.Habilidade.Where(h => h.FkIdPlayer == p.Id).Select(h => h.Nome).ToList();
                habilidade5Combo.DataSource = db.Habilidade.Where(h => h.FkIdPlayer == p.Id).Select(h => h.Nome).ToList();

                h1 = db.Habilidade.First(h => h.Id == perso.Habilidade1);
                h2 = db.Habilidade.First(h => h.Id == perso.Habilidade2);
                h3 = db.Habilidade.First(h => h.Id == perso.Habilidade3);
                h4 = db.Habilidade.First(h => h.Id == perso.Habilidade4);
                h5 = db.Habilidade.First(h => h.Id == perso.Habilidade5);

                habilidade1Combo.Text = h1.Nome;
                habilidade2Combo.Text = h2.Nome;
                habilidade3Combo.Text = h3.Nome;
                habilidade4Combo.Text = h4.Nome;
                habilidade5Combo.Text = h5.Nome;

                habilidade1BoxPicture.Image = ByteArrayToImage(h1.Imagem, habilidade1BoxPicture);
                habilidade2Picture.Image = ByteArrayToImage(h2.Imagem, habilidade2Picture);
                habilidade3Picture.Image = ByteArrayToImage(h3.Imagem, habilidade3Picture);
                habilidade4Picture.Image = ByteArrayToImage(h4.Imagem, habilidade4Picture);
                habilidade5Picture.Image = ByteArrayToImage(h5.Imagem, habilidade5Picture);
            }

            catch (Exception)
            {

            }
        }
        public EditarHabilidades(Player player, Personagem personagem)
        {
            InitializeComponent();
            p = player;
            perso = personagem;
            db = new Contexto();
            Refresh();

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventárioMenu i = new InventárioMenu(p);
            this.Hide();
            i.Show();
        }

        private void habilidade1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidade1BoxPicture.Image = ByteArrayToImage(db.Habilidade.FirstOrDefault(h => h.Nome == habilidade1Combo.SelectedItem && h.FkIdPlayer == p.Id).Imagem, habilidade1BoxPicture);
        }

        private void novaHabilidade_Click(object sender, EventArgs e)
        {
            NovaHabilidade n = new NovaHabilidade(p, perso);
            n.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void habilidade2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidade2Picture.Image = ByteArrayToImage(db.Habilidade.FirstOrDefault(h => h.Nome == habilidade2Combo.SelectedItem && h.FkIdPlayer == p.Id).Imagem, habilidade2Picture);
        }

        private void habilidade3Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidade3Picture.Image = ByteArrayToImage(db.Habilidade.FirstOrDefault(h => h.Nome == habilidade3Combo.SelectedItem && h.FkIdPlayer == p.Id).Imagem, habilidade3Picture);
        }

        private void habilidade4Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidade4Picture.Image = ByteArrayToImage(db.Habilidade.FirstOrDefault(h => h.Nome == habilidade4Combo.SelectedItem && h.FkIdPlayer == p.Id).Imagem, habilidade4Picture);
        }

        private void habilidade5Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilidade5Picture.Image = ByteArrayToImage(db.Habilidade.FirstOrDefault(h => h.Nome == habilidade5Combo.SelectedItem && h.FkIdPlayer == p.Id).Imagem, habilidade4Picture);
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            perso.Habilidade1 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade1Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade2 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade2Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade3 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade3Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade4 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade4Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade5 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade5Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;

            db.Personagem.Update(perso);
            db.SaveChanges();
            Refresh();
        }

        private void salvarBt_Click_1(object sender, EventArgs e)
        {
            perso.Habilidade1 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade1Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade2 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade2Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade3 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade3Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade4 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade4Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;
            perso.Habilidade5 = db.Habilidade.FirstOrDefault(h => h.Nome == habilidade5Combo.SelectedItem && h.FkIdPlayer == p.Id).Id;

            db.Personagem.Update(perso);
            db.SaveChanges();
            Refresh();
        }
    }
}
