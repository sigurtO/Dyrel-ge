using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DB.DbCreate;
using WinFormsApp1.DB.DbDelete;
using WinFormsApp1.DB.DbRead;
using WinFormsApp1.DB.DbUpdate;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class DbService
    {
        //Read
        public DbReadConsultation DbReadConsultation { get; }
        public DbReadOwner DbReadOwner { get; }
        public DbReadVet DbReadVet { get; }
        public DbReadLogin DbReadLogin { get; }
        public DbReadInvoice DbReadInvoice { get; }




        public DbReadTreatment DbReadTreatment { get; }

        //Create
        public DbCreateConsultation DbCreateConsultation { get; }
        public DbCreateOwner DbCreateOwner { get; }
        public DbCreateVet DbCreateVet { get; }
        public DbCreateInvoice DbCreateInvoice { get; }


        public DbCreateTreatment DbCreateTreatment { get; }
        //Delete
        public DbDeleteConsultation DbDeleteConsultation { get; }
        public DbDeleteTreatment DbDeleteTreatment { get;}

        //Update

        public DbUpdateConsultation DbUpdateConsultation { get; }
        public DbUpdateTreatment DbUpdateTreatment { get; }
        public DbUpdateOwner DbUpdateOwner { get; }


        public DbService(string connectionString)
        {
            //Read
            DbReadConsultation = new DbReadConsultation(connectionString);
            DbReadOwner = new DbReadOwner(connectionString);
            DbReadVet = new DbReadVet(connectionString);
            DbReadTreatment = new DbReadTreatment(connectionString);
            DbReadLogin = new DbReadLogin(connectionString);
            DbReadInvoice = new DbReadInvoice(connectionString);
            //Create
            DbCreateConsultation = new DbCreateConsultation(connectionString);
            DbCreateOwner = new DbCreateOwner(connectionString);
            DbCreateVet = new DbCreateVet(connectionString);
            DbCreateTreatment = new DbCreateTreatment(connectionString);
            DbCreateInvoice = new DbCreateInvoice(connectionString);
            //Delete
            DbDeleteConsultation = new DbDeleteConsultation(connectionString);
            DbDeleteTreatment = new DbDeleteTreatment(connectionString);

            //Update (comming soon)
            DbUpdateConsultation = new DbUpdateConsultation(connectionString);
            DbUpdateTreatment = new DbUpdateTreatment(connectionString);
            DbUpdateOwner = new DbUpdateOwner(connectionString);
        }

       
    }
}
