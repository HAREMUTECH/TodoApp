using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Data.Entities
{
    public class EmailTemplate : BaseEntity
    {
        [MaxLength(250)]
        public string EmailTemplateName { get; set; }
        [MaxLength(250)]
        public string Body { get; set; }
        public Guid CompanyId { get; set; }
    }
}
