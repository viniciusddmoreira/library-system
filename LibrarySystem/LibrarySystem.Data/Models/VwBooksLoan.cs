﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    //[Keyless]
    public partial class VwBooksLoan
    {
        [Required]
        [Column("cpf")]
        [StringLength(14)]
        [Unicode(false)]
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        [Required]
        [Column("customer_name")]
        [StringLength(100)]
        [Unicode(false)]
        [DisplayName("Nome do Cliente")]
        public string CustomerName { get; set; }
        [Required]
        [Column("book_name")]
        [StringLength(100)]
        [Unicode(false)]
        [DisplayName("Nome do Livro")]
        public string BookName { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("book_id")]
        public int? BookId { get; set; }
        [Column("customer_id")]
        public int? CustomerId { get; set; }
        [Column("loan_date", TypeName = "datetime")]
        [DisplayName("Data do Empréstimo")]
        public DateTime? LoanDate { get; set; }
        [Column("delivery_date", TypeName = "datetime")]
        [DisplayName("Data da Devolução")]
        public DateTime DeliveryDate { get; set; }
        [Column("returned")]
        [DisplayName("Devolução")]
        public bool Returned { get; set; }
    }
}