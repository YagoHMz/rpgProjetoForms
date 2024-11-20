using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rpgProjetoForms.Models;

namespace rpgProjetoForms
{
    public partial class LutaTela : Form
    {
        Random geradorNum = new Random();
        Contexto db;
        Player player;
        Personagem p1;
        Personagem p2;
        Habilidade h1, h2, h3, h4, h5;
        Habilidade p2_h1, p2_h2, p2_h3, p2_h4, p2_h5;
        int round = 0;
        int vida, defesa, forca, presenca, vigor, intelecto, agilidade, defesa_buff, forca_buff, pontos_esforco;
        int vida2, defesa2, forca2, presenca2, vigor2, intelecto2, agilidade2, defesa_buff2, forca_buff2, pontos_esforco2;
        string jogada = "inicio";
        Habilidade player_habilidadeEscolhida, bot_habilidadeEscolhida;
        int buffRage=0, estagioRage=0;

        int contBuffDano = -3, contDebuffDano = -3, contBuffDefesa = -3, contDebuffDefesa = -3, contVeneno = -3;
        int contBuffDano2 = -3, contDebuffDano2 = -3, contBuffDefesa2 = -3, contDebuffDefesa2 = -3, contVeneno2 = -3;

        int buffDanoSalvar, debuffDanoSalvar, buffDefesaSalvar, debuffDefesaSalvar, venenoSalvar;
        int buffDanoSalvar2, debuffDanoSalvar2, buffDefesaSalvar2, debuffDefesaSalvar2, venenoSalvar2;



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
        public void ContadorPlayer()
        {
            //Contador do player1

            if (contBuffDano > 0)
            {
                contBuffDano--;
            }
            else if (contBuffDano == 0)
            {
                forca_buff -= buffDanoSalvar;
                contBuffDano = -1;
                MessageBox.Show("Buff de Dano Acabou!");
            }
            if (contBuffDefesa > 0)
            {
                contBuffDefesa--;
            }
            else if (contBuffDefesa == 0)
            {
                defesa_buff -= buffDefesaSalvar;
                contBuffDefesa = -1;
                MessageBox.Show("Buff de Defesa Acabou!");
            }
            if (contDebuffDano > 0)
            {
                contDebuffDano--;
            }
            else if (contDebuffDano == 0)
            {
                forca_buff2 += debuffDanoSalvar;
                contDebuffDano = -1;
                MessageBox.Show("DeBuff de Defesa Acabou!");
            }
            if (contDebuffDefesa > 0)
            {
                contDebuffDefesa--;
            }
            else if (contDebuffDefesa == 0)
            {
                defesa_buff2 += debuffDefesaSalvar;
                contDebuffDefesa = -1;
                MessageBox.Show("DeBuff de Defesa Acabou!");
            }
            if (contVeneno > 0)
            {
                contVeneno--;
                MessageBox.Show("Você deu +" + venenoSalvar + " de dano em veneno!");
                vida2 -= venenoSalvar;
            }
            else if (contVeneno == 0)
            {
                contVeneno = -1;
                MessageBox.Show("Veneno Acabou!");
            }
        }
        public void ContadorBot()
        {
            //Contador do botzin

            if (contBuffDano2 > 0)
            {
                contBuffDano2--;
            }
            else if (contBuffDano2 == 0)
            {
                forca_buff2 -= buffDanoSalvar2;
                contBuffDano2 = -1;
                MessageBox.Show("Buff de Dano do Ínimigo Acabou!");
            }
            if (contBuffDefesa2 > 0)
            {
                contBuffDefesa2--;
            }
            else if (contBuffDefesa2 == 0)
            {
                defesa_buff2 -= buffDefesaSalvar2;
                contBuffDefesa2 = -1;
                MessageBox.Show("Buff de Defesa do Inimigo Acabou!");
            }
            if (contDebuffDano2 > 0)
            {
                contDebuffDano2--;
            }
            else if (contDebuffDano2 == 0)
            {
                forca_buff += debuffDanoSalvar2;
                contDebuffDano2 = -1;
                MessageBox.Show("DeBuff de Defesa em você Acabou!");
            }
            if (contDebuffDefesa2 > 0)
            {
                contDebuffDefesa2--;
            }
            else if (contDebuffDefesa2 == 0)
            {
                defesa_buff += debuffDefesaSalvar2;
                contDebuffDefesa2 = -1;
                MessageBox.Show("DeBuff de Defesa em você Acabou!");
            }
            if (contVeneno2 > 0)
            {
                contVeneno2--;
                MessageBox.Show("Tomou +" + venenoSalvar2 + " de dano em veneno!");
                vida -= venenoSalvar2;
            }
            else if (contVeneno2 == 0)
            {
                contVeneno2 = -1;
                MessageBox.Show("Veneno Acabou!");
            }

            Refresh();
        }

        public void Refresh()
        {
            try
            {

                //Config Bot


                vida2Label.Text = "Vida: " + vida2;
                defesa2Label.Text = "Defesa: " + defesa2;
                forcabuffdebuff2label.Text = "Buff/Debuff Forca: " + forca_buff2;
                defesabuffdebuff2Label.Text = "Buff/Debuff Defesa: " + defesa_buff2;
                pontos2Label.Text = "Pontos de Esforço: " + pontos_esforco2;


                //Config Jogador

                vidaLabel.Text = "Vida: " + vida;
                defesaLabel.Text = "Defesa: " + defesa;
                forcaBuffDebuff.Text = "Buff/Debuff Forca: " + forca_buff;
                defesaBuffDebuff.Text = "Buff/Debuff Defesa: " + defesa_buff;
                pontosLabel.Text = "Pontos de Esforço: " + pontos_esforco;


            }

            catch (Exception)
            {

            }
        }

