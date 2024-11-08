using Models;

public class Presupuestos
{
    private int idPresupuesto;
    private string? nombreDestinatario;
    private string? fechaCreacion;
    private List<PresupuestosDetalle> detalle;

    public int IdPresupuesto { get => idPresupuesto; set => idPresupuesto = value; }
    public string? NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }
    public List<PresupuestosDetalle> Detalle { get => detalle; set => detalle = value; }
    public string? FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

    Presupuestos(){
        this.idPresupuesto = -1;
        this.nombreDestinatario = string.Empty;
        this.fechaCreacion = string.Empty;
        detalle = new List<PresupuestosDetalle>();
    }

    Presupuestos(string nombreDest, string fechaCrea ){
        this.idPresupuesto = -1;
        this.nombreDestinatario = nombreDest;
        this.fechaCreacion = fechaCrea;
        this.detalle = new List<PresupuestosDetalle>();
    }
    Presupuestos(int idPres, string nombreDest, string fechaCrea ){
        this.idPresupuesto = idPres;
        this.nombreDestinatario = nombreDest;
        this.fechaCreacion = fechaCrea;
        this.detalle = new List<PresupuestosDetalle>();
    }

    public float MontoPresupuesto (){
        return (detalle.Select(p => p.Producto.Precio * p.Cantidad).Sum());
    }

    public double MontoPresupuestoConIva(){
        return (MontoPresupuesto() * 1.21);
    }

    public int CantidadProductos (){
        return (detalle.Select( p=>p.Cantidad).Sum());
    }
}