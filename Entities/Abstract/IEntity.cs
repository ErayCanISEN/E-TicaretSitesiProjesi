using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    // Veri tabanında karşılık gelen tablolarda olacak
    public interface IEntity
    {
        int Id { get; set; }
    }
}