        public async void Rounds()
        {
            ContadorBot();
            ContadorPlayer();
            round++;
            player_habilidadeEscolhida = new Habilidade();
            bot_habilidadeEscolhida = new Habilidade();
            if (vida <= 0)
            {
                jogada = "jogador";
                MessageBox.Show("Você perdeu!!");
                Luta l = new Luta();
                l.Vencedor = "Bot1";
                l.Rounds = round;
                l.Fk_desafiado_id = 11;
                l.Fk_desafiante_id = player.Id;
                l.Status = "Derrotado";
                db.Luta.Add(l);

                player.Derrotas += 1;
                db.Player.Update(player);
                db.SaveChanges();

                TelaInicial t = new TelaInicial(player);
                t.Show();
                this.Close();
            }
            else if (vida2 <= 0)
            {
                jogada = "jogador";
                MessageBox.Show("Você ganhou!!");
                Luta l = new Luta();
                l.Vencedor = player.Nome;
                l.Rounds = round;
                l.Fk_desafiado_id = 11;
                l.Fk_desafiante_id = player.Id;
                l.Status = "Vitória";
                db.Luta.Add(l);

                player.Vitorias += 1;
                db.Player.Update(player);
                db.SaveChanges();

                TelaInicial t = new TelaInicial(player);
                t.Show();
                this.Close();
            }

            this.Text = "Luta - Round: " + round;
            habilidadeBot.Visible = false;
            pularBt.Enabled = false;
            usarBt.Enabled = false;
            if (jogada == "inicio")
            {
                int quemJoga = geradorNum.Next(1, 3);
                //quemJoga = 1;
                if (quemJoga == 1)
                {
                    MessageBox.Show("O Player começa!");
                    jogada = "player";
                    MessageBox.Show("Escolha uma habilidade ou skip!");
                }
                else
                {
                    MessageBox.Show("O Bot começa!");
                    jogada = "bot";
                }
            }

            await Task.Delay(2000);

            if (jogada == "player")
            {
                habilidadesEscolha.Enabled = true;
                pularBt.Enabled = true;
            }
            else if (jogada == "bot")
            {
                habilidadeBot.Visible = true;
                await Task.Delay(1000);
                habilidadesEscolha.Enabled = false;
                int rand = 0;
                string acao = "joga";

                do
                {

                    int qual = geradorNum.Next(1, 6);
                    rand++;

                    if (qual == 1)
                    {
                        bot_habilidadeEscolhida = p2_h1;
                    }
                    else if (qual == 2)
                    {
                        bot_habilidadeEscolhida = p2_h2;
                    }
                    else if (qual == 3)
                    {
                        bot_habilidadeEscolhida = p2_h3;
                    }
                    else if (qual == 4)
                    {
                        bot_habilidadeEscolhida = p2_h4;
                    }
                    else if (qual == 5)
                    {
                        bot_habilidadeEscolhida = p2_h5;
                    }

                    if (rand == 3)
                    {
                        jogada = "player";
                        acao = "skip";
                        habilidadeBot.Image = habilidadeBot.ErrorImage;
                        pontos_esforco2 += 7 + (4 * p2.Agilidade);
                        jogada = "player";
                        pontos_esforco2 += 5 + (4 * p1.Agilidade);
                        habilidadeBot.Visible = false;
                        pularBt.Enabled = false;
                        MessageBox.Show("O Inimigo decidiu Skipar!");
                        Rounds();
                        return;
                    }
                    else if (rand < 3)
                    {
                        acao = "joga";
                    }
                } while (bot_habilidadeEscolhida.Custo > pontos_esforco2 || rand > 3);

                int maior2 = 0;

                if (vida2 <= 20 && estagioRage == 0)
                {
                    int qual = geradorNum.Next(1, 10);
                    MessageBox.Show("" + p2.Nome + " se enfureceu!");
                    estagioRage = 1;
                    MessageBox.Show("Você tomou "+qual+" pontos de dano!");
                    vida -= qual;

                }

                else if (vida2 == 1 && estagioRage == 1)
                {
                    MessageBox.Show("" + p2.Nome + " vai dar seu último suspiro...");
                    estagioRage = 2;
                    MessageBox.Show("Rolando dados do adversário...");
                    for(int i=0; i<3; i++)
                    {
                        int qual = geradorNum.Next(1, 20);
                        if (qual > maior2)
                            maior2 = qual;

                        MessageBox.Show("Dado rolado: " + qual);

                    }


                }
            

                if(maior2 == 20 && estagioRage == 2)
                {
                    MessageBox.Show("Em seu último suspiro, o adversário usou todas suas forças e se regenerou!");
                    vida2 += 25;
                    acao = "skip";
                }
                else if(maior2 >= 15 && estagioRage == 2)
                {
                    MessageBox.Show("Em seu último suspiro, o adversário usou todas suas forças e te deu 10 de dano!");
                    vida -= 10;
                    acao = "skip";
                }

                if (acao == "joga")
                {
                    habilidadeBot.Visible = true;
                    nome2HabilidadeLabel.Text = bot_habilidadeEscolhida.Nome;
                    tipo2HabilidadeLabel.Text = "Tipo: " + bot_habilidadeEscolhida.Tipo;
                    if (bot_habilidadeEscolhida.Tipo.ToLower() == "cura")
                    {
                        danocura2Label.Text = "Cura: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Visible = false;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "dano")
                    {
                        danocura2Label.Text = "Dano: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Visible = false;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "buff_defesa")
                    {
                        danocura2Label.Text = "Buff Defesa: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Text = "Rounds: " + bot_habilidadeEscolhida.Rounds_uso;
                        rounds2Label.Visible = true;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "buff_dano")
                    {
                        danocura2Label.Text = "Buff Dano: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Text = "Rounds: " + bot_habilidadeEscolhida.Rounds_uso;
                        rounds2Label.Visible = true;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "debuff_dano")
                    {
                        danocura2Label.Text = "Debuff Dano: " + bot_habilidadeEscolhida.Dano;
                        roundsUso.Text = "Rounds: " + bot_habilidadeEscolhida.Rounds_uso;
                        rounds2Label.Visible = true;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "debuff_defesa")
                    {
                        danocura2Label.Text = "Debuff Defesa: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Text = "Rounds: " + bot_habilidadeEscolhida.Rounds_uso;
                        rounds2Label.Visible = true;
                    }
                    else if (bot_habilidadeEscolhida.Tipo.ToLower() == "veneno")
                    {
                        danocura2Label.Text = "Veneno: " + bot_habilidadeEscolhida.Dano;
                        rounds2Label.Text = "Rounds: " + bot_habilidadeEscolhida.Rounds_uso;
                        rounds2Label.Visible = true;
                    }
                    custo2Label.Text = "Custo: " + bot_habilidadeEscolhida.Custo;

                    habilidadeBot.Image = ByteArrayToImage(bot_habilidadeEscolhida.Imagem, habilidadeBot);
                    try
                    {
                        MessageBox.Show("Habilidade Usada: " + bot_habilidadeEscolhida.Nome);
                        pontos_esforco2 -= bot_habilidadeEscolhida.Custo;
                        if (bot_habilidadeEscolhida.Tipo.ToLower() == "cura")
                        {
                            vida2 += bot_habilidadeEscolhida.Dano;
                        }
                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "dano")
                        {
                            if (p2.Forca >= 1)
                            {
                                MessageBox.Show("Rolando dados...");
                                int dado = geradorNum.Next(1, 20);
                                int maior = 0;
                                int dano = 0;
                                for (int i = 0; i < p1.Forca; i++)
                                {
                                    dado = geradorNum.Next(1, 20);
                                    if (dado > maior)
                                    {
                                        maior = dado;
                                    }
                                    MessageBox.Show("Número rolado: " + dado);
                                }
                                MessageBox.Show("Maior número: " + maior);
                                if (maior == 1)
                                {
                                    MessageBox.Show("Desastre!");
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - defesa;
                                }
                                else if (maior <= 5)
                                {
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - 5 - defesa;
                                }
                                else if (maior <= 9)
                                {
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - 2 - defesa;
                                }
                                else if (maior <= 15)
                                {
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - defesa;
                                }
                                else if (maior <= 19)
                                {
                                    MessageBox.Show("Você foi acertado em cheio!");
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) + 2 - defesa;
                                }
                                else if (maior == 20)
                                {
                                    MessageBox.Show("Crítico!");
                                    dano = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) + 5 - defesa;
                                }
                                vida -= dano;
                                MessageBox.Show("Dano causado: " + dano);
                            }
                            else
                            {
                                vida = bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - 5 - defesa;
                                MessageBox.Show("Dano causado: " + (bot_habilidadeEscolhida.Dano + forca_buff2 + (-1 * defesa_buff) - 5 - defesa));
                            }

                        }
                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "buff_defesa")
                        {
                            defesa2 += bot_habilidadeEscolhida.Dano;
                            contBuffDefesa2 = bot_habilidadeEscolhida.Rounds_uso;
                            buffDefesaSalvar2 = bot_habilidadeEscolhida.Dano;
                        }
                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "buff_dano")
                        {
                            forca_buff2 += bot_habilidadeEscolhida.Dano;
                            contBuffDano2 = bot_habilidadeEscolhida.Rounds_uso;
                            buffDanoSalvar2 = bot_habilidadeEscolhida.Dano;
                        }
                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "debuff_dano")
                        {
                            if (p1.Intelecto >= 1)
                            {
                                MessageBox.Show("Rolando dados...");
                                int dado = geradorNum.Next(1, 20);
                                int maior = 0;
                                int dano = 0;
                                for (int i = 0; i < p1.Intelecto; i++)
                                {
                                    dado = geradorNum.Next(1, 20);
                                    if (dado > maior)
                                    {
                                        maior = dado;
                                    }
                                    MessageBox.Show("Número rolado: " + dado);
                                }
                                MessageBox.Show("Maior número: " + maior);

                                if (maior == 20)
                                {
                                    MessageBox.Show("Inimigo desviou!");
                                    MessageBox.Show("Desastre! Se atacou");
                                    vida2 -= 5;
                                }
                                else if (maior >= 17)
                                {
                                    MessageBox.Show("Você desviou!");
                                }
                                else if (maior >= 15)
                                {
                                    MessageBox.Show("Te atacou! Mas tomou um pouco de dano!");
                                    vida2 -= 2;
                                    forca_buff -= bot_habilidadeEscolhida.Dano;
                                    contDebuffDano2 = 1 + bot_habilidadeEscolhida.Rounds_uso;
                                    debuffDanoSalvar2 = bot_habilidadeEscolhida.Dano;
                                }
                                else if (maior >= 9)
                                {
                                    forca_buff -= bot_habilidadeEscolhida.Dano;
                                    contDebuffDano2 = 1 + bot_habilidadeEscolhida.Rounds_uso;
                                    debuffDanoSalvar2 = bot_habilidadeEscolhida.Dano;
                                }
                                else if (maior <= 4)
                                {
                                    MessageBox.Show("Você caiu ao tentar desviar!!");
                                }

                            }
                            else
                            {
                                forca_buff -= bot_habilidadeEscolhida.Dano + 2;
                                contDebuffDano2 = 1 + bot_habilidadeEscolhida.Rounds_uso;
                                debuffDanoSalvar2 = bot_habilidadeEscolhida.Dano + 2;
                            }
                        }

                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "debuff_defesa")
                        {
                            if (p1.Intelecto >= 1)
                            {
                                MessageBox.Show("Rolando dados...");
                                int dado = geradorNum.Next(1, 20);
                                int maior = 0;
                                int dano = 0;
                                for (int i = 0; i < p1.Intelecto; i++)
                                {
                                    dado = geradorNum.Next(1, 20);
                                    if (dado > maior)
                                    {
                                        maior = dado;
                                    }
                                    MessageBox.Show("Número rolado: " + dado);
                                }
                                MessageBox.Show("Maior número: " + maior);

                                if (maior == 20)
                                {
                                    MessageBox.Show("Você desviou!");
                                    MessageBox.Show("Desastre! Se atacou");
                                    vida -= 5;
                                }
                                else if (maior >= 17)
                                {
                                    MessageBox.Show("Você desviou!");
                                }
                                else if (maior >= 15)
                                {
                                    MessageBox.Show("Te Atacou! Mas tomou um pouco de dano!");
                                    vida2 -= 2;
                                    defesa_buff -= bot_habilidadeEscolhida.Dano;
                                    contDebuffDefesa2 = bot_habilidadeEscolhida.Rounds_uso;
                                    debuffDefesaSalvar2 = bot_habilidadeEscolhida.Dano;
                                }
                                else if (maior >= 9)
                                {
                                    defesa_buff -= bot_habilidadeEscolhida.Dano;
                                    contDebuffDefesa2 = bot_habilidadeEscolhida.Rounds_uso;
                                    debuffDefesaSalvar2 = bot_habilidadeEscolhida.Dano;
                                }
                                else if (maior <= 4)
                                {
                                    MessageBox.Show("Você caiu ao tentar desviar!!");
                                    vida2 -= 3;
                                }
                            }
                            else
                            {
                                defesa_buff -= bot_habilidadeEscolhida.Dano;
                                contDebuffDefesa2 = bot_habilidadeEscolhida.Rounds_uso;
                                debuffDefesaSalvar2 = bot_habilidadeEscolhida.Dano;
                            }
                        }
                        else if (bot_habilidadeEscolhida.Tipo.ToLower() == "veneno")
                        {
                            if (p1.Intelecto >= 1)
                            {
                                MessageBox.Show("Rolando dados...");
                                int dado = geradorNum.Next(1, 20);
                                int maior = 0;
                                int dano = 0;
                                for (int i = 0; i < p1.Intelecto; i++)
                                {
                                    dado = geradorNum.Next(1, 20);
                                    if (dado > maior)
                                    {
                                        maior = dado;
                                    }
                                    MessageBox.Show("Número rolado: " + dado);
                                }
                                MessageBox.Show("Maior número: " + maior);

                                if (maior == 20)
                                {
                                    MessageBox.Show("Você desviou!");
                                    MessageBox.Show("Desastre! Se atacou");
                                    vida2 -= 5;
                                }
                                else if (maior >= 17)
                                {
                                    MessageBox.Show("Você desviou!");
                                }
                                else if (maior >= 15)
                                {
                                    MessageBox.Show("Te Atacou! Mas tomou um pouco de dano!");
                                    vida2 -= 2;
                                    venenoSalvar2 = bot_habilidadeEscolhida.Dano;
                                    contVeneno2 = bot_habilidadeEscolhida.Rounds_uso;
                                }
                                else if (maior >= 9)
                                {
                                    venenoSalvar2 = bot_habilidadeEscolhida.Dano;
                                    contVeneno2 = bot_habilidadeEscolhida.Rounds_uso;
                                }
                                else if (maior <= 4)
                                {
                                    MessageBox.Show("Você caiu ao tentar desviar!!");
                                    vida -= 3;
                                }
                            }
                            else
                            {
                                venenoSalvar2 = bot_habilidadeEscolhida.Dano + 3;
                                contVeneno2 = bot_habilidadeEscolhida.Rounds_uso;
                            }
                        }
                        jogada = "player";
                        //pontos_esforco2 += 10 + (2 * p1.Agilidade);
                        Rounds();

