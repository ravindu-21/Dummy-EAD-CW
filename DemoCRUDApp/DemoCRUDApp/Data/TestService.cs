using DemoCRUDApp.Interfaces;
using DemoCRUDApp.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DemoCRUDApp.Data
{
    public class TestService:ITestService
    {
        private readonly IDapperService _dapperService;
        public TestService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        public Task<List<Test>> GetTestList()
        {
         var companies = Task.FromResult(_dapperService.GetAll<Test>($"SELECT * FROM [test_tb];", 
             null, commandType: CommandType.Text));
         return companies;
        }

        public Task<Test> GetTestItem(Int32 id)
        {
            var testItem = Task.FromResult(_dapperService.Get<Test>($"select * from [test_tb] where Id = {id}", 
               null,commandType: CommandType.Text));
            return testItem;
        }
    }
}
