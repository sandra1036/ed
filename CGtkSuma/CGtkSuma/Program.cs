using System;
using Gtk;

namespace CGtkSuma
{
    class Calculadora
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();


        }
    }
}
