using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Web;

namespace Vidly.Dtos
{
    public class GenreDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }
}