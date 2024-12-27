using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Class1
    {
        public class GraduateSoldier : Soldier
        {
            public string Education { get; set; }

            public GraduateSoldier(string lastName, double height, double weight, string education)
                : base(lastName, height, weight)
            {
                Education = education;
            }

            public double CalculateQuality()
            {
                double baseQuality = base.CalculateQuality();

                if (Education == "высшее")
                {
                    return 2;
                }
                else
                {
                    return 0.5 * baseQuality;
                }
            }

            public new void DisplayInfo()
            {
                Console.WriteLine($"Graduate Soldier: {LastName}, Height: {Height}, Weight: {Weight}, Education: {Education}, Quality (Qp): {CalculateQuality()}");
            }
        }

    }
}
