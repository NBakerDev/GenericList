using System; 
using System.Collections.Generic;
namespace GenericList {
    class Program {
        static void Main(string[] args) {
            var RandomInts = new List<int>();
            RandomInts.Add(5930);
            RandomInts.Add(7643);
            RandomInts.Add(6168);
            RandomInts.Add(9491);
            RandomInts.Add(5296);
            RandomInts.Add(6762);
            RandomInts.Add(7554);
            RandomInts.Add(1751);
            RandomInts.Add(9037);
            RandomInts.Add(8939);
            RandomInts.Add(9206);
            RandomInts.Add(2021);

          
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var nbr in RandomInts) {
                if(nbr < min) { min = nbr; }
                if(nbr > max){ max = nbr; }

               
                
            }
            Console.WriteLine($"Min is {min} Max is {max}");
        }
    }
}
