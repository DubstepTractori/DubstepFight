using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public abstract class BaseHero
    {
        private int health;
        private int power;
        private string name;
        private Passive passive;
        private string attack1ImgPath;
        private string attack2ImgPath;
        private string charPoseIdleImgPath;
        private string charInfoTxtPath;
        int attack2CD;

        /// <summary>
        /// базовый класс героя
        /// </summary>
        public BaseHero() { Health = 0; Power = 0; Name = "NoName"; Passive = new Passive(0); Attack2CD = 0; }

        public abstract int Attack1();
        public abstract int Attack2();

        public abstract int TakeDamage(int takenDamage);

        public abstract int PassiveProc();

        public string Attack1ImgPath { get => attack1ImgPath; set => attack1ImgPath = value; }
        public string Attack2ImgPath { get => attack2ImgPath; set => attack2ImgPath = value; }
        public string CharPoseIdleImgPath { get => charPoseIdleImgPath; set => charPoseIdleImgPath = value; }
        public string CharInfoTxtPath { get => charInfoTxtPath; set => charInfoTxtPath = value; }
        public int Attack2CD { get => attack2CD; set => attack2CD = value; }
        public int Health { get => health; set => health = value; }
        public int Power { get => power; set => power = value; }
        public string Name { get => name; set => name = value; }
        public Passive Passive { get => passive; set => passive = value; }
    }


}
