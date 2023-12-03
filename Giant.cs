using System.Windows.Forms;

namespace DubstepFight
{
    public class Giant : Races
    {



        public Giant()
        {
            Health = 200;
            Armor = 20;
            Speed = 10;
        }

        public double Attack()
        {
            return (Health * 0.01) + 8;
        }


    }
}
