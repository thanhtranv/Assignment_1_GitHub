using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class ImageEntity : BaseEntity
    {
        public Guid IDBlog { get; set; }
        public string LinkImage { get; set; }

        public virtual BlogEntity Blog { get; set; }
    }
}
