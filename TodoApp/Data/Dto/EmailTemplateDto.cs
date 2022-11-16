namespace TodoApp.Data.Dto
{
    public class EmailTemplateDto
    {
        public string EmailTemplateName { get; set; }
        public string Body { get; set; }
        public Guid CompanyId { get; set; }
    }


    public class UpdateEmailTemplateRequestDto
    {
        public Guid Id { get; set; }
        public string EmailTemplateName { get; set; }
        public string Body { get; set; }
        public Guid CompanyId { get; set; }
    }

    public class CreateEmailTemplateRequestDto
    {
        public string EmailTemplateName { get; set; }
        public string Body { get; set; }
        public Guid CompanyId { get; set; }
    }
}
