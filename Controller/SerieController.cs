using Series.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Series.Controller.Interfaces;
using Series.Entities;
using Series;

namespace Series.Controller
{
    public class SerieController : IBaseController<Serie>
    {
        private SerieRepository lRepository { get; set; }

        public SerieController()
        {
            this.lRepository = new SerieRepository();
        }

        public void List()
        {
            var lItens = lRepository.List();


            for(var i = 0; i < lItens.Count; i++) 
            {
                if (!lItens[i].Excluded) 
                {
                    Console.WriteLine();
                    Console.WriteLine(lItens[i].Id + 1 + " - " + lItens[i].Title);
                }
                
            }

        }

        public void Insert()
        {
            var newSerie = Utility.newSerieHandler(lRepository);

            lRepository.Insert(newSerie);
        }

        public void Update()
        {
            var lId = Utility.idHandler();

            var editedSerie = Utility.newSerieHandler(lRepository, lId);

            lRepository.Update(lId, editedSerie);
        }

        public void Delete()
        {
            var lId = Utility.idHandler();

            lRepository.Delete(lId);
        }

        public void ReturnById()
        {
            var lId = Utility.idHandler();

            var lSerie = lRepository.ReturnById(lId);

            Console.WriteLine(lSerie.ToString());
            Console.WriteLine();
        }

        public void Clean()
        {
            Console.Clear();
        }
    }
}
