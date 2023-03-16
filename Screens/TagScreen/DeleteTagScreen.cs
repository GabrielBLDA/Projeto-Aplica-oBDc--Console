using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreen
{
    internal class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir uma tag");
            Console.WriteLine("-------------");

            Console.Write("Qual o Id da Tag que deseja excluir?: ");
            var id = Console.ReadLine();
 
            Delete(int.Parse(id));
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluida com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi excluir a tag");
                Console.WriteLine(e.Message);
            }
        }
    }
}
