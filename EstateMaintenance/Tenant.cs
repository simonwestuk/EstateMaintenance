namespace EstateMaintenance
{
    public class Tenant : IPerson
    {
        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public Tenant(string fname, string sname)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
        }
    }

}
