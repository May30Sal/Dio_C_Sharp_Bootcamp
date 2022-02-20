namespace DesafioProjeto1.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public override string Attack() {
            return this.Name + " has attacked with a move";
        }

        public override string Defense(int power){
            if (power > 10) {
                return this.Name + " defended with a power of " + power;
            } else {
                return this.Name + " didn't defend from the attack";
            }
            
        }
    }
}