using System;

namespace ifes.lib.domain.Planes {
    public class Airport {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
    }
}