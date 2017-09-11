namespace GrupoLTM.Domain.Models
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
    }
}
