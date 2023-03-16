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
    internal class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Atualizando um Usuario");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

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

            Update(new User
            {
                Id = int.Parse(id),
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = Image,
                Slug = slug
            });
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(DataBase.Connection);
                repository.Update(user);
                Console.WriteLine("Usuario Atualizado com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi Atualizar o Usuario");
                Console.WriteLine(e.Message);
            }
        }
    }
}
