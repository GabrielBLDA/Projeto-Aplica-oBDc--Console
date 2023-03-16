using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreen
{
    internal class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuarios");
            Console.WriteLine("-------------");
            List();
            Console.WriteLine();
            Console.WriteLine("Pressione qualque tecla para continuar");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(DataBase.Connection);
            var users = repository.Get();
            foreach (var user in users)
                Console.WriteLine($"{user.Id} - {user.Name} - ({user.Bio})");
        }
    }
}
