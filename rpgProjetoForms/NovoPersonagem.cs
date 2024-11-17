using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NetTopologySuite.Noding;
using rpgProjetoForms.Models;
using static System.Windows.Forms.DataFormats;

namespace rpgProjetoForms
{
    public partial class NovoPersonagem : Form
    {
        Player p;
        Contexto db;
        int atributosQtd = 4;
        int agilidadeQtd;
        int forcaQtd;
        int presencaQtd;
        int vigorQtd;
        int intelectoQtd;
        int vida;

        public int verQtd(NumericUpDown numeric, int atributo)
        {
            if (numeric.Value > atributo && atributosQtd > 0)
            {
                atributosQtd--;

            }
            else if (numeric.Value < atributo)
            {
                atributosQtd++;
            }

            else if (atributosQtd <= 0)
            {
                atributosQtd = 0;
                numeric.Value = atributo;
            }

            atributosLabel.Text = "Pontos de Atributos disponíveis: " + atributosQtd.ToString();
            return (int)numeric.Value;
        }

        public NovoPersonagem(Player player)
        {
            InitializeComponent();
            p = player;
            db = new Contexto();
            agilidadeQtd = 1;
            forcaQtd = 1;
            presencaQtd = 1;
            vigorQtd = 1;
            intelectoQtd = 1;
            vida = 50;

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventárioMenu i = new InventárioMenu(p);
            this.Hide();
            i.Show();
        }

        private void criarBt_Click(object sender, EventArgs e)
        {
            int agilidade = (int)agilidadeNum.Value;
            int forca = (int)forcaNum.Value;
            int intelecto = (int)intelectoNum.Value;
            int presenca = (int)presencaNum.Value;
            int vigor = (int)vigorNum.Value;

            if (nomeTbox.Text != "")
            {
                if (origemCombo.SelectedItem != null)
                {
                    if (origemCombo.SelectedItem == "Atleta")
                    {
                        agilidade++;
                    }
                    else if (origemCombo.SelectedItem == "Professor")
                    {
                        intelecto++;
                    }
                    else if (origemCombo.SelectedItem == "Lutador")
                    {
                        forca++;
                    }
                    else if (origemCombo.SelectedItem == "Sobrevivente de Guerra")
                    {
                        presenca++;
                    }
                    else if (origemCombo.SelectedItem == "Soldado")
                    {
                        vigor++;
                    }

                    Personagem pers = new Personagem();
                    pers.Vida = 40 + vigor * 10;
                    pers.Forca = forca;
                    pers.Presenca = presenca;
                    pers.Vigor = vigor;
                    pers.Intelecto = intelecto;
                    pers.Agilidade = agilidade;
                    pers.Nome = nomeTbox.Text;
                    pers.PontosEsforco = 20;
                    pers.Origem = origemCombo.SelectedItem.ToString();
                    db.Personagem.Add(pers);
                    db.SaveChanges();

                    ListaPersonagem lp = new ListaPersonagem();
                    lp.FkRpgPersonagemId = pers.Id;
                    lp.FkRpgPlayerId = p.Id;
                    db.ListaPersonagem.Add(lp);
                    db.SaveChanges();

                    MessageBox.Show("Personagem criado com sucesso!");
                    MessageBox.Show("Edite as habilidades dele agora!");
                }
                else
                {
                    MessageBox.Show("Escolha uma origem...");
                }
            }
            else
            {
                MessageBox.Show("Digite um nome para o personagem...");
            }


        }

        private void agilidadeNum_ValueChanged(object sender, EventArgs e)
        {
            agilidadeQtd = verQtd(agilidadeNum, agilidadeQtd);
            agilidadeNum.Value = agilidadeQtd;
        }

        private void forcaNum_ValueChanged(object sender, EventArgs e)
        {
            forcaQtd = verQtd(forcaNum, forcaQtd);
            forcaNum.Value = forcaQtd;
        }

        private void intelectoNum_ValueChanged(object sender, EventArgs e)
        {
            intelectoQtd = verQtd(intelectoNum, intelectoQtd);
            intelectoNum.Value = intelectoQtd;
        }

        private void presencaNum_ValueChanged(object sender, EventArgs e)
        {
            presencaQtd = verQtd(presencaNum, presencaQtd);
            presencaNum.Value = presencaQtd;
        }

        private void vigorNum_ValueChanged(object sender, EventArgs e)
        {
            vigorQtd = verQtd(vigorNum, vigorQtd);
            vigorNum.Value = vigorQtd;

            pvLabel.Text = "Pontos de vida: " + (40 + (vigorNum.Value * 10));
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quando você cria um personagem, todos os seus atributos começam em 1 e você recebe 4 pontos para distribuir entre eles\r\ncomo quiser. Você também pode reduzir um atributo para 0 para receber 1 ponto adicional. O valor máximo inicial \r\nque você pode ter em cada atributo é 3.\r\n\r\nOrigem: Vai te dar um adicional obrigatório em algo respectivo da origem.\r\n");
        }

        private void origemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (origemCombo.SelectedItem == "Atleta")
            {
                origemLabel.Text = "Origem - Aumenta a Agilidade em 1";
            }
            else if (origemCombo.SelectedItem == "Professor")
            {
                origemLabel.Text = "Origem - Aumenta o Intelecto em 1";
            }
            else if (origemCombo.SelectedItem == "Lutador")
            {
                origemLabel.Text = "Origem - Aumenta a Forca em 1";
            }
            else if (origemCombo.SelectedItem == "Sobrevivente de Guerra")
            {
                origemLabel.Text = "Origem - Aumenta a Presença em 1";
            }
            else if (origemCombo.SelectedItem == "Soldado")
            {
                origemLabel.Text = "Origem - Aumenta o Vigor em 1";
            }
            else
            {
                origemLabel.Text = "Origem";
            }
        }
    }
}
