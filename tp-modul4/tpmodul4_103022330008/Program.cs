﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine(kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine(kodePos.GetKodePos("Mengger"));

        DoorMachine door = new DoorMachine();

        door.BukaPintu();
        door.BukaPintu();
        door.KunciPintu();
        door.KunciPintu();
    }
}

