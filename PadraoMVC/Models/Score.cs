using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PadraoMVC.Models
{
    public class Score
    {
        public int Id { get; set; }

        public string Avatar { get; set; }

        [Required(ErrorMessage = "Nome do jogador é obrigatório")]
        [Display(Name = "Nome Jogador")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Pontuação é obrigatória")]
        [Range(1, 999999, ErrorMessage = "Pontuação deve estar entre 1 e 999.999")]
        public int Points { get; set; }
        
        public Score(int id, string avatar, string playerName, int points)
        {
            Id = id;
            Avatar = avatar;
            PlayerName = playerName;
            Points = points;
        }
        public Score()
        {

        }
    }
}