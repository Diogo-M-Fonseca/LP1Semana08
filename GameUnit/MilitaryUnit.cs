
 
namespace GameUnit
    {
    public class MilitaryUnit : Unit 
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public override int Health {get => base.Health + XP;}

        public override float Cost {get {return AttackPower + XP;}}

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
        public override string ToString()
        {
            return $"MilitaryUnit: HP={Health} Cost={Cost:f2} AP={AttackPower} XP={XP}";
        }
    }
}
