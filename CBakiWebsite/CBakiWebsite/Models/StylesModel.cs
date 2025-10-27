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
