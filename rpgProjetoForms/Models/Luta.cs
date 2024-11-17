using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{
    [Table("luta")]
    public class Luta
    {
        private int id;
        private string vencedor;
        private int rounds;
        private int fk_desafiante_id;
        private int fk_desafiado_id;
        private string status;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("vencedor")]
        public string Vencedor { get => vencedor; set => vencedor = value; }

        [Column("rounds")]
        public int Rounds { get => rounds; set => rounds = value; }

        [Column("fk_rpg_desafiante_id")]
        public int Fk_desafiante_id { get => fk_desafiante_id; set => fk_desafiante_id = value; }

        [Column("fk_rpg_desafiado_id")]
        public int Fk_desafiado_id { get => fk_desafiado_id; set => fk_desafiado_id = value; }

        [Column("status")]
        public string Status { get => status; set => status = value; }

    }
}
