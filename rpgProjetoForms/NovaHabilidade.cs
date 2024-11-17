using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using rpgProjetoForms.Models;

namespace rpgProjetoForms
{
    public partial class NovaHabilidade : Form
    {
        Personagem perso;
        Player p;
        Contexto db;
        string tipo;
        int fatorCusto;
        int fatorRound;
        string nomeImg;
        Bitmap localImg;
        public static byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return mStream.ToArray();
            }
        }

        public void CalculoCusto()
        {
            if (tipo != "cura" && tipo != "dano")
            {
                custoNum.Value = (int)(danotipoNum.Value * fatorCusto) + (int)(roundsNum.Value * fatorRound);
            }
            else
            {
                custoNum.Value = (int)(danotipoNum.Value * fatorCusto);
            }
        }
        public NovaHabilidade(Player player, Personagem personagem)
        {
            InitializeComponent();
            p = player;
            perso = personagem;
            db = new Contexto();
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tudoGroupBox.Visible = true;
            danotipoNum.Value = 0;
            custoNum.Value = 0;
            roundsNum.Value = 1;
            roundsGroup.Visible = false;
            criarBt.Enabled = true;

            if (tipoCombo.SelectedItem == "Cura")
            {
                danotipoLabel.Text = "Pontos de Cura:";
                tipo = "cura";

                danotipoNum.Maximum = 20;
                fatorCusto = 2;
            }
            else if (tipoCombo.SelectedItem == "Veneno")
            {
                danotipoLabel.Text = "Envenenamento: ";
                roundsGroup.Visible = true;
                tipo = "veneno";

                danotipoNum.Maximum = 10;
                fatorCusto = 1;
                fatorRound = 4;
            }
            else if (tipoCombo.SelectedItem == "Dano")
            {
                danotipoLabel.Text = "Dano: ";
                tipo = "dano";

                danotipoNum.Maximum = 40;
                fatorCusto = 1;
            }
            else if (tipoCombo.SelectedItem == "Buff Dano")
            {
                danotipoLabel.Text = "Buff Dano: ";
                roundsGroup.Visible = true;
                tipo = "buff_dano";

                danotipoNum.Maximum = 10;
                fatorCusto = 2;
                fatorRound = 2;
            }
            else if (tipoCombo.SelectedItem == "Buff Defesa")
            {
                danotipoLabel.Text = "Buff Defesa: ";
                roundsGroup.Visible = true;
                tipo = "buff_defesa";

                danotipoNum.Maximum = 5;
                fatorCusto = 2;
                fatorRound = 3;
            }
            else if (tipoCombo.SelectedItem == "Debuff Dano")
            {
                danotipoLabel.Text = "Debuff Dano: ";
                roundsGroup.Visible = true;

                tipo = "debuff_dano";

                danotipoNum.Maximum = 5;
                fatorCusto = 2;
                fatorRound = 3;
            }
            else if (tipoCombo.SelectedItem == "Debuff Defesa")
            {
                danotipoLabel.Text = "Debuff Defesa: ";
                roundsGroup.Visible = true;

                tipo = "debuff_defesa";

                danotipoNum.Maximum = 5;
                fatorCusto = 2;
                fatorRound = 3;
            }
        }

        private void danotipoNum_ValueChanged(object sender, EventArgs e)
        {
            CalculoCusto();
        }

        private void roundsNum_ValueChanged(object sender, EventArgs e)
        {
            CalculoCusto();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void uploadBt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image imagem = Image.FromFile(dialog.FileName);
                    imgBox.Image = imagem;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void criarBt_Click(object sender, EventArgs e)
        {
            if(habilidadeNomeTbox.Text != "")
            {
                Habilidade skill = new Habilidade();
                skill.Nome = habilidadeNomeTbox.Text;
                skill.Tipo = tipo;
                skill.Dano = (int)danotipoNum.Value;
                skill.Custo = (int)custoNum.Value;
                skill.Rounds_uso = (int)roundsNum.Value;
                skill.Imagem = ConvertImageToBinary(imgBox.Image);
                skill.FkIdPlayer = p.Id;
                db.Habilidade.Add(skill);
                await db.SaveChangesAsync();
                MessageBox.Show("Habilidade criada com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite um nome para a habilidade...");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
