using System;
using System.Runtime.CompilerServices;
using tpmod4_103022300062;

class Program {

    static void Main() {
        //SOAL 1
        //String input = Console.ReadLine();

        //Enum.TryParse(input, true, out KodePos.Kelurahan kelurahan);
        //{
        //    int kodePos1 = KodePos.GetKodePos(kelurahan);
        //    Console.WriteLine($"Kode Pos {kelurahan}: {kodePos1}");
        //}

        //SOAL 2
        DoorMachine door = new DoorMachine();
        door.currentState = DoorMachine.DoorState.terkunci;

        Console.WriteLine("Pintu " + door.currentState);
        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Pilihan Aksi: ");
            Console.WriteLine("1. Membuka Pintu");
            Console.WriteLine("2. Mengunci Pintu");
            Console.WriteLine("3. Keluar Program");
            Console.WriteLine("Pilih: ");
            String input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    door.activateTrigger(DoorMachine.Trigger.Membuka_Pintu);
                    Console.WriteLine("Pintu " + door.currentState);
                    break;

                case "2":
                    door.activateTrigger(DoorMachine.Trigger.Mengunci_Pintu);
                    Console.WriteLine("Pintu " + door.currentState);
                    break;

                case "3":
                    Console.WriteLine("Bye bye!");
                    return;
            }
        }
    }
}
