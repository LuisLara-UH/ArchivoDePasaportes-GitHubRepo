﻿using ArchivoDePasaportes.Models.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArchivoDePasaportes.Models
{
    public class Person
    {
        public long Id { get; set; }

        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese el CI")]
        //[PersonIdValidation]
        [Display(Name = "Carnet de Identidad")]
        public string CI { get; set; }


        [Required(ErrorMessage ="Por favor ingrese Nombre")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellidos")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }


        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Por favor ingrese un Fecha de Nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime? BirthDay { get; set; }

        public int SourceId { get; set; }
        public Source Source { get; set; }

        public string Ocupation { get; set; }



        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public string NameWithComa()
        {
            return LastName + ", " + FirstName;
        }
    }
}
