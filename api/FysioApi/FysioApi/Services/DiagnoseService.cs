using VerkisListDatabaseHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VerkisListDatabaseHandler.Data;

namespace FysioApi.Services
{
    public class DiagnoseService : IDiagnoseService
    {
        private readonly VerkisContext _context;

        public DiagnoseService(VerkisContext verkisContext)
        {
            _context = verkisContext;
        }

        public IQueryable<Diagnose> GetAll()
        {
            return _context.Diagnoses.AsQueryable();
        }

        public IQueryable<Diagnose> GetSome(int codeStart)
        {
            List<Diagnose> diagnoses = new();
            int code = codeStart * 100;
            int codeEnd = code + 1000;
            foreach (Diagnose d in _context.Diagnoses)
            {
                if (d.Code > code && d.Code < codeEnd)
                    diagnoses.Add(d);
            }
            return diagnoses.AsQueryable();
            
        }

        public Diagnose getOne(int code)
        {
            foreach (Diagnose d in _context.Diagnoses)
                if (d.Code == code)
                    return d;
            return null;
        }

        public class DeleteVM
        {
            public int Id { get; set; }
        }

    }
}
