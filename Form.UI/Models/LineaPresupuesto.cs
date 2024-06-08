using System.Dynamic;

namespace Form.UI;

public class LineaPresupuesto
{
    public string? UUID{get;set;}
    public string? UUIDPresupuesto{get;set;}
    public string? NombreProducto{get;set;}
    public long IDCategoria{get;set;}
    public long IDSubcategoria{get;set;}
    public string? Marca{get;set;}
    public double CantidadSinColorNiTalle{get;set;}//Para cuando no haya color ni talle seleccionable
    public string? CodigoProducto{get;set;}

    public string? UUIDArchivo{get;set;}
    public string? NotaEspecificacion{get;set;}

    
    public List<LineaTalleYColor> LineasTalleYColor{get;set;}=new();

    public List<SelectorPersonalizadoSubcategoria> SelectoresPersonalizados{get;set;}=new();
    public Categoria Categoria{get{
        List<Categoria> categorias=CategoriaData.GetCategorias();
        Categoria c = new();
        foreach(Categoria cat in categorias){
            if(cat.ID==this.IDCategoria){
                c=cat;
            }
        }
        return c;
    }}

    public Subcategoria Subcategoria{get{
        List<Subcategoria> subcategorias=CategoriaData.GetSubcategorias(IDCategoria);
        Subcategoria s =new();
        foreach(Subcategoria sub in subcategorias){
            if(sub.ID==this.IDSubcategoria){
               s=sub;
            }
        }
        return s;
    }}



    public List<Archivo> Archivos{get;set;}=new();



    public string getTextLineaPresupuesto(){
        string linea="Nombre de producto : "+this.NombreProducto;
        linea=linea+Environment.NewLine;
        linea=linea+"Categoria : "+this.Categoria.Descripcion;
        linea=linea+Environment.NewLine;
        linea=linea+"Subcategoria : "+this.Subcategoria.Nombre;
        linea=linea+Environment.NewLine;
        foreach(SelectorPersonalizadoSubcategoria esp in SelectoresPersonalizados){
            linea=linea+esp.Descripcion+" : "+esp.ElementoSeleccionado.Descripcion;
            linea=linea+Environment.NewLine;
        }
        linea=linea+"Marca : "+this.Marca;
        linea=linea+Environment.NewLine;
        linea=linea+"Codigo de producto : "+this.CodigoProducto;
        linea=linea+Environment.NewLine;
        linea=linea+"====================================================================";
        linea=linea+Environment.NewLine;
        linea=linea+"Notas de especificacion : "+NotaEspecificacion;
        linea=linea+Environment.NewLine;
        linea=linea+"====================================================================";
        foreach(LineaTalleYColor ltc in LineasTalleYColor){
            linea=linea+Environment.NewLine;
            if(ltc.Color is null){
                linea=linea+"Talla : "+ltc.Talle+" - Cantidad : "+ltc.Cantidad.ToString();
            }
            if(ltc.Talle is null){
                linea=linea+"Color : "+ltc.Color+" - Cantidad : "+ltc.Cantidad.ToString();
            }
            if(ltc.Talle is not null && ltc.Color is not null){
            linea=linea+"Color : "+ltc.Color+" -Talla : "+ltc.Talle+" - Cantidad : "+ltc.Cantidad.ToString();
            }
            linea=linea+Environment.NewLine;
            
        }
        if(LineasTalleYColor.Count==0){
            linea=linea+"Cantidad : "+this.CantidadSinColorNiTalle.ToString();
        }

        return linea;
    }
    public string getTableShowableCantidades(){
        string cants="";
        if(Subcategoria.SoportaLineaColor||Subcategoria.SoportaLineaTalle){
            foreach(LineaTalleYColor ltc in LineasTalleYColor){
                if(Subcategoria.SoportaLineaColor){
                    cants=cants+ltc.Color+" ";
                }
                if(Subcategoria.SoportaLineaTalle){
                    cants=cants+ltc.Talle+" ";
                }
                cants=cants+ltc.Cantidad.ToString();
                cants=cants+Environment.NewLine;
            }
        }else{
            cants=CantidadSinColorNiTalle.ToString();
        }
        return cants;
    }

}
