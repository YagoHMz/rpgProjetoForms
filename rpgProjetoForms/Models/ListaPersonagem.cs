using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{
    [Table("rpg_lista_personagens")]
    public class ListaPersonagem
    {
        private int fk_rpg_player_id;
        private int fk_rpg_personagem_id;
        [Column("fk_rpg_player_id")]
        public int FkRpgPlayerId { get => fk_rpg_player_id; set => fk_rpg_player_id = value; }

        [Column("fk_rpg_personagem_id")]
        public int FkRpgPersonagemId { get => fk_rpg_personagem_id; set => fk_rpg_personagem_id = value; }

    }
}
