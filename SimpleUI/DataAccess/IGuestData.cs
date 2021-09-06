using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using SimpleUI.Models;

namespace SimpleUI.DataAccess
{
    public interface IGuestData
    {
        [Get(path:"/Guests")]
        Task<List<GuestModel>> GetGuests();

        [Get(path:"/Guests/{id}")]
        Task<GuestModel> GetGuest(int id);

        [Post(path:"/Guests")]
        Task CreateGuest([Body] GuestModel guest);

        [Put(path: "/Guests/{id}")]
        Task UpdateGuest(int id, [Body] GuestModel guest);

        [Delete(path:"/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
