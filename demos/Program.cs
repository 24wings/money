using System;
using PInvoke;
using static PInvoke.User32;
namespace demos {
    class Program {
        static void Main (string[] args) {
            MessageBox (IntPtr.Zero, "hello", "heheeda", MessageBoxOptions.MB_DEFBUTTON1);
            Console.WriteLine ("Hello World!");
        }
    }
}