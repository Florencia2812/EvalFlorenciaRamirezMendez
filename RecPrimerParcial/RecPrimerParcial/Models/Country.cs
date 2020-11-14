using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecPrimerParcial.Models
{
    public class Country
    {
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Capital { get; set; }

        [Required]
        public int Population { get; set; }

        [Required]
        public List<int> LatLng { get; set; }

        [Required]
        public List<string> Timezones { get; set; }

        public class Currencies
        {
            [Required]
            public string Code { get; set; }

            [Required]
            public string NameCurrencies { get; set; }

            [Required]
            public string Symbol { get; set; }
        }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Flag { get; set; }

    }
}