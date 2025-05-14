using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DB.DbCreate;
using WinFormsApp1.DB.DbDelete;
using WinFormsApp1.DB.DbRead;

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
        public DbReadPet DbReadPet { get; } 


        //Create
        public DbCreateConsultation DbCreateConsultation { get; }
        public DbCreateOwner DbCreateOwner { get; }
        public DbCreateVet DbCreateVet { get; }
        public DbCreateInvoice DbCreateInvoice { get; }

        public DbCreatePet DbCreatePet { get; }   

        //Delete
        public DbDeleteConsultation DbDeleteConsultation { get; }

        //Update

        public DbService(string connectionString)
        {
            //Read
            DbReadConsultation = new DbReadConsultation(connectionString);
            DbReadOwner = new DbReadOwner(connectionString);
            DbReadVet = new DbReadVet(connectionString);
            DbReadLogin = new DbReadLogin(connectionString);
            DbReadInvoice = new DbReadInvoice(connectionString);
            DbReadPet = new DbReadPet(connectionString);   
            
            //Create
            DbCreateConsultation = new DbCreateConsultation(connectionString);
            DbCreateOwner = new DbCreateOwner(connectionString);
            DbCreateVet = new DbCreateVet(connectionString);
            DbCreateInvoice = new DbCreateInvoice(connectionString);
            //Delete
            DbDeleteConsultation = new DbDeleteConsultation(connectionString);

            //Update (comming soon)

        }
    }
}
