using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Web.Models
{
    public class RoleViewModel
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; }

        public IList<SelectListItem> Drp_RoleNames { get; set; }
    }
}