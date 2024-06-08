using System.Xml;

namespace Form.UI;

public class Presupuesto
{
    public string? UUID {get;set;}
    public DateTime FechaCreacion{get;set;}
    public string? NombreEmpresa {get;set;}
    public string? NombreContacto {get;set;}
    public string? ApellidoContacto {get;set;}
    public string? Telefono {get;set;}
    public string? Email {get;set;}
    public string? DireccionEntrega {get;set;}
    public string? DireccionEntregaLinea2 {get;set;}
    public string? Estado {get;set;}
    public string? Ciudad {get;set;}
    public string? CodigoPostal {get;set;}
    public string? NotasEntrega {get;set;}

    public List<LineaPresupuesto> LineasPresupuesto{get;set;}=new();


    public string getTextQuote(){
    string presupuesto;
    presupuesto="--------------------------------------------------------------------------------------------------";
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Presupuesto enviado mediante cotizador UUID="+this.UUID;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Fecha de creacion= "+DateTime.Now.ToString();
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"--------------------------------------------------------------------------------------------------";
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Datos de la empresa:";
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Nombre empresa : "+this.NombreEmpresa;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Nombre contacto : "+this.NombreContacto;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Apellido contacto : "+this.ApellidoContacto;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Telefono : "+this.Telefono;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Email : "+this.Email;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Direccion de entrega : "+this.DireccionEntrega;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Direccion de entrega linea 2 : "+this.DireccionEntregaLinea2;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Estado : "+this.Estado;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Ciudad : "+this.Ciudad;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Codigo postal : "+this.CodigoPostal;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"Notas de entrega : "+this.NotasEntrega;
    presupuesto=presupuesto+Environment.NewLine;
    presupuesto=presupuesto+"--------------------------------------------------------------------------------------------------";
    foreach(LineaPresupuesto l in LineasPresupuesto){
        presupuesto=presupuesto+Environment.NewLine;
        presupuesto=presupuesto+l.getTextLineaPresupuesto();
        presupuesto=presupuesto+Environment.NewLine;
        presupuesto=presupuesto+"--------------------------------------------------------------------------------------------------";
    }
    return presupuesto;
    }
}

