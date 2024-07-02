using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Base
    {
        Guid _Id;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ModifiedAt { get; set; }

        [JsonInclude]
        public virtual Guid Id
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }
    }
}
