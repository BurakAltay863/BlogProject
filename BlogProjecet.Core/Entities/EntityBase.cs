namespace BlogProjecet.Core.Entities
{
    public abstract class EntityBase:IEntityBase
    {
        
        public virtual Guid Id { get; set; } = Guid.NewGuid();

        public virtual string CretedBy { get; set; }

        public virtual string? ModifiedBy { get; set; }

        public virtual string? DeleteBy { get; set; }

        public virtual DateTime CreteDate { get; set; } = DateTime.Now;

        public virtual DateTime? ModifieDate { get; set; }

        public virtual DateTime DeleteDate { get; set; }

        public virtual bool IsDeleted { get; set; } = false;
        
    }
}
