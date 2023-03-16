using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreen
{
    internal class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.WriteLine();
            Console.WriteLine("Pressione qualque tecla para continuar");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.Get();
            foreach (var item in tags)           
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Slug})");
            
        }
    }
}
