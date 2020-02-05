using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace StarChart.Models
{
    public class CelestialObjectcs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestialObjectcs> Satellites { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }
    }   
}
