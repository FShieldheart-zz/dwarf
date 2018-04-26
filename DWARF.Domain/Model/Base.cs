using System;
using System.Runtime.Serialization;
using DWARF.Core.Domain;

namespace DWARF.Domain.Model
{
    [DataContract]
    public abstract class Base : IBase
    {
        public Base(Guid? id = null, DateTime? createdDate = null, DateTime? updatedDate = null)
        {
            Id = id ?? Guid.NewGuid();
            CreatedDate = createdDate ?? DateTime.UtcNow;
            UpdatedDate = updatedDate ?? DateTime.UtcNow;
        }

        [DataMember(Name = "Id")]
        public Guid Id { get; set; }

        [DataMember(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "UpdatedDate")]
        public DateTime UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
            return String.Join(Id.ToString(), ", ",
                                CreatedDate.ToUniversalTime().ToString(), ", ",
                                UpdatedDate.ToUniversalTime().ToString()
                                );
        }

        public override bool Equals(object obj)
        {
            Base baseObject = obj as Base;
            return (baseObject != null) &&
                   (Id == baseObject.Id) &&
                   CreatedDate.ToUniversalTime().ToString().Equals(baseObject.CreatedDate.ToUniversalTime().ToString()) &&
                   UpdatedDate.ToUniversalTime().ToString().Equals(baseObject.UpdatedDate.ToUniversalTime().ToString())
                   ;
        }

        public override int GetHashCode() => Id.GetHashCode() ^
                                            CreatedDate.GetHashCode() ^
                                            UpdatedDate.GetHashCode()
                                            ;
    }
}
