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

        public IQueryable<Diagnose> diagnoses => _diagnoseService.GetAll();

        public IQueryable<Diagnose> some(int codeStart) => _diagnoseService.GetSome(codeStart);

        public Diagnose get(int code) => _diagnoseService.getOne(code);
    }
}
