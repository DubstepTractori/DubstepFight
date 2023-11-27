using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightConsoleTest
{
    internal class MainTest
    {
        static void Main(string[] args)
        {
            BlackKnight MyBlackKnight = new BlackKnight();

            Console.WriteLine("Удар наносит " + MyBlackKnight.Attack1() + " урона");

            Console.ReadLine();
        }
    }
}
