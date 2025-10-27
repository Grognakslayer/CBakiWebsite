The goal of this website is to give helpful tools while explaing some of the more complex topics in the game in a way that people understand. The main issue that I have found with the game as it stands is that many things do not work as they are stated and are bugged so explaining how they are bugged and why will hopefully help new players. The other reson that I want to make this website is because It would be fun to make.
Week	Concept				Feature						Goal									Acceptance Criteria											Evidence in README.md						Test Plan	
10	Modeling			Create a player and styles entities		App can store styles and assigen them to the player			-player table created -styles table created -Relationship works						Implemented code; README write-up; screenshots as needed	Run migration; check DB tables exist
11	Separation of Concerns / DI	Add IStatMult to calculate how stat effect dmg	Move logic out of controller into a service.				-Service registered in DI -Controller uses constructor injection -Dmg mult returned correctly		Implemented code; README write-up; screenshots as needed	Call endpoint; verify ripe/rotten labels
12	CRUD				Add Create/Edit forms for Styles		Users can add or edit Styles.						-Form displays -Validation messages show -Changes save to DB						Implemented code; README write-up; screenshots as needed	Add new style, edit it, confirm DB update
13	Diagnostics			Add /healthz endpoint				App reports if Styles DB is reachable.					-Healthy when DB up -Unhealthy when DB down								Implemented code; README write-up; screenshots as needed	Stop DB and hit /healthz
14	Logging				Log every style added to make sure its correct	Record structured logs when people add styles.				-Log message created -Contains Style ID									Implemented code; README write-up; screenshots as needed	Add Style; check log output
15	Stored Procedures		Call SP: Styles with lowest stat total		Show leaderboard of styles with the most freedom.			-SP executes -Results displayed										Implemented code; README write-up; screenshots as needed	Run SP in app and DB; compare results
16	Deployment			Deploy app to Azure App Service			Make the application accessible in the cloud with production settings.	-App Service created -App builds and runs on Azure -/healthz reachable -One functional path works	Implemented code; README write-up; deployed URL; screenshots	Visit public URL; confirm health endpoint and one page load


10	Modeling			Both the player and style models have been made	The App can store styles and assigen them to the player			-player table created -styles table created -Relationship works						using System.ComponentModel.DataAnnotations;
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


namespace CBakiWebsite.Models
{



    public class Move
    {
        public int Id { get; set; }
        public float Damage { get; set; }
        public int CD { get; set; }
        public string MoveName { get; set; } = "Place Holdername";
        public string Description { get; set; } = "Description Not set yet add if you want";

        public Move() { }
        public Move(int id,float damage, string moveName, int cd, string description)
        {
            Id = id;
            Damage = damage;
            MoveName = moveName;
            CD = cd;
            Description = description;
        }
    }




    public class Style
    {
        public int Id { get; set; }

        public string StyleName { get; set; } = "PlaceHolder Name";
        public int MinStrength { get; set; }
        public int MinDurability { get; set; }
        public int MinAgility { get; set; }
        public int MinIntellect { get; set; }

        public Move? ZMove1 { get; set; }
        public Move? ZMove2 { get; set; }
        public Move? ZMove3 { get; set; }
        public Move? ZMove4 { get; set; }
        public Move? ZMove5 { get; set; }
        public Move? XMove1 { get; set; }
        public Move? XMove2 { get; set; }
        public Move? XMove3 { get; set; }
        public Move? XMove4 { get; set; }
        public Move? XMove5 { get; set; }
        public Move? CMove1 { get; set; }
        public Move? CMove2 { get; set; }
        public Move? CMove3 { get; set; }
        public Move? CMove4 { get; set; }
        public Move? CMove5 { get; set; }
        public Move? VMove1 { get; set; }
        public Move? VMove2 { get; set; }
        public Move? VMove3 { get; set; }
        public Move? VMove4 { get; set; }
        public Move? VMove5 { get; set; }
        public Move? BMove1 { get; set; }
        public Move? BMove2 { get; set; }
        public Move? BMove3 { get; set; }
        public Move? BMove4 { get; set; }
        public Move? BMove5 { get; set; }
        public Move? MiscMove1 { get; set; }
        public Move? MiscMove2 { get; set; }
        public Move? MiscMove3 { get; set; }
        public Move? MiscMove4 { get; set; }
        public Move? MiscMove5 { get; set; }



        public Style() { }

        
        public Style(int id,string stylename, int minstrength, int mindurability, int minagility, int minintellect,Move zmove1, Move zmove2, Move zmove3, Move zmove4, Move zmove5,Move xmove1, Move xmove2, Move xmove3, Move xmove4, Move xmove5,Move cmove1, Move cmove2, Move cmove3, Move cmove4, Move cmove5,Move vmove1, Move vmove2, Move vmove3, Move vmove4, Move vmove5,Move bmove1, Move bmove2, Move bmove3, Move bmove4, Move bmove5,Move miscmove1, Move miscmove2, Move miscmove3, Move miscmove4, Move miscmove5)
        {
            Id = id;
            StyleName = stylename;
            MinStrength = minstrength;
            MinDurability = mindurability;
            MinAgility = minagility;
            MinIntellect = minintellect;

            ZMove1 = zmove1;
            ZMove2 = zmove2;
            ZMove3 = zmove3;
            ZMove4 = zmove4;
            ZMove5 = zmove5;

            XMove1 = xmove1;
            XMove2 = xmove2;
            XMove3 = xmove3;
            XMove4 = xmove4;
            XMove5 = xmove5;

            CMove1 = cmove1;
            CMove2 = cmove2;
            CMove3 = cmove3;
            CMove4 = cmove4;
            CMove5 = cmove5;

            VMove1 = vmove1;
            VMove2 = vmove2;
            VMove3 = vmove3;
            VMove4 = vmove4;
            VMove5 = vmove5;

            BMove1 = bmove1;
            BMove2 = bmove2;
            BMove3 = bmove3;
            BMove4 = bmove4;
            BMove5 = bmove5;

            MiscMove1 = miscmove1;
            MiscMove2 = miscmove2;
            MiscMove3 = miscmove3;
            MiscMove4 = miscmove4;
            MiscMove5 = miscmove5;
        }
    }

}
The models for now only make 3 classes that refernce eachother and have most of what will be needed in the future to make that information be useful with the calculations that will be added next week and some backbone for future ui developments



	Run migration; check DB tables exist Yup they exist