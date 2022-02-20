namespace DesafioProjeto1.src.entities
{
    public abstract class Hero
    {
        //criando o constructor
        public Hero(string? Name, int? Level, string? HeroType, string? Weapon, bool Shield) {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType;
           this.Weapon = Weapon;
       }

       public Hero(){

       }
              
        public string? Name; 

        public int? Level;

        public string? HeroType;

        public string? Weapon;

        public bool Shield;

        public override string ToString() {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Weapon + " shield? " + this.Shield;
        }

        public virtual string Attack() {
            return this.Name + " has attacked with a sword";
        }

        public virtual string Attack(int bonus){
            return this.Name + " has attacked with a +" + bonus + " bonus";
        }

        public virtual string Defense(int power){
            return this.Name + " defended with a power of " + power;
        }
    }
}