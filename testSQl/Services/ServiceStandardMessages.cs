using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace testSQl.Services
{
    public static class ServiceStandardMessages 
    {
        public static void HelloMessages()
        {
            Console.WriteLine("Введите артикул стеклопакета:");
        }
        public static void ResponseMessages(int chamberness, int thicknessSP,int glassThickness)
        {
            Console.WriteLine($" Камерность: {chamberness},\n Толщина СП: {thicknessSP},\n Толщина стекла: {glassThickness}.");
        }
    }
}
