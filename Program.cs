using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreen;
using Blog.Screens.UserScreen;
using Dapper.Contrib.Extensions; //essencial FRAMEWORK
using Microsoft.Data.SqlClient; //essencial FRAMEWORK

namespace Blog
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True"; //varival que contem os dados do banco de dados que desejo conectar
        static void Main(string[] args)
        {
            DataBase.Connection = new SqlConnection(CONNECTION_STRING);
            DataBase.Connection.Open();

            Load();

            Console.ReadKey();
            MenuTagScreen.Load();
            
        }
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuario");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - relatórios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);
            
            switch (option)
                {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }  
    }
}