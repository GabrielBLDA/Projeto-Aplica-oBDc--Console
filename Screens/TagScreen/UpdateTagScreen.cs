using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreen
{
    internal class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Atualizando uma tag");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag Atualizada com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi Atualizar a tag");
                Console.WriteLine(e.Message);
            }
        }

    }
}
