using VerkisListDatabaseHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FysioApi.Services.DiagnoseService;

namespace FysioApi.Services
{
    public interface IDiagnoseService
    {
        IQueryable<Diagnose> GetAll();
        IQueryable<Diagnose> GetSome(int codeStart);
        Diagnose getOne(int code);
    }
}
