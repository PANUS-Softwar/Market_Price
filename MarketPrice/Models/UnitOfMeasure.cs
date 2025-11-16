using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPrice.Models
{
    internal class UnitOfMeasure
    {
        public Guid UnitOfMeasureId { get; set; }
        public required string UnitOfMeasureNameEnglish { get; set; }
        public required string UnitOfMeasureNameFrench { get; set; }
        public required string UnitOfMeasureCodeEnglish { get; set; }
        public required string UnitOfMeasureCodeFrench { get; set; }
    }

}
