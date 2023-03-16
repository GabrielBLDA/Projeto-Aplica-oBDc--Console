using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.TagScreen
{
    internal class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de tags");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar Tags");
            Console.WriteLine("3 - Excluir tags");
            Console.WriteLine("4 - Atualizar tag");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
       
            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    DeleteTagScreen.Load();
                    break;
                case 4:
                    UpdateTagScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
