using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{

    [Table("rpg_player")]
    public class Player
    {
        private int id;
        private string nome;
        private int derrotas;
        private int vitorias;
        private int fk_personagem;
        private string email;
        private string senha;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }
        [Column("derrotas")]
        public int Derrotas { get => derrotas; set => derrotas = value; }
        [Column("vitorias")]
        public int Vitorias { get => vitorias; set => vitorias = value; }
        [Column("fk_rpg_personagem_id")]
        public int Fk_personagem_id { get => fk_personagem; set => fk_personagem = value; }
        [Column("email")]
        public string Email { get => email; set => email = value; }
        [Column("senha")]
        public string Senha { get => senha; set => senha = value; }


        public Player()
        {
            derrotas = 0;
            vitorias = 0;
            fk_personagem = 0;
        }
    }
}
