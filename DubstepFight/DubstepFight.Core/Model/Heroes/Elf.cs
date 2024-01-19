using DubstepFight;
using DubstepFight.Core.Model.Fight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Elf : BaseHero
    {
        /// <summary>
        /// класс эльфа
        /// </summary>
        public Elf() { Health = 125; Power = 20; Name = "Эльф"; Passive = new Passive(0); Attack2CD = 1;
            Attack1ImgPath = @"..\..\Resources\Elf\Elf_Attack_1.jpg";
            Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_1.jpg";
            CharPoseIdleImgPath = @"..\..\Resources\Elf\Elf_Pose.png";
            CharInfoTxtPath = @"..\..\Resources\Elf\ElfInfo.txt";
        }
        public override int Attack1()
        {
            Attack2CD -= 1;
            if(Passive.PassiveCounter1 < 6)
            {
                Passive.PassiveCounter1 += 1;
            }

            switch (Passive.PassiveCounter1)
            {
                case 2: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_2.jpg"; break;
                case 3: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_3.jpg"; break;
                case 4: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_4.jpg"; break;
                case 5: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_5.jpg"; break;
                case 6: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_6.jpg"; break;

                default: Attack2ImgPath = @"..\..\Resources\Elf\Elf_Attack_1.jpg"; break;
            }

            return Power;
        }

        public override int Attack2()
        {
            Attack2CD = 1;
            int damage = Convert.ToInt32(15 * Passive.PassiveCounter1);
            Passive.PassiveCounter1 = 0;
            return damage; 
        }

        public override int PassiveProc()
        {
            return 0;
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= takenDamage;
            return takenDamage;
        }

    }
}
