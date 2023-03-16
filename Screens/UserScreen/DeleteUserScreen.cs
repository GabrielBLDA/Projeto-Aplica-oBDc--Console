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
    internal class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir um usuario");
            Console.WriteLine("-------------");

            Console.Write("Qual o Id do usuario que deseja excluir?: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(DataBase.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuario excluido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi excluir este usuario");
                Console.WriteLine(e.Message);
            }
        }
    }
}
