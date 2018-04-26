using DWARF.Core.Helper;

namespace DWARF.Domain.Model
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
    }
}
