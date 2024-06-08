namespace Form.UI;

public class SelectorPersonalizadoSubcategoria
{
    public long ID{get;set;}
    public long IDSubcategoria{get;set;}
    public string? Descripcion {get;set;}
    public string? Detalle {get;set;}

    public ElementoSelectorPersonalizado? ElementoSeleccionado{get;set;}
    
}
