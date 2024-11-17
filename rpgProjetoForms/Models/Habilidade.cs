using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{
    [Table("rpg_habilidade")]
    public class Habilidade
    {
        private int id;
        private string nome;
        private string tipo;
        //Habilidade Especificações
        private int dano;
        private int rounds_uso;
        private int custo;
        private byte[] imagem;
        private int fk_id_player;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("tipo")]
        public string Tipo { get => tipo; set => tipo = value;  }
        [Column("dano")]
        public int Dano { get => dano; set => dano = value; }
        [Column("rounds_uso")]
        public int Rounds_uso { get => rounds_uso; set => rounds_uso = value; }
        [Column("custo")]
        public int Custo { get => custo; set => custo = value; }
        [Column("imagem")]
        public byte[] Imagem { get => imagem; set => imagem = value; }
        [Column("fk_id_player")]
        public int FkIdPlayer { get => fk_id_player; set => fk_id_player = value; }
    }
}
