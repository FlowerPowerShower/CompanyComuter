﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyComuter1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CompanyComuterEntities1 : DbContext
    {
        public CompanyComuterEntities1()
            : base("name=CompanyComuterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmissionLog> EmissionLogs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    
        public virtual ObjectResult<Employee> DeleteEmployee(string ssn)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("DeleteEmployee", ssnParameter);
        }
    
        public virtual ObjectResult<Employee> DeleteEmployee(string ssn, MergeOption mergeOption)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("DeleteEmployee", mergeOption, ssnParameter);
        }
    
        public virtual int DeleteLogEntry(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteLogEntry", idParameter);
        }
    
        public virtual int ErrorHandling()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ErrorHandling");
        }
    
        public virtual ObjectResult<Employee> GetAllEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetAllEmployees");
        }
    
        public virtual ObjectResult<Employee> GetAllEmployees(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("GetAllEmployees", mergeOption);
        }
    
        public virtual ObjectResult<EmissionLog> GetAllLogs()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmissionLog>("GetAllLogs");
        }
    
        public virtual ObjectResult<EmissionLog> GetAllLogs(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmissionLog>("GetAllLogs", mergeOption);
        }
    
        public virtual int GetCo2ForVehicle(string vType, ObjectParameter co2)
        {
            var vTypeParameter = vType != null ?
                new ObjectParameter("vType", vType) :
                new ObjectParameter("vType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCo2ForVehicle", vTypeParameter, co2);
        }
    
        public virtual int GetCurrentId(ObjectParameter oldId)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCurrentId", oldId);
        }
    
        public virtual int InsertEmployee(string ssn, string firstName, string lastName)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertEmployee", ssnParameter, firstNameParameter, lastNameParameter);
        }
    
        public virtual int InsertLog(string ssn, string vType, Nullable<decimal> distance)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            var vTypeParameter = vType != null ?
                new ObjectParameter("vType", vType) :
                new ObjectParameter("vType", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertLog", ssnParameter, vTypeParameter, distanceParameter);
        }
    
        public virtual ObjectResult<Top5Employees_Result> Top5Employees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Top5Employees_Result>("Top5Employees");
        }
    
        public virtual int UpdateEmployee(string ssn, string firstName, string lastName)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployee", ssnParameter, firstNameParameter, lastNameParameter);
        }
    
        public virtual int UpdateLog(Nullable<int> id, string vType, Nullable<decimal> distance)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var vTypeParameter = vType != null ?
                new ObjectParameter("vType", vType) :
                new ObjectParameter("vType", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLog", idParameter, vTypeParameter, distanceParameter);
        }
    
        public virtual ObjectResult<Employee> FindEmployeeBySsn(string ssn)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FindEmployeeBySsn", ssnParameter);
        }
    
        public virtual ObjectResult<Employee> FindEmployeeBySsn(string ssn, MergeOption mergeOption)
        {
            var ssnParameter = ssn != null ?
                new ObjectParameter("ssn", ssn) :
                new ObjectParameter("ssn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee>("FindEmployeeBySsn", mergeOption, ssnParameter);
        }
    
        public virtual ObjectResult<EmissionLog> FindLog(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmissionLog>("FindLog", idParameter);
        }
    
        public virtual ObjectResult<EmissionLog> FindLog(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmissionLog>("FindLog", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<TopPerformers_Result> TopPerformers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TopPerformers_Result>("TopPerformers");
        }
    }
}
