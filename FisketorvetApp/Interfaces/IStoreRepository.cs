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
        public List<AStore> AllStores();


        public List<AStore> Filter_By_StartCriteria(string criteria);

        public AStore GetStore(string name);
    }
}
