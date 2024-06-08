namespace Form.UI;

public class Subcategoria
{
    public long ID{get;set;}
    public long IDCategoria{get;set;}
    public string? Nombre {get;set;}
    public bool SoportaLineaColor{get;set;}=false;
    public bool SoportaLineaTalle{get;set;}=false;
}
