using System;

namespace PortNet.Model.Common
{
    public abstract class AuditableEntity
    {
        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateBy { get; set; }
    }
}