using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor informe a descrição")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor informe a Data")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Por favor selecione a categoria")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Por favor selecione um Status")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "Aberto" && DueDate < DateTime.Today;
    }
}

