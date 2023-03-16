using Blog.Screens.TagScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreen
{
    internal class MenuUserScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuario");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuarios");
            Console.WriteLine("2 - Cadastrar Usuarios");
            Console.WriteLine("3 - Excluir Usuario");
            Console.WriteLine("4 - Atualizar Usuario");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    DeleteUserScreen.Load();
                    break;
                case 4:
                    UpdateUserScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
