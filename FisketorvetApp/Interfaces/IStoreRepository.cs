using FisketorvetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Domantas
namespace FisketorvetApp.Interfaces
{
    public interface IStoreRepository
    {
        public List<Store> AllStores();


        public List<Store> Filter_By_StartCriteria(string criteria);

        public Store GetStore(string name);
    }
}
