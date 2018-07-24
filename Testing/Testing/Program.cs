using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            if(x == 10)
            {
                File.Delete("D:\\new_file.txt");
            }
            
        }
    }
}
