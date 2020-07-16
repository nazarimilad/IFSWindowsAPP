using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class PassengersService
    {
        private static readonly Lazy<PassengersService> lazy = new Lazy<PassengersService>(() => new PassengersService());

        public static PassengersService Instance { get { return lazy.Value; } }

        private PassengersService()
        {
        }
    }
}
