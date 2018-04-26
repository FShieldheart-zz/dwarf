using System;

namespace DWARF.Core.Domain
{
    public interface ILog : IBaseComponent
    {
        string ApplicationName { get; set; }
        string Exception { get; set; }
        string Level { get; set; }
        string Location { get; set; }
        DateTime LogDate { get; set; }
        string Message { get; set; }
        string Thread { get; set; }
    }
}
