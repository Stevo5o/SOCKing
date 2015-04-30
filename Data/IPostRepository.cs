using SOCKing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCKing.Data
{
    public interface IPostRepository
    {
        Post Get(string id);
    }
}
