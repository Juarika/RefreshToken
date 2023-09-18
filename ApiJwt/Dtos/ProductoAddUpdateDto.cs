using System.ComponentModel.DataAnnotations;

namespace ApiJwt.Dtos;

public class ProductoAddUpdateDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El Nombre del producto es requerido")]
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public DateTime FechaCreacion { get; set; }
    public int MarcaId { get; set; }
    public int CategoriaId { get; set; }
}