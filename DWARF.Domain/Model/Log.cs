using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using DWARF.Core.Domain;

namespace DWARF.Domain.Model
{
    [DataContract]
    public class Log : Base, ILog
    {
        [DataMember(Name = "ApplicationName")]
        public string ApplicationName { get; set; }

        [DataMember(Name = "Thread")]
        public string Thread { get; set; }

        [DataMember(Name = "Level")]
        public string Level { get; set; }

        [DataMember(Name = "Location")]
        public string Location { get; set; }

        [DataMember(Name = "Message")]
        public string Message { get; set; }

        [DataMember(Name = "Exception")]
        public string Exception { get; set; }

        [Required]
        [DataMember(Name = "LogDate")]
        public DateTime LogDate { get; set; }

        public override string ToString()
        {
            return String.Join(base.ToString(), ", ",
                                ApplicationName, ", ",
                                Thread, ", ",
                                Level, ",",
                                Location, ",",
                                Message, ",",
                                Exception, ",",
                                LogDate.ToUniversalTime().ToString()
                                );
        }

        public override bool Equals(object obj)
        {
            Log logObject = obj as Log;
            return (logObject != null) &&
                   (Id == logObject.Id) &&
                   CreatedDate.ToUniversalTime().ToString().Equals(logObject.CreatedDate.ToUniversalTime().ToString()) &&
                   UpdatedDate.ToUniversalTime().ToString().Equals(logObject.UpdatedDate.ToUniversalTime().ToString()) &&
                   ApplicationName.Equals(logObject.ApplicationName) &&
                   Thread.Equals(logObject.Thread) &&
                   Level.Equals(logObject.Level) &&
                   Location.Equals(logObject.Location) &&
                   Message.Equals(logObject.Message) &&
                   Exception.Equals(logObject.Exception) &&
                   LogDate.Equals(logObject.LogDate)
                   ;
        }

        public override int GetHashCode() => Id.GetHashCode() ^
                                            CreatedDate.GetHashCode() ^
                                            UpdatedDate.GetHashCode() ^
                                            ApplicationName.GetHashCode() ^
                                            Thread.GetHashCode() ^
                                            Level.GetHashCode() ^
                                            Location.GetHashCode() ^
                                            Message.GetHashCode() ^
                                            Exception.GetHashCode() ^
                                            LogDate.GetHashCode()
                                            ;
    }
}
