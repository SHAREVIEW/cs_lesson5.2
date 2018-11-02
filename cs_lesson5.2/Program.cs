using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson5._2
{
    class Program
    {
        enum orientation : byte   //定义枚举
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }
        struct route          //定义结构，路径
        {
            public orientation direction;    //结构的数据成员
            public double distance;
        }
        static void Main(string[] args)
        {
            route myRoute;         //定义的新类型变量可以使用上面的结构
            int myDirection = -1;
            double myDistance;
            Console.WriteLine("1) North\n2) South\n3) East\n4) West");
            do                                                                 //选择枚举的方向
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));             //有效范围是1-4
            Console.WriteLine("Input a distance:");
            myDistance = Convert.ToInt32(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine("myRoute specifies a direction of {0} and a "+
                "distance of {1}", myRoute.direction, myRoute.distance);
            Console.ReadKey();


        }
    }
}
