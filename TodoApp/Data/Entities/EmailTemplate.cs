namespace TodoApp.Data.Entities
{
    public class EmailTemplate : BaseEntity
    {
        public string EmailTemplateName { get; set; }
        public string Body { get; set; }
        public Guid CompanyId { get; set; }
    }
}
