using Series.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Series.Entities
{
    public class Serie : EntityBase
    {
        public string Title { get; private set; }
        private Gender Gender { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        public bool Excluded { get;private set; }

        public Serie(int pId,Gender pGender, string pTitle, string pDescription, int pYear)
        {
            Id = pId;
            Gender = pGender;
            Title = pTitle;
            Description = pDescription;
            Year = pYear;
            Excluded = false;
        }

        public void handleExcludeSerie() 
        {
            this.Excluded = !this.Excluded;
        }

        public string stringReturnHandler(string pString) 
        {
            pString += "Título: "+ this.Title + Environment.NewLine;
            pString += "Genero: " + this.Gender + Environment.NewLine;
            pString += "Descrição: " + this.Description + Environment.NewLine;
            pString += "Ano: " + this.Year + Environment.NewLine;

            if (this.Excluded) 
            {
                pString += "Série excluída";
            }

            return pString;
        }

        public override string ToString()
        {
            var lReturnString = "";
            return stringReturnHandler(lReturnString);
        }
    }
}
