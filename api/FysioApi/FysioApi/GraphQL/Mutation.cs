using VerkisListDatabaseHandler.Models;
using FysioApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FysioApi.Services.DiagnoseService;

namespace FysioApi.GraphQL
{
    public class Mutation
    {
        private readonly IDiagnoseService _diagnoseService;

        public Mutation(IDiagnoseService diagnoseService)
        {
            _diagnoseService = diagnoseService;
        }
    }
}
