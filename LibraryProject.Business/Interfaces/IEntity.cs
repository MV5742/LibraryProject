using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Business.Interfaces
{
    //The interface that defines an Id property for all entities. Is also used to increase abstraction
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
