namespace DesafioProjeto1.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, string? Weapon, bool Shield)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
            this.Shield = true;
        }

        public override string Attack() {
            return this.Name + " has attacked with magic";
        }

        public override string Attack(int bonus){
            if (bonus > 6){
                return this.Name + " has attacked with a super magic +" + bonus + " bonus";
            } else {
                return this.Name + " has attacked with a weak magic +" + bonus + " bonus";
            }
        }

        public virtual string Defense(){
            return this.Name + " defended with a shield";
        }
    }
}