using Series.Controller;
using Series.Entities;
using Series.Entities.Enums;
using Series.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
namespace Series
{
    public static class Utility
    {
        public static string userOptions() 
        {
            Console.WriteLine();
            Console.WriteLine("CRUD com console em memória");
            Console.WriteLine("INforme a opção desejada");

            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Limpar");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string optionReader = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return optionReader;
        }

        public static void programController(string pOptionSelected, SerieController pController) 
        {
            switch (pOptionSelected) 
            {
                case "1":
                    pController.List();
                    break;
                case "2":
                    pController.Insert();
                    break;
                case "3":
                    pController.Update();
                    break;
                case "4":
                    pController.Delete();
                    break;
                case "5":
                    pController.ReturnById();
                    break;
                case "6":
                    pController.Clean();
                    break;
                default:
                    Console.WriteLine("COMANDO INVALIDO");
                    break;
            }
        }

        public static void programRunner(SerieController pController) 
        {
             var selectedOption = userOptions();

            while (selectedOption != "X")
            {
                programController(selectedOption, pController);

                selectedOption = userOptions();
            }
        }

        public static Serie newSerieHandler(SerieRepository pRepo, int pId = -1) 
        {
            if(pId == -1) 
            {
                pId = pRepo.NextId();
            }

            Console.WriteLine();
            Console.WriteLine("Digite o nome da série: ");
            string lTitle = Console.ReadLine();
            Console.WriteLine();
            var lGender = genderEnumHandler();
            Console.WriteLine();
            Console.WriteLine("Digite a descrição da série: ");
            var lDescription = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o ano em que a série saiu: ");
            var lYear = Console.ReadLine();

            var lReturnSerie = new Serie(pId, lGender, lTitle, lDescription, int.Parse(lYear));
            return lReturnSerie;
        }

        public static int idHandler() 
        {
            Console.WriteLine();
            Console.WriteLine("Digite o id da série: ");
            var lId = int.Parse(Console.ReadLine());
            return lId - 1;
        }
        private static Gender genderEnumHandler() 
        {
            var lGendersName = Enum.GetNames(typeof(Gender));

            Console.WriteLine("Selecione um genero");

            for(var i = 0; i < lGendersName.Length; i++) 
            {
                Console.WriteLine();
                Console.WriteLine(i+1 + " - " + lGendersName[i]);
            }
            Console.WriteLine();

            var selectedGender = Console.ReadLine();

            return (Gender)Enum.Parse(typeof(Gender), selectedGender);
        }
    }
}
