using System.Text.Json.Serialization;

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
