using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcGame.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public int Strength { get; set; }
        public int Durability { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }

        
        public int? StyleId { get; set; }
        public CBakiWebsite.Models.Style? Style { get; set; }

        
        public Player() { }

        public Player(int id, string name, int strength, int durability, int agility, int intellect, CBakiWebsite.Models.Style? style = null)
        {
            Id = id;
            Name = name;
            Strength = strength;
            Durability = durability;
            Agility = agility;
            Intellect = intellect;
            Style = style;
        }

        
        public bool MeetsStyleRequirements()
        {
            if (Style == null)
                return false;

            return Strength >= Style.MinStrength &&
                   Durability >= Style.MinDurability &&
                   Agility >= Style.MinAgility &&
                   Intellect >= Style.MinIntellect;
        }
    }
}
