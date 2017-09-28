using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class ImageDto : BaseDto
    {
        public Guid IDBlog { get; set; }
        public string LinkImage { get; set; }

        public virtual BlogDto Blog { get; set; }
    }
}
