using GameAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.Data
{
    public interface IRepository
    {
        Task<IEnumerable<score>> GetScoreAsync();
    }
}
