using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{
    [Table("rpg_personagem")]
    public class Personagem
    {
        private int id;
        private string nome;
        private int defesa;
        private int vida;
        private int forca;
        private int presenca;
        private int vigor;
        private int intelecto;
        private int forca_buff;
        private int defesa_buff;
        private int agilidade;
        private string origem;

        private int habilidade1;
        private int habilidade2;
        private int habilidade3;
        private int habilidade4;
        private int habilidade5;

        private int pontosEsforco;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("defesa")]
        public int Defesa { get => defesa; set => defesa = value; }

        [Column("vida")]
        public int Vida { get => vida; set => vida = value; }
        [Column("forca")]
        public int Forca { get => forca; set => forca = value; }

        [Column("presenca")]
        public int Presenca { get => presenca; set => presenca = value; }

        [Column("vigor")]
        public int Vigor { get => vigor; set => vigor = value; }

        [Column("intelecto")]
        public int Intelecto { get => intelecto; set => intelecto = value; }

        [Column("defesa_buff")]
        public int Defesa_buff { get => defesa_buff; set => defesa_buff = value; }

        [Column("agilidade")]
        public int Agilidade { get => agilidade; set => agilidade = value; }
        [Column("forca_buff")]
        public int Forca_buff { get => forca_buff; set => forca_buff = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("origem")]
        public string Origem { get => origem; set => origem = value; }
        [Column("habilidade_1")]
        public int Habilidade1 { get => habilidade1; set => habilidade1 = value; }
        [Column("habilidade_2")]
        public int Habilidade2 { get => habilidade2; set => habilidade2 = value; }
        [Column("habilidade_3")]
        public int Habilidade3 { get => habilidade3; set => habilidade3 = value; }
        [Column("habilidade_4")]
        public int Habilidade4 { get => habilidade4; set => habilidade4 = value; }
        [Column("habilidade_5")]
        public int Habilidade5 { get => habilidade5; set => habilidade5 = value; }
        [Column("pontos_esforco")]
        public int PontosEsforco { get => pontosEsforco; set => pontosEsforco = value; }

    }
}
