using System;
using System.Collections.Generic;

namespace Sandbox
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string namedFormatExample = "Named Format Example: [0x{location:X8}] {function}({type} bar)".Format(new Dictionary<string, object>()
                {
                    {"function", "Foo"},
                    {"type", "int"},
                    {"location", 110}
                });
            string standardFormatExample = "Standard Format Example: Hex: 0x{0:X8}".Format(110);
            string namedFormatExample2 = "http://{host}:{port}".Format(new Dictionary<string, object>() 
                                                                       {
                                                                           {"host", "127.0.0.1"}, 
                                                                           {"port", 80}
                });
            Console.WriteLine(standardFormatExample);
            Console.WriteLine(namedFormatExample);
            Console.WriteLine(namedFormatExample2);
        }
    }
}
