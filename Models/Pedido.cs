using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    
    public class Pedido
    {        
        public int PedidoId { get; set; }

        //para criar um relacionamento com a tabela de detalhes do pedido
        public List<PedidoDetalhe> PedidoItens { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o Sobrenome")]
        [Display(Name ="Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Endereco1 { get; set; }

        [Required(ErrorMessage = "Informe o Complemento do Endereço")]
        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "Informe o Cep")]
        [Display(Name = "CEP")]
        [StringLength(9)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o Estado")]
        [Display(Name = "Estado")]
        [StringLength(20)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a Cidade")]
        [Display(Name = "Cidade")]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o Telefone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        [StringLength(11)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        [StringLength(100)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)] //não exibir no formulario
        [Display(Name = "Valor Total do Pedido")]
        public decimal PedidoTotal { get; set; }

        //[BindNever]
        //[ScaffoldColumn(false)] //não exibir no formulario
        [Display(Name = "Data/Hora do Envio do Pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}")]
        public DateTime? PedidoEnviado { get; set; }

        [Display(Name ="Data/Hora da Entrega do Pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0: dd/MM/yyyy hh:mm}")]
        public DateTime? PedidoEntregueEm { get; set; }

    }
}
