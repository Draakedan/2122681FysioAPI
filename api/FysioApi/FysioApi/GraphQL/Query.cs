using VerkisListDatabaseHandler.Models;
using FysioApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FysioApi.GraphQL
{
    public class Query
    {
        private readonly IDiagnoseService _diagnoseService;

        public Query(IDiagnoseService diagnoseService)
        {
            _diagnoseService = diagnoseService;
        }

        public IQueryable<Diagnose> Diagnoses => _diagnoseService.GetAll();

        public IQueryable<Diagnose> Some(int codeStart) => _diagnoseService.GetSome(codeStart);

        public Diagnose Get(int code) => _diagnoseService.getOne(code);
    }
}
