using System;
using tpmod4_103022300062;

class Program {

    static void Main() {
        String input = Console.ReadLine();

        Enum.TryParse(input, true, out KodePos.Kelurahan kelurahan);
        {
            int kodePos1 = KodePos.GetKodePos(kelurahan);
            Console.WriteLine($"Kode Pos {kelurahan}: {kodePos1}");
        }
    }
}
