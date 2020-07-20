using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    // restrict movie manage operators to store manager
    public static class RoleName
    {
        public const string CanManageMovies = "CanManageMovies";
    }
}