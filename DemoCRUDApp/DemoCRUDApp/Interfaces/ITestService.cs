using DemoCRUDApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCRUDApp.Interfaces
{
    public interface ITestService
    {
        Task<List<Test>> GetTestList();
        Task<Test>GetTestItem(Int32 id);
    }
}
