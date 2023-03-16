using Blog.Models;
using Blog.Repositories;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreen
{
    internal class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Create(tag);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(e.Message);
            }        
        }
    }
}
