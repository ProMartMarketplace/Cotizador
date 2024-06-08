namespace Form.UI;

public class ElementoSelectorPersonalizado
{
    public long ID{get;set;}
    public long IDSelector{get;set;}
    public string? Descripcion{get;set;}

    public string? Detalle{get;set;}

    public override int GetHashCode() => Descripcion?.GetHashCode() ?? 0;
    public override string ToString() => Descripcion;
}
