using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {

            HashSet<string> ShowRoom = new HashSet<string> ();

            ShowRoom.Add("Taurus");
            ShowRoom.Add("Camry");
            ShowRoom.Add("Accord");
            ShowRoom.Add("Focus");

            ShowRoom.Add("Taurus");

            HashSet<string> UsedLot = new HashSet<string> ();

            UsedLot.Add("Corolla");
            UsedLot.Add("Mustang");

            ShowRoom.UnionWith(UsedLot);

            ShowRoom.Remove("Taurus");

            foreach (string vehicle in ShowRoom) {
                Console.WriteLine ($"{vehicle}");
            }
        }
    }
}