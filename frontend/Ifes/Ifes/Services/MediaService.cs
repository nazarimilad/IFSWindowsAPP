using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class MediaService
    {
        private static readonly Lazy<MediaService> lazy = new Lazy<MediaService>(() => new MediaService());

        public static MediaService Instance { get { return lazy.Value; } }

        private MediaService()
        {
        }
    }
}
