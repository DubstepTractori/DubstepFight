using DubstepFight.Core.Model.Fight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BlackKnight : BaseHero
    {
        Random random = new Random();
        /// <summary>
        /// класс темного рыцаря
        /// </summary>
        /// 
        public BlackKnight() { Health = 150; Power = 20; Name = "Тёмный Рыцарь"; Passive = new Passive(0); Attack2CD = 2;
            Attack1ImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Attack_1_Var_1.jpg";
            Attack2ImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Attack_2.jpg";
            CharPoseIdleImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Pose.png";
            CharAttackAnimImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Pose_2.png";
            CharInfoTxtPath = @"..\..\Resources\BlackKnight\BlackKnightInfo.txt";
        }

        public override int Attack1()
        {
            if (Health <= 75 && Health > 50)
            {
                if (random.Next(0, 10) < 3)
                {
                    Health += 25;
                }
            }
            else if (Health <= 50 && Health > 25)
            {
                if (random.Next(0, 10) < 5)
                {
                    Health += 25;
                }
            }
            else if (Health <= 25)
            {
                if (random.Next(0, 10) < 7)
                {
                    Health += 25;
                }
            }
            Attack2CD -= 1;
            return Power;

        }

        public override int Attack2()
        {
            Attack2CD = 2;
            return Convert.ToInt32(Power * 1.3);
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= takenDamage;
            return takenDamage;
        }

        public override int PassiveProc()
        {
            if (Health <= 75)
            {
                Attack1ImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Attack_1_Var_2.jpg";
                return Convert.ToInt32(20 * 1.4);
            }
            else
            {
                Attack1ImgPath = @"..\..\Resources\BlackKnight\BlackKnight_Attack_1_Var_1.jpg";
                return 20;
            }
        }
    }
}
