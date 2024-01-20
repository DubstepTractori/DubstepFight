using DubstepFight;
using DubstepFight.Core.Model.Fight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public  class Giant : BaseHero
    {
        /// <summary>
        /// класс гиганта
        /// </summary>
        public Giant() { Health = 200; Power = 15; Name = "Гигант"; Attack2CD = 2;
            Attack1ImgPath = @"..\..\Resources\Giant\Giant_attack_1.png";
            Attack2ImgPath = @"..\..\Resources\Giant\Giant_attack_2.png";
            CharPoseIdleImgPath = @"..\..\Resources\Giant\Gigant_Pose.png";
            CharAttackAnimImgPath = @"..\..\Resources\Giant\Gigant_Pose_2.png";
            CharInfoTxtPath = @"..\..\Resources\Giant\GiantInfo.txt";
        }
        public override int Attack1()
        {
            Attack2CD-=1;
            return Power;
        }

        public override int PassiveProc()
        {
            return 0; //нет особой пассивки
        }
        public override int Attack2()
        {
            Attack2CD = 2;
            return Convert.ToInt32(Power * 1.5);
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= Convert.ToInt32(takenDamage * 0.8);
            return Convert.ToInt32(takenDamage*0.8);   
        }
    }
}
