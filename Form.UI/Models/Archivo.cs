using Microsoft.AspNetCore.Components.Forms;

namespace Form.UI;

public class Archivo
{
    public string? UUID{get;set;}
    public string? Nombre{get;set;}
    public StreamContent? FileContent{get;set;}

    public IBrowserFile BrowserFile{get;set;}
}
