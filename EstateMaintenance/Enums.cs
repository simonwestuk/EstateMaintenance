using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class Enums
    {
        public enum ResidentialType
        {
            [Display(Name = "Detached")]
            DETACHED,
            [Display(Name = "Semi Detached")]
            SEMI_DETACHED,
            [Display(Name = "Terraced")]
            TERRACED,
            [Display(Name = "Bungalow")]
            BUNGALOW,
            [Display(Name = "Cottage")]
            COTTAGE,
            [Display(Name = "Flat")]
            FLAT
        }
        public enum CommericalType
        {
           OFFICE,
           WAREHOUSE,
           FACTORY,
           INDUSTRIAL_UNIT,
           RETAIL
        }

        public enum IssueSeverity
        {
            HIGH,
            MEDIUM,
            LOW
        }

        public enum StaffType
        {
            ADMIN,
            MANAGER,
            TEAM_MEMBER
        }
    }
}
