namespace Guideti.ObrasBibliograficas.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
        }

        public long Id { get; set; }
    }
}
