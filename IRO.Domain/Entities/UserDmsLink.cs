using IRO.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Domain.Entities
{
    public class UserDmsLink : AuditableEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string DmsId { get; set; }

        public User User { get; set; }
    }
}
