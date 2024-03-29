﻿using ArchivoDePasaportes.Data;
using ArchivoDePasaportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchivoDePasaportes.Dto
{
    public static class TransferData
    {
        public static void Transfer(PassportDto origin, Passport destiny, ApplicationDbContext context)
        {
            destiny.PassportNo = origin.PassportNo;
            destiny.OwnerId = context.People.SingleOrDefault(per => per.CI == origin.OwnerCI).Id;
            destiny.PassportTypeId = origin.PassportTypeId;
            destiny.SourceId = origin.SourceId;
            destiny.ExpeditionDate = origin.ExpeditionDate;
            destiny.ExpirationDate = origin.ExpirationDate;
            destiny.IsPassportArchived = origin.IsPassportArchived;
        }
        public static void Transfer(Passport origin, PassportDto destiny, ApplicationDbContext context)
        {
            destiny.PassportNo = origin.PassportNo;
            destiny.OwnerCI = context.People.SingleOrDefault(per => per.Id == origin.OwnerId).CI;
            destiny.PassportTypeId = origin.PassportTypeId;
            destiny.SourceId = origin.SourceId;
            destiny.ExpeditionDate = origin.ExpeditionDate;
            destiny.ExpirationDate = origin.ExpirationDate;
            destiny.IsPassportArchived = origin.IsPassportArchived;
        }


        public static void Transfer(PersonDto origin, Person destiny, ApplicationDbContext context)
        {
            destiny.CI = origin.CI;
            destiny.FirstName = origin.FirstName;
            destiny.LastName = origin.LastName;
            destiny.Address = origin.Address;
            destiny.BirthDay = origin.BirthDay;
            destiny.Ocupation = origin.Ocupation;
            destiny.SourceId = origin.SourceId;
        }
        public static void Transfer(Person origin, PersonDto destiny, ApplicationDbContext context)
        {
            destiny.CI = origin.CI;
            destiny.FirstName = origin.FirstName;
            destiny.LastName = origin.LastName;
            destiny.Address = origin.Address;
            destiny.BirthDay = origin.BirthDay;
            destiny.Ocupation = origin.Ocupation;
            destiny.SourceId = origin.SourceId;
        }

        public static void Transfer(DroppedPassportDto origin, DroppedPassport destiny, ApplicationDbContext context)
        {
            destiny.PassportNo = origin.PassportNo;
            destiny.OwnerId = context.People.SingleOrDefault(per => per.CI == origin.OwnerCI).Id;
            destiny.PassportTypeId = origin.PassportTypeId;
            destiny.SourceId = origin.SourceId;
            destiny.ExpeditionDate = origin.ExpeditionDate;
            destiny.ExpirationDate = origin.ExpirationDate;
            destiny.DropCauseId = origin.DropCauseId;
            destiny.Details = origin.Details;

        }
        public static void Transfer(DroppedPassport origin, DroppedPassportDto destiny, ApplicationDbContext context)
        {
            destiny.PassportNo = origin.PassportNo;
            destiny.OwnerCI = context.People.SingleOrDefault(per => per.Id == origin.OwnerId).CI;
            destiny.PassportTypeId = origin.PassportTypeId;
            destiny.SourceId = origin.SourceId;
            destiny.ExpeditionDate = origin.ExpeditionDate;
            destiny.ExpirationDate = origin.ExpirationDate;
            destiny.DropCauseId = origin.DropCauseId;
            destiny.Details = origin.Details;

        }
    
        
    }
}