                        habilidadeBot.Image = habilidadeBot.ErrorImage;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Escolha uma habilidade!");
                    }

                }
                /*if (acao == "skip" || habilidadePlayer2.Image == habilidadePlayer2.ErrorImage)
                {
                    jogada = "player";
                    pontos_esforco2 += 5 + (4 * p1.Agilidade);
                    habilidadePlayer2.Visible = false;
                    pularBt.Enabled = false;
                    MessageBox.Show("O Inimigo decidiu Skipar!");
                    Rounds();
                }*/
            }
        }
        public LutaTela(Player player, Personagem perso1, Personagem perso2)
        {
            InitializeComponent();
            this.player = player;
            p1 = perso1;
            p2 = perso2;
            db = new Contexto();

            forcaPlayer.Text = "Força: " + p1.Forca;
            presencaPlayer.Text = "Presença: " + p1.Presenca;
            vigorPlayer.Text = "Vigor: " + p1.Vigor;
            intelectoPlayer.Text = "Intelecto: " + p1.Intelecto;
            agilidadePlayer.Text = "Intelecto: " + p1.Agilidade;

            forcaBot.Text = "Força: " + p2.Forca;
            presencaBot.Text = "Presença: " + p2.Presenca;
            vigorBot.Text = "Vigor: " + p2.Vigor;
            intelectoBot.Text = "Intelecto: " + p2.Intelecto;
            agilidadeBot.Text = "Intelecto: " + p2.Agilidade;

            vida2 = p2.Vida;
            defesa2 = p2.Defesa;
            forca2 = p2.Forca;
            presenca2 = p2.Presenca;
            vigor2 = p2.Vigor;
            intelecto2 = p2.Intelecto;
            agilidade2 = p2.Agilidade;
            defesa_buff2 = p2.Defesa_buff;
            forca_buff2 = p2.Forca_buff;
            pontos_esforco2 = p2.PontosEsforco;
            nome2PersonagemLabel.Text = "Bot - " + p2.Nome;

            vida = p1.Vida;
            defesa = p1.Defesa;
            forca = p1.Forca;
            presenca = p1.Presenca;
            vigor = p1.Vigor;
            intelecto = p1.Intelecto;
            agilidade = p1.Agilidade;
            defesa_buff = p1.Defesa_buff;
            forca_buff = p1.Forca_buff;
            pontos_esforco = p1.PontosEsforco;
            nomeLabel.Text = player.Nome + " - " + p1.Nome;

            if (db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade1) != null)
                h1 = db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade1);
            else
                h1 = db.Habilidade.FirstOrDefault(h => h.Id == 5);


            if (db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade2) != null)
                h2 = db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade2);
            else
                h2 = db.Habilidade.FirstOrDefault(h => h.Id == 5);


            if (db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade3) != null)
                h3 = db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade3);
            else
                h3 = db.Habilidade.FirstOrDefault(h => h.Id == 5);


            if (db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade4) != null)
                h4 = db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade4);
            else
                h4 = db.Habilidade.FirstOrDefault(h => h.Id == 5);


            if (db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade5) != null)
                h5 = db.Habilidade.FirstOrDefault(h => h.Id == p1.Habilidade5);
            else
                h5 = db.Habilidade.FirstOrDefault(h => h.Id == 5);

            p2_h1 = db.Habilidade.FirstOrDefault(h => h.Id == p2.Habilidade1);
            p2_h2 = db.Habilidade.FirstOrDefault(h => h.Id == p2.Habilidade2);
            p2_h3 = db.Habilidade.FirstOrDefault(h => h.Id == p2.Habilidade3);
            p2_h4 = db.Habilidade.FirstOrDefault(h => h.Id == p2.Habilidade4);
            p2_h5 = db.Habilidade.FirstOrDefault(h => h.Id == p2.Habilidade5);

            if (ByteArrayToImage(h1.Imagem, habilidade1BoxPicture) != null)
            {
                habilidade1BoxPicture.Image = ByteArrayToImage(h1.Imagem, habilidade1BoxPicture);
            }
            if (ByteArrayToImage(h2.Imagem, habilidade2Picture) != null)
            {
                habilidade2Picture.Image = ByteArrayToImage(h2.Imagem, habilidade2Picture);
            }
            if (ByteArrayToImage(h3.Imagem, habilidade3Picture) != null)
            {
                habilidade3Picture.Image = ByteArrayToImage(h3.Imagem, habilidade3Picture);
            }
            if (ByteArrayToImage(h4.Imagem, habilidade4Picture) != null)
            {
                habilidade4Picture.Image = ByteArrayToImage(h4.Imagem, habilidade4Picture);
            }
            if (ByteArrayToImage(h5.Imagem, habilidade5Picture) != null)
            {
                habilidade5Picture.Image = ByteArrayToImage(h5.Imagem, habilidade5Picture);
            }

            Refresh();
            Rounds();

        }

        private void usarBt_Click(object sender, EventArgs e)
        {
            try
            {
                pontos_esforco -= player_habilidadeEscolhida.Custo;
                if (player_habilidadeEscolhida.Tipo.ToLower() == "cura")
                {
                    vida += player_habilidadeEscolhida.Dano;
                    MessageBox.Show(vida.ToString());
                }
                else if (player_habilidadeEscolhida.Tipo.ToLower() == "dano")
                {
                    if (p1.Forca >= 1)
                    {
                        MessageBox.Show("Rolando dados...");
                        int dado = geradorNum.Next(1, 20);
                        int maior = 0;
                        int dano = 0;
                        for (int i = 0; i < p1.Forca; i++)
                        {
                            dado = geradorNum.Next(1, 20);
                            if (dado > maior)
                            {
                                maior = dado;
                            }
                            MessageBox.Show("Número rolado: " + dado);
                        }
                        MessageBox.Show("Maior número: " + maior);
                        if (maior == 1)
                        {
                            MessageBox.Show("Desastre!");
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) - defesa2;
                        }
                        else if (maior <= 5)
                        {
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) - 5 - defesa2;
                        }
                        else if (maior <= 9)
                        {
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) - 2 - defesa2;
                        }
                        else if (maior <= 15)
                        {
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) - defesa2;
                        }
                        else if (maior <= 19)
                        {
                            MessageBox.Show("Você acertou em cheio!");
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) + 2 - defesa2;
                        }
                        else if (maior == 20)
                        {
                            MessageBox.Show("Crítico!");
                            dano = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) + 5 - defesa2;
                        }
                        vida2 -= dano;
                        MessageBox.Show("Dano causado: " + dano);
                    }
                    else
                    {
                        vida2 = player_habilidadeEscolhida.Dano + forca_buff + (-1 * defesa_buff2) - 5 - defesa2;
                        MessageBox.Show("Dano causado: " + (player_habilidadeEscolhida.Dano + forca_buff - defesa2 - 5));
                    }

                }
                else if (player_habilidadeEscolhida.Tipo.ToLower() == "buff_defesa")
                {
                    defesa += player_habilidadeEscolhida.Dano;
                    contBuffDefesa = player_habilidadeEscolhida.Rounds_uso;
                    buffDefesaSalvar = player_habilidadeEscolhida.Dano;
                }
                else if (player_habilidadeEscolhida.Tipo.ToLower() == "buff_dano")
                {
                    forca_buff += player_habilidadeEscolhida.Dano;
                    contBuffDano = player_habilidadeEscolhida.Rounds_uso;
                    buffDanoSalvar = player_habilidadeEscolhida.Dano;
                }
                else if (player_habilidadeEscolhida.Tipo.ToLower() == "debuff_dano")
                {
                    if (p2.Intelecto >= 1)
                    {
                        MessageBox.Show("Rolando dados...");
                        int dado = geradorNum.Next(1, 20);
                        int maior = 0;
                        int dano = 0;
                        for (int i = 0; i < p2.Intelecto; i++)
                        {
                            dado = geradorNum.Next(1, 20);
                            if (dado > maior)
                            {
                                maior = dado;
                            }
                            MessageBox.Show("Número rolado: " + dado);
                        }
                        MessageBox.Show("Maior número: " + maior);

                        if (maior == 20)
                        {
                            MessageBox.Show("Inimigo desviou!");
                            MessageBox.Show("Desastre! Se atacou");
                            vida -= 5;
                        }
                        else if (maior >= 17)
                        {
                            MessageBox.Show("Inimigo desviou!");
                        }
                        else if (maior >= 15)
                        {
                            MessageBox.Show("Atacou! Mas tomou um pouco de dano!");
                            vida -= 2;
                            forca_buff2 -= player_habilidadeEscolhida.Dano;
                            contDebuffDano = 1 + player_habilidadeEscolhida.Rounds_uso;
                            debuffDanoSalvar = player_habilidadeEscolhida.Dano;
                        }
                        else if (maior >= 9)
                        {
                            forca_buff2 -= player_habilidadeEscolhida.Dano;
                            contDebuffDano = 1 + player_habilidadeEscolhida.Rounds_uso;
                            debuffDanoSalvar = player_habilidadeEscolhida.Dano;
                        }
                        else if (maior <= 4)
                        {
                            MessageBox.Show("O inimigo caiu ao tentar desviar!!");
                        }

                    }
                    else
                    {
                        forca_buff2 -= player_habilidadeEscolhida.Dano + 2;
                        contDebuffDano = 1 + player_habilidadeEscolhida.Rounds_uso;
                        debuffDanoSalvar = player_habilidadeEscolhida.Dano + 2;
                    }
                }

                else if (player_habilidadeEscolhida.Tipo.ToLower() == "debuff_defesa")
                {
                    if (p2.Intelecto >= 1)
                    {
                        MessageBox.Show("Rolando dados...");
                        int dado = geradorNum.Next(1, 20);
                        int maior = 0;
                        int dano = 0;
                        for (int i = 0; i < p2.Intelecto; i++)
                        {
                            dado = geradorNum.Next(1, 20);
                            if (dado > maior)
                            {
                                maior = dado;
                            }
                            MessageBox.Show("Número rolado: " + dado);
                        }
                        MessageBox.Show("Maior número: " + maior);

                        if (maior == 20)
                        {
                            MessageBox.Show("Inimigo desviou!");
                            MessageBox.Show("Desastre! Se atacou");
                            vida -= 5;
                        }
                        else if (maior >= 17)
                        {
                            MessageBox.Show("Inimigo desviou!");
                        }
                        else if (maior >= 15)
                        {
                            MessageBox.Show("Atacou! Mas tomou um pouco de dano!");
                            vida -= 2;
                            defesa_buff2 -= player_habilidadeEscolhida.Dano;
                            contDebuffDefesa = player_habilidadeEscolhida.Rounds_uso;
                            debuffDefesaSalvar = player_habilidadeEscolhida.Dano;
                        }
                        else if (maior >= 9)
                        {
                            defesa_buff2 -= player_habilidadeEscolhida.Dano;
                            contDebuffDefesa = player_habilidadeEscolhida.Rounds_uso;
                            debuffDefesaSalvar = player_habilidadeEscolhida.Dano;
                        }
                        else if (maior <= 4)
                        {
                            MessageBox.Show("O inimigo caiu ao tentar desviar!!");
                            vida2 -= 3;
                        }
                    }
                    else
                    {
                        defesa_buff2 -= player_habilidadeEscolhida.Dano;
                        contDebuffDefesa = player_habilidadeEscolhida.Rounds_uso;
                        debuffDefesaSalvar = player_habilidadeEscolhida.Dano;
                    }
                }
                else if (player_habilidadeEscolhida.Tipo.ToLower() == "veneno")
                {
                    if (p2.Presenca >= 1)
                    {
                        MessageBox.Show("Rolando dados...");
                        int dado = geradorNum.Next(1, 20);
                        int maior = 0;
                        int dano = 0;
                        for (int i = 0; i < p2.Presenca; i++)
                        {
                            dado = geradorNum.Next(1, 20);
                            if (dado > maior)
                            {
                                maior = dado;
                            }
                            MessageBox.Show("Número rolado: " + dado);
                        }
                        MessageBox.Show("Maior número: " + maior);

                        if (maior == 20)
                        {
                            MessageBox.Show("Inimigo desviou!");
                            MessageBox.Show("Desastre! Se atacou");
                            vida -= 5;
                        }
                        else if (maior >= 17)
                        {
                            MessageBox.Show("Inimigo desviou!");
                        }
                        else if (maior >= 15)
                        {
                            MessageBox.Show("Atacou! Mas tomou um pouco de dano!");
                            vida -= 2;
                            venenoSalvar = player_habilidadeEscolhida.Dano;
                            contVeneno = player_habilidadeEscolhida.Rounds_uso;
                        }
                        else if (maior >= 9)
                        {
                            venenoSalvar = player_habilidadeEscolhida.Dano;
                            contVeneno = player_habilidadeEscolhida.Rounds_uso;
                        }
                        else if (maior <= 4)
                        {
                            MessageBox.Show("O inimigo caiu ao tentar desviar!!");
                            vida2 -= 3;
                        }
                    }
                    else
                    {
                        venenoSalvar = player_habilidadeEscolhida.Dano + 3;
                        contVeneno = player_habilidadeEscolhida.Rounds_uso;
                    }
                }
                jogada = "bot";
                //pontos_esforco += 10 + (2 * p1.Agilidade);
                Rounds();
            }
            catch (Exception)
            {
                MessageBox.Show("Escolha uma habilidade!");
            }

        }

        private void habilidade1BoxPicture_Click(object sender, EventArgs e)
        {
            if (jogada == "player")
            {
                groupBoxPlayer1.Visible = true;
                nomeHabilidadeLabel.Text = "Nome: " + h1.Nome;
                tipoLabel.Text = "Tipo: " + h1.Tipo;
                if (h1.Tipo.ToLower() == "cura")
                {
                    danoCuraLabel.Text = "Cura: " + h1.Dano;
                    roundsUso.Visible = false;
                }
                else if (h1.Tipo.ToLower() == "dano")
                {
                    danoCuraLabel.Text = "Dano: " + h1.Dano;
                    roundsUso.Visible = false;
                }
                else if (h1.Tipo.ToLower() == "buff_defesa")
                {
                    danoCuraLabel.Text = "Buff Defesa: " + h1.Dano;
                    roundsUso.Text = "Rounds: " + h1.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h1.Tipo.ToLower() == "buff_dano")
                {
                    danoCuraLabel.Text = "Buff Dano: " + h1.Dano;
                    roundsUso.Text = "Rounds: " + h1.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h1.Tipo.ToLower() == "debuff_dano")
                {
                    danoCuraLabel.Text = "Debuff Dano: " + h1.Dano;
                    roundsUso.Text = "Rounds: " + h1.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h1.Tipo.ToLower() == "debuff_defesa")
                {
                    danoCuraLabel.Text = "Debuff Defesa: " + h1.Dano;
                    roundsUso.Text = "Rounds: " + h1.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h1.Tipo.ToLower() == "veneno")
                {
                    danoCuraLabel.Text = "Veneno: " + h1.Dano;
                    roundsUso.Text = "Rounds: " + h1.Rounds_uso;
                    roundsUso.Visible = true;
                }
                custoLabel.Text = "Custo: " + h1.Custo;
                player_habilidadeEscolhida = h1;
                if (h1.Custo > pontos_esforco)
                {
                    usarBt.Enabled = false;
                }
                else
                {
                    usarBt.Enabled = true;
                }
            }
        }

        private void habilidade2Picture_Click(object sender, EventArgs e)
        {
            if (jogada == "player")
            {
                groupBoxPlayer1.Visible = true;
                nomeHabilidadeLabel.Text = "Nome: " + h2.Nome;
                tipoLabel.Text = "Tipo: " + h2.Tipo;
                if (h2.Tipo.ToLower() == "cura")
                {
                    danoCuraLabel.Text = "Cura: " + h2.Dano;
                    roundsUso.Visible = false;
                }
                else if (h2.Tipo.ToLower() == "dano")
                {
                    danoCuraLabel.Text = "Dano: " + h2.Dano;
                    roundsUso.Visible = false;
                }
                else if (h2.Tipo.ToLower() == "buff_defesa")
                {
                    danoCuraLabel.Text = "Buff Defesa: " + h2.Dano;
                    roundsUso.Text = "Rounds: " + h2.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h2.Tipo.ToLower() == "buff_dano")
                {
                    danoCuraLabel.Text = "Buff Dano: " + h2.Dano;
                    roundsUso.Text = "Rounds: " + h2.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h2.Tipo.ToLower() == "debuff_dano")
                {
                    danoCuraLabel.Text = "Debuff Dano: " + h2.Dano;
                    roundsUso.Text = "Rounds: " + h2.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h2.Tipo.ToLower() == "debuff_defesa")
                {
                    danoCuraLabel.Text = "Debuff Defesa: " + h2.Dano;
                    roundsUso.Text = "Rounds: " + h2.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h2.Tipo.ToLower() == "veneno")
                {
                    danoCuraLabel.Text = "Veneno: " + h2.Dano;
                    roundsUso.Text = "Rounds: " + h2.Rounds_uso;
                    roundsUso.Visible = true;
                }
                custoLabel.Text = "Custo: " + h2.Custo;
                player_habilidadeEscolhida = h2;
                if (h2.Custo > pontos_esforco)
                {
                    usarBt.Enabled = false;
                }
                else
                {
                    usarBt.Enabled = true;
                }
            }
        }

        private void habilidade3Picture_Click(object sender, EventArgs e)
        {
            if (jogada == "player")
            {
                groupBoxPlayer1.Visible = true;
                nomeHabilidadeLabel.Text = "Nome: " + h3.Nome;
                tipoLabel.Text = "Tipo: " + h3.Tipo;
                if (h3.Tipo.ToLower() == "cura")
                {
                    danoCuraLabel.Text = "Cura: " + h3.Dano;
                    roundsUso.Visible = false;
                }
                else if (h3.Tipo.ToLower() == "dano")
                {
                    danoCuraLabel.Text = "Dano: " + h3.Dano;
                    roundsUso.Visible = false;
                }
                else if (h3.Tipo.ToLower() == "buff_defesa")
                {
                    danoCuraLabel.Text = "Buff Defesa: " + h3.Dano;
                    roundsUso.Text = "Rounds: " + h3.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h3.Tipo.ToLower() == "buff_dano")
                {
                    danoCuraLabel.Text = "Buff Dano: " + h3.Dano;
                    roundsUso.Text = "Rounds: " + h3.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h3.Tipo.ToLower() == "debuff_dano")
                {
                    danoCuraLabel.Text = "Debuff Dano: " + h3.Dano;
                    roundsUso.Text = "Rounds: " + h3.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h3.Tipo.ToLower() == "debuff_defesa")
                {
                    danoCuraLabel.Text = "Debuff Defesa: " + h3.Dano;
                    roundsUso.Text = "Rounds: " + h3.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h3.Tipo.ToLower() == "veneno")
                {
                    danoCuraLabel.Text = "Veneno: " + h3.Dano;
                    roundsUso.Text = "Rounds: " + h3.Rounds_uso;
                    roundsUso.Visible = true;
                }
                custoLabel.Text = "Custo: " + h3.Custo;
                player_habilidadeEscolhida = h3;
                if (h3.Custo > pontos_esforco)
                {
                    usarBt.Enabled = false;
                }
                else
                {
                    usarBt.Enabled = true;
                }
            }
        }

        private void habilidade4Picture_Click(object sender, EventArgs e)
        {
            if (jogada == "player")
            {
                groupBoxPlayer1.Visible = true;
                nomeHabilidadeLabel.Text = "Nome: " + h4.Nome;
                tipoLabel.Text = "Tipo: " + h4.Tipo;
                if (h4.Tipo.ToLower() == "cura")
                {
                    danoCuraLabel.Text = "Cura: " + h4.Dano;
                    roundsUso.Visible = false;
                }
                else if (h4.Tipo.ToLower() == "dano")
                {
                    danoCuraLabel.Text = "Dano: " + h4.Dano;
                    roundsUso.Visible = false;
                }
                else if (h4.Tipo.ToLower() == "buff_defesa")
                {
                    danoCuraLabel.Text = "Buff Defesa: " + h4.Dano;
                    roundsUso.Text = "Rounds: " + h4.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h4.Tipo.ToLower() == "buff_dano")
                {
                    danoCuraLabel.Text = "Buff Dano: " + h4.Dano;
                    roundsUso.Text = "Rounds: " + h4.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h4.Tipo.ToLower() == "debuff_dano")
                {
                    danoCuraLabel.Text = "Debuff Dano: " + h4.Dano;
                    roundsUso.Visible = true;
                }
                else if (h4.Tipo.ToLower() == "debuff_defesa")
                {
                    danoCuraLabel.Text = "Debuff Defesa: " + h4.Dano;
                    roundsUso.Text = "Rounds: " + h4.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h4.Tipo.ToLower() == "veneno")
                {
                    danoCuraLabel.Text = "Veneno: " + h4.Dano;
                    roundsUso.Text = "Rounds: " + h4.Rounds_uso;
                    roundsUso.Visible = true;
                }
                custoLabel.Text = "Custo: " + h4.Custo;
                player_habilidadeEscolhida = h4;
                if (h4.Custo > pontos_esforco)
                {
                    usarBt.Enabled = false;
                }
                else
                {
                    usarBt.Enabled = true;
                }
            }
        }

        private void habilidade5Picture_Click(object sender, EventArgs e)
        {
            if (jogada == "player")
            {
                groupBoxPlayer1.Visible = true;
                nomeHabilidadeLabel.Text = "Nome: " + h5.Nome;
                tipoLabel.Text = "Tipo: " + h5.Tipo;
                if (h5.Tipo.ToLower() == "cura")
                {
                    danoCuraLabel.Text = "Cura: " + h5.Dano;
                    roundsUso.Visible = false;
                }
                else if (h5.Tipo.ToLower() == "dano")
                {
                    danoCuraLabel.Text = "Dano: " + h5.Dano;
                    roundsUso.Visible = false;
                }
                else if (h5.Tipo.ToLower() == "buff_defesa")
                {
                    danoCuraLabel.Text = "Buff Defesa: " + h5.Dano;
                    roundsUso.Text = "Rounds: " + h5.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h5.Tipo.ToLower() == "buff_dano")
                {
                    danoCuraLabel.Text = "Buff Dano: " + h5.Dano;
                    roundsUso.Text = "Rounds: " + h5.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h5.Tipo.ToLower() == "debuff_dano")
                {
                    danoCuraLabel.Text = "Debuff Dano: " + h5.Dano;
                    roundsUso.Text = "Rounds: " + h5.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h5.Tipo.ToLower() == "debuff_defesa")
                {
                    danoCuraLabel.Text = "Debuff Defesa: " + h5.Dano;
                    roundsUso.Text = "Rounds: " + h5.Rounds_uso;
                    roundsUso.Visible = true;
                }
                else if (h5.Tipo.ToLower() == "veneno")
                {
                    danoCuraLabel.Text = "Veneno: " + h5.Dano;
                    roundsUso.Text = "Rounds: " + h5.Rounds_uso;
                    roundsUso.Visible = true;
                }
                custoLabel.Text = "Custo: " + h5.Custo;
                player_habilidadeEscolhida = h5;
                if (h5.Custo > pontos_esforco)
                {
                    usarBt.Enabled = false;
                }
                else
                {
                    usarBt.Enabled = true;
                }
            }
        }

        private void pularBt_Click(object sender, EventArgs e)
        {
            jogada = "bot";
            pontos_esforco += 7 + (4 * p1.Agilidade);
            Rounds();
        }

        private void sairBt_Click(object sender, EventArgs e)
        {
            LutaMenu l = new LutaMenu(player, p1);
            l.Show();
            this.Hide();

        }
    }
}
