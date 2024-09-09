using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    interface inter
    {
        void method();

    }
    interface secondinter
    {
        void anothermethod();
    }
    class domo : inter,secondinter 
    {
        public void method()
        {
             Console.WriteLine("zzzzzzzzz");
        }
        public void anothermethod()
        {
              Console.WriteLine("aaaaaaaaaa");
        }
    }    
       
 }
