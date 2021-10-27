using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
	    Console.WriteLine("Введите свое имя, а после фамилию")
	    string a = Console.ReadLine();
	    string b = Console.ReadLine();
	    Console.WriteLine("Вас зовут: " + a + b)
        }
    }
}
