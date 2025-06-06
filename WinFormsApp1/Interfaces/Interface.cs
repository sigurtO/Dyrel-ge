﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Interfaces
{


    /*
     Interfaces opdelt i flere interfaces for at gøre det mere overskueligt og nemmere at vedligeholde.
     Så et interface pr objekt
     */
    public interface IConsultationService
    {
        Task<DataTable> LoadConsultationDataAsync();
        //Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddConsultationAsync(int ownerId, int petId, int vetId, DateTime date, int price, string notes);
        Task DeleteConsultationAsync(int consultationId);
        Task UpdateConsultationAsync(ConsultationClass consultation, int consultationId);
    }

    public interface IVeterinarianService
    {

        Task<DataTable> LoadVetsAsync();
        Task AddVetAsync(VetClass vet);
        Task<VetClass> AuthenticateAsync(string username, string password);
    }

    public interface IVetinarianRelated
    {
        Task<DataTable> GetVeterinariansByPetAsync(int petId);
    }

    public interface IPetLoadComboBoxRelated //The specific methods for the pet class to load 
    {
        Task<DataTable> LoadVetsDataAsync();
        Task<DataTable> LoadOwnerDataAsync();
    }



    
    public interface ITreatmentService
    {
        Task<DataTable> LoadTreatmentDataAsync(); // delete these two since Iownerrelated does it already
       // Task<DataTable> GetVeterinariansByPetAsync(int petId);
        Task AddTreatmentAsync(int ownerId, int petDocId, int consultationId, int price, DateTime date, string notes, int petID);
        Task DeleteTreatmentAsync(int treatmentId); 
        Task UpdateTreatmentAsync(TreatmentClass treatment, int treatmentId);
        Task<DataTable> GetConsultationFromPetDataAsync(int petId);

    }


    public interface IOwnerRelated // multiple services will use this one interface
    {
        Task<DataTable> LoadOwnerDataAsync();
        Task<DataTable> GetPetsByOwnerAsync(int ownerId);

    }


    public interface IInvoiceService
    {
        Task<DataTable> LoadInvoiceAsync(); 
        Task<DataTable> GetConsultationFromPetDataAsync(int ownerId);
        Task<DataTable> GetTreatmentFromConsultationDataAsync(int consultationId);
        Task<DataTable> CheckCageFromTreatmentDataAsync(int treatmentId);

        Task<DataTable> AddInvoiceAsync(int? treatmentID, int ownerID, int? consultationID, int petID, int? itemID, int? cageID, DateTime date, decimal? discount, decimal totalAmount, decimal netAmount);

        Task<DataTable> GetAllItemsDataAsync();
        Task<int> CalculateTotalAmount(int consultationId, int treatmentId, int cageId, int itemId, int currentTotal);

    }


    public interface IOwnerService
    {
        Task AddOwnerAsync(OwnerClass owner);
        Task UpdateOwnerAsync(OwnerClass owner, int ownerId);
        Task<DataTable> LoadOwnerDataAsync();
        Task AddOwnerAsyncEFC(OwnerClass owner);
    }



    public interface IPetService 
    {   
            Task<DataTable> LoadPetDataAsync();
            Task AddPetAsync(PetClass pet);
    }

    public interface IitemService
    {
        Task<DataTable> LoadItemDataAsync();
        void ExportToTextFile(DataGridView dataGridView, string filePath);
    }

    public interface IPetRelated
    {

    }

}
