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
    internal class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuario");
            Console.WriteLine("-------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("PasswordHash: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Image: ");
            var Image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = Image,
                Slug = slug
            });
            Console.WriteLine("Cadastro realizado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(DataBase.Connection);
                repository.Create(user);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(e.Message);
            }
        }
    }
}
