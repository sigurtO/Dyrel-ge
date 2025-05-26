using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.DB;
using WinFormsApp1.DB.DbCreate;
using WinFormsApp1.DB.DbDelete;
using WinFormsApp1.DB.DbRead;
using WinFormsApp1.DB.DbUpdate;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    //Os alle har pillet herinde frem og tilbage
    public class DbService
    {
        //Read
        public DbReadConsultation DbReadConsultation { get; }
        public DbReadOwner DbReadOwner { get; }
        public DbReadVet DbReadVet { get; }
        public DbReadLogin DbReadLogin { get; }
        public DbReadInvoice DbReadInvoice { get; }
        public DbReadPet DbReadPet { get; } 
        public DbReadItems DbReadItems { get; }


        public DbReadTreatment DbReadTreatment { get; }

        //Create
        public DbCreateConsultation DbCreateConsultation { get; }
        public DbCreateOwner DbCreateOwner { get; }
        public DbCreateVet DbCreateVet { get; }
        public DbCreateInvoice DbCreateInvoice { get; }
        public DbCreatePet DbCreatePet { get; }   
        public DbCreateTreatment DbCreateTreatment { get; }

        //Delete
        public DbDeleteConsultation DbDeleteConsultation { get; }
        public DbDeleteTreatment DbDeleteTreatment { get;}

        //Update

        public DbUpdateConsultation DbUpdateConsultation { get; }
        public DbUpdateTreatment DbUpdateTreatment { get; }
        public DbUpdateOwner DbUpdateOwner { get; }

        //Entity Frame Work (owner)
        public WinformDbContext DbContext { get; }

        public DbService(string connectionString)
        {
            //Read
            DbReadConsultation = new DbReadConsultation(connectionString);
            DbReadOwner = new DbReadOwner(connectionString);
            DbReadVet = new DbReadVet(connectionString);
            DbReadTreatment = new DbReadTreatment(connectionString);
            DbReadLogin = new DbReadLogin(connectionString);
            DbReadInvoice = new DbReadInvoice(connectionString);
            DbReadPet = new DbReadPet(connectionString);
            DbReadItems = new DbReadItems(connectionString);
            
            //Create
            DbCreateConsultation = new DbCreateConsultation(connectionString);
            DbCreateOwner = new DbCreateOwner(connectionString);
            DbCreateVet = new DbCreateVet(connectionString);
            DbCreateTreatment = new DbCreateTreatment(connectionString);
            DbCreateInvoice = new DbCreateInvoice(connectionString);
            DbCreatePet = new DbCreatePet(connectionString);
            //Delete
            DbDeleteConsultation = new DbDeleteConsultation(connectionString);
            DbDeleteTreatment = new DbDeleteTreatment(connectionString);

            //Update (comming soon)
            DbUpdateConsultation = new DbUpdateConsultation(connectionString);
            DbUpdateTreatment = new DbUpdateTreatment(connectionString);
            DbUpdateOwner = new DbUpdateOwner(connectionString);

            //Entity Frame Work (owner)
            DbContext = new WinformDbContext(connectionString);
        }

       
    }
}
