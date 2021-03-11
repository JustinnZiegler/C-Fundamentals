using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenges
{
    [TestClass]
    public class Challenge1
    {
        [TestMethod]
        public void Step1()
        {
            string TheName = "Supercalifragilisticexpialidocious";
            foreach (char letter in TheName)
                {
                    Console.WriteLine(letter);
                }
        }

        [TestMethod]
        public void Step2()
        {
            string TheName = "Supercalifragilisticexpialidocious";
            foreach (char letter in TheName)
            {
                if (letter != 'i')
                    if (letter != 'l')
                {
                    Console.WriteLine("Not an I");
                }

                if (letter == 'i')
                {
                    Console.WriteLine("i");
                }

                if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
            }
        }

        [TestMethod]
        public void Bonus()
        {
            string TheName = "Supercalifragilisticexpialidocious";
            Console.WriteLine(TheName.Length);
        }
    }
}
