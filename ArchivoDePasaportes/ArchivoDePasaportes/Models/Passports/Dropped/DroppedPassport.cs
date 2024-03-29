﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArchivoDePasaportes.Models
{
    public class DroppedPassport
    {
        public long Id { get; set; }

        [Display(Name = "Número de Pasaporte")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese el Número del Pasaporte")]
        public string PassportNo { get; set; }


        [Required(ErrorMessage = "Por favor ingrese el propietario del pasaporte")]
        [Display(Name = "Carnet de Identidad del Propietario")]
        public long OwnerId { get; set; }
        public Person Owner { get; set; }


        [Required(ErrorMessage = "Por favor seleccione el tipo de este pasaporte")]
        public byte PassportTypeId { get; set; }
        [Display(Name = "Tipo de Pasaporte")]
        public PassportType PassportType { get; set; }


        public int? SourceId { get; set; }
        [Display(Name = "Centro Tramitador")]
        public Source Source { get; set; }


        [Required(ErrorMessage = "Por favor ingrese una Fecha de Expedición")]
        [Display(Name = "Fecha de Expedición")]
        [DataType(DataType.Date)]
        public DateTime? ExpeditionDate { get; set; }


        [Required(ErrorMessage = "Por favor ingrese una Fecha de Vencimiento")]
        [Display(Name = "Fecha de Vencimiento")]
        [DataType(DataType.Date)]
        public DateTime? ExpirationDate { get; set; }


        [Required(ErrorMessage = "Por favor seleccione una Causa de Deshecho")]
        public byte DropCauseId { get; set; }
        [Display(Name = "Causa de Deshecho")]
        public DropCause DropCause { get; set; }


        [Display(Name = "Detalles")]
        public string Details { get; set; }
    }
}
