using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
	    Console.Clear();
            Massive3D mas = new Massive3D();
            Console.Write("Введите количество cтолбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите количество измерений: ");
            int z = int.Parse(Console.ReadLine());
            mas.array3d = new int[x, y, z];
            mas.X = x;
            mas.Y = y;
            mas.Z = z;
            Console.WriteLine("Заполните измерения");
            Console.WriteLine();
            mas.Array3d();

            mas.Srednee();
           Console.ReadLine();
        }

    }

}
