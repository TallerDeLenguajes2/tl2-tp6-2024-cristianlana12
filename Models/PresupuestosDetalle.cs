namespace Models;

public class PresupuestosDetalle
{
    private Productos producto;
    private int cantidad;

    public int Cantidad { get => cantidad; set => cantidad = value; }
    internal Productos Producto { get => producto; set => producto = value; }

    PresupuestosDetalle(Productos newProd, int cant){
        this.producto = newProd;
        this.cantidad = cant;
    }
}