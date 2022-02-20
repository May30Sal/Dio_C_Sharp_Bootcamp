namespace DesafioProjeto1.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, string Weapon){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public override string Defense(int power){
            if (this.Level > 50) {
                return this.Name + " defended with a power of " + power;
            } else {
                return this.Name + " didn't defend from the attack";
            }
        }
    }
}