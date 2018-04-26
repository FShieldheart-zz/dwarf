using System;

namespace DWARF.Core.Domain
{
    public interface IBaseComponent
    {
        Guid Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
