using Sharprompt;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    public static class CLI
    {
        static EstateMaintenceSystem es = new EstateMaintenceSystem("West Estates");

        static void Main(string[] args)
        {
            Console.Clear();

            var prop = Prompt.Select("What type of property do you wish to add?", new[] { "Residential", "Commercial" });



            _ = prop == "Residential" ? CreateResidential() : CreateCommercial();
            
        }

        static Residential CreateResidential()
        {
            var address = Prompt.Input<string>("Address");
            var type = Prompt.Select<ResidentialType>("Select enum value");
            var numOfBedrooms = Prompt.Input<int>("Number of bedrooms");

            var tenant = CreateTenant();

            Residential res = new Residential(address, type, numOfBedrooms, tenant);   
            es.Properties.Add(res);
            return res;

        }

        static Residential CreateCommercial()
        {

            return null;
        }


        static Tenant CreateTenant()
        {
            var fname = Prompt.Input<string>("Firstname");
            var sname = Prompt.Input<string>("Surname");
            return new Tenant(fname, sname);
        }
    }
}
