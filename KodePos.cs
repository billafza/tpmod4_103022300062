using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_103022300062
{
    class KodePos
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates,
            Cijarua, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja
        }

        public static int GetKodePos(Kelurahan kelurahan)
        {
            int[] kodePos = {40266, 40287, 40267, 40256, 40287,
            40286, 40286, 40286, 40272, 40274, 40273};

            return kodePos[(int)kelurahan];
        }
    }
}
