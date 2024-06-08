namespace Form.UI;

public class CategoriaData
{
    public static List<Categoria> GetCategorias(){
        List<Categoria> categorias=new();
        //
        Categoria c1=new();
        c1.Descripcion="Proteccion de pies";
        c1.ID=1;
        categorias.Add(c1);
        Categoria c2=new();
        c2.Descripcion="Proteccion anti caidas";
        c2.ID=2;
        categorias.Add(c2);
        Categoria c3=new();
        c3.Descripcion="Proteccion de cabeza";
        c3.ID=3;
        categorias.Add(c3);
        Categoria c4=new();
        c4.Descripcion="Proteccion de cuerpo";
        c4.ID=4;
        categorias.Add(c4);
        Categoria c5=new();
        c5.Descripcion="Proteccion de manos";
        c5.ID=5;
        categorias.Add(c5);
        Categoria c6=new();
        c6.Descripcion="Uniformes";
        c6.ID=6;
        categorias.Add(c6);
        return categorias;
    }

    public static List<Subcategoria> GetSubcategorias(long idCategoria){
        List<Subcategoria> subc=new();
        if(idCategoria==1){
            //Proteccion de pies
            Subcategoria s1=new();
            s1.Nombre="Calzado de proteccion";
            s1.IDCategoria=1;
            s1.ID=1;
            s1.SoportaLineaTalle=true;
            s1.SoportaLineaColor=true;
            subc.Add(s1);
            Subcategoria s2=new();
            s2.Nombre="Bota de PVC";
            s2.IDCategoria=1;
            s2.ID=2;
            s2.SoportaLineaTalle=true;
            s2.SoportaLineaColor=true;
            subc.Add(s2);
        }
        if(idCategoria==2){
            //Proteccion anti caida
            Subcategoria s3=new();
            s3.Nombre="Otros";
            s3.IDCategoria=2;
            s3.ID=3;
            s3.SoportaLineaTalle=false;
            s3.SoportaLineaColor=true;
            subc.Add(s3);
            Subcategoria s4=new();
            s4.Nombre="Arnes";
            s4.IDCategoria=2;
            s4.ID=4;
            s4.SoportaLineaTalle=false;
            s4.SoportaLineaColor=true;
            subc.Add(s4);
            Subcategoria s5=new();
            s5.Nombre="Amortiguadores";
            s5.IDCategoria=2;
            s5.ID=5;
            s5.SoportaLineaTalle=false;
            s5.SoportaLineaColor=true;
            subc.Add(s5);
            Subcategoria s6=new();
            s6.Nombre="Cinturones";
            s6.IDCategoria=2;
            s6.ID=6;
            s6.SoportaLineaTalle=false;
            s6.SoportaLineaColor=true;
            subc.Add(s6);
            Subcategoria s7=new();
            s7.Nombre="Lineas de vida";
            s7.IDCategoria=2;
            s7.ID=7;
            s7.SoportaLineaTalle=false;
            s7.SoportaLineaColor=true;
            subc.Add(s7);
            Subcategoria s8=new();
            s8.Nombre="Punto Fijo";
            s8.IDCategoria=2;
            s8.ID=8;
            s8.SoportaLineaTalle=false;
            s8.SoportaLineaColor=true;
            subc.Add(s8);
        }
        if(idCategoria==3){
            //Proteccion de cabeza
            Subcategoria s9=new();
            s9.Nombre="Casco de proteccion";
            s9.IDCategoria=3;
            s9.ID=9;
            s9.SoportaLineaTalle=false;
            s9.SoportaLineaColor=true;
            subc.Add(s9);
            Subcategoria s10=new();
            s10.Nombre="Lentes de proteccion";
            s10.IDCategoria=3;
            s10.ID=10;
            s10.SoportaLineaTalle=false;
            s10.SoportaLineaColor=true;
            subc.Add(s10);
            Subcategoria s11=new();
            s11.Nombre="Mascarillas respiratorias";
            s11.IDCategoria=3;
            s11.ID=11;
            s11.SoportaLineaTalle=false;
            s11.SoportaLineaColor=true;
            subc.Add(s11);
            Subcategoria s12=new();
            s12.Nombre="Tapones auditivos";
            s12.IDCategoria=3;
            s12.ID=12;
            s12.SoportaLineaTalle=false;
            s12.SoportaLineaColor=false;
            subc.Add(s12);
            Subcategoria s13=new();
            s13.Nombre="Otros";
            s13.IDCategoria=3;
            s13.ID=13;
            s13.SoportaLineaTalle=true;
            s13.SoportaLineaColor=true;
            subc.Add(s13);
        }
        if(idCategoria==4){
            //Proteccion de cuerpo
            Subcategoria s14=new();
            s14.Nombre="Chalecos";
            s14.IDCategoria=4;
            s14.ID=14;
            s14.SoportaLineaTalle=true;
            s14.SoportaLineaColor=true;
            subc.Add(s14);
            Subcategoria s15=new();
            s15.Nombre="Fajas";
            s15.IDCategoria=4;
            s15.ID=15;
            s15.SoportaLineaTalle=true;
            s15.SoportaLineaColor=true;
            subc.Add(s15);
            Subcategoria s16=new();
            s16.Nombre="Impermeables";
            s16.IDCategoria=4;
            s16.ID=16;
            s16.SoportaLineaTalle=true;
            s16.SoportaLineaColor=true;
            subc.Add(s16);
            Subcategoria s17=new();
            s17.Nombre="Mangas y Mandiles";
            s17.IDCategoria=4;
            s17.ID=17;
            s17.SoportaLineaTalle=true;
            s17.SoportaLineaColor=true;
            subc.Add(s17);
        }
        if(idCategoria==5){
            //Proteccion de manos
            Subcategoria s18=new();
            s18.Nombre="Guantes de piel y carnaza";
            s18.IDCategoria=5;
            s18.ID=18;
            s18.SoportaLineaTalle=true;
            s18.SoportaLineaColor=true;
            subc.Add(s18);
            Subcategoria s19=new();
            s19.Nombre="Guantes recubiertos";
            s19.IDCategoria=5;
            s19.ID=19;
            s19.SoportaLineaTalle=true;
            s19.SoportaLineaColor=true;
            subc.Add(s19);
            Subcategoria s20=new();
            s20.Nombre="Otros";
            s20.IDCategoria=5;
            s20.ID=20;
            s20.SoportaLineaTalle=true;
            s20.SoportaLineaColor=true;
            subc.Add(s20);
        }
        if(idCategoria==6){
            //Uniformes
            Subcategoria s21=new();
            s21.Nombre="Batas";
            s21.IDCategoria=6;
            s21.ID=21;
            s21.SoportaLineaTalle=true;
            s21.SoportaLineaColor=true;
            subc.Add(s21);
            Subcategoria s22=new();
            s22.Nombre="Camisas";
            s22.IDCategoria=6;
            s22.ID=22;
            s22.SoportaLineaTalle=true;
            s22.SoportaLineaColor=true;
            subc.Add(s22);
            Subcategoria s23=new();
            s23.Nombre="Chamarras";
            s23.IDCategoria=6;
            s23.ID=23;
            s23.SoportaLineaTalle=true;
            s23.SoportaLineaColor=true;
            subc.Add(s23);
            Subcategoria s24=new();
            s24.Nombre="Pantalones";
            s24.IDCategoria=6;
            s24.ID=24;
            s24.SoportaLineaTalle=true;
            s24.SoportaLineaColor=true;
            subc.Add(s24);
            Subcategoria s25=new();
            s25.Nombre="Overoles";
            s25.IDCategoria=6;
            s25.ID=25;
            s25.SoportaLineaTalle=true;
            s25.SoportaLineaColor=true;
            subc.Add(s25);
        }
        return subc;
    }

    public static List<SelectorPersonalizadoSubcategoria> getSelectoresAdicionalesSubcategoria(long idSubcategoria){
        List<SelectorPersonalizadoSubcategoria> selects=new();
        if(idSubcategoria==1){
            //calzado de proteccion
            SelectorPersonalizadoSubcategoria sl1=new();
            sl1.Descripcion="Tipo de protección";
            sl1.ID=1;
            sl1.IDSubcategoria=1;
            selects.Add(sl1);
            SelectorPersonalizadoSubcategoria sl2=new();
            sl2.Descripcion="Altura de calzado";
            sl2.ID=2;
            sl2.IDSubcategoria=1;
            selects.Add(sl2);
        }
        if(idSubcategoria==2){
            //bota de pvc
            SelectorPersonalizadoSubcategoria sl3=new();
            sl3.Descripcion="Tipo de protección";
            sl3.ID=3;
            sl3.IDSubcategoria=2;
            selects.Add(sl3);
        }
        return selects;
    }

    public static List<ElementoSelectorPersonalizado> getElementosSelectorPersonalizado(long idSelector){
        List<ElementoSelectorPersonalizado> elementos=new();
        if(idSelector==1){
            //proteccion pies -> calzado de proteccion -> tipo de proteccion
            ElementoSelectorPersonalizado e1=new();
            e1.ID=1;
            e1.IDSelector=1;
            e1.Descripcion="Tipo 1 Ocupacional";
            e1.Detalle="Calzado para trabajos con riesgos menores como cortaduras, golpes leves, sin casquillo de protección.";
            elementos.Add(e1);
            ElementoSelectorPersonalizado e2=new();
            e2.ID=2;
            e2.IDSelector=1;
            e2.Descripcion="Tipo 2 Puntera de proteccion";
            e2.Detalle="Destinado a proteger los dedos de los pies, donde existen riesgos de impacto y compresión en la punta del pie.";
            elementos.Add(e2);
            ElementoSelectorPersonalizado e3=new();
            e3.ID=3;
            e3.IDSelector=1;
            e3.Descripcion="Tipo 3 Dielectrico";
            e3.Detalle="Este calzado aísla y protege a la persona de descargas eléctricas de hasta 14,000 Voltios.";
            elementos.Add(e3);
            ElementoSelectorPersonalizado e4=new();
            e4.ID=4;
            e4.IDSelector=1;
            e4.Descripcion="Tipo 2 Puntera de proteccion + Tipo 3 Dielectrico";
            e4.Detalle="Calzado destinado a proteger los dedos de los pies y una descarga de hasta 14,000 Volts";
            elementos.Add(e4);
            ElementoSelectorPersonalizado e5=new();
            e5.ID=5;
            e5.IDSelector=1;
            e5.Descripcion="Tipo 4 Metatarsal";
            e5.Detalle="Destinado a proteger el empeine del pie contra riesgos de impacto directo al metatarso y también cubre los riesgos asociados al calzado con puntera de protección";
            elementos.Add(e5);
            ElementoSelectorPersonalizado e6=new();
            e6.ID=6;
            e6.IDSelector=1;
            e6.Descripcion="Tipo 5 conductivo";
            e6.Detalle="Destinado a disipar la electricidad estática del cuerpo al piso, para reducir la posibilidad de ignición de mezclas explosivas o sustancias inflamables.";
            elementos.Add(e6);
            ElementoSelectorPersonalizado e7=new();
            e7.ID=7;
            e7.IDSelector=1;
            e7.Descripcion="Tipo 6 Anti Punzo Cortante";
            e7.Detalle="Destinado a proteger la planta del pie del usuario contra objetos punzo-cortantes que puedan traspasar la suela del calzado.";
            elementos.Add(e7);
            ElementoSelectorPersonalizado e8=new();
            e8.ID=8;
            e8.IDSelector=1;
            e8.Descripcion="Tipo 7 Antiestatico";
            e8.Detalle="Disipa la electricidad estática, llevándola del cuerpo al suelo, y ofrece una protección limitada contra choques eléctricos.";
            elementos.Add(e8);
        }
        if(idSelector==2){
            //Proteccion de pies -> Calzado de proteccion -> Altura de calzado
            ElementoSelectorPersonalizado e9=new();
            e9.ID=9;
            e9.IDSelector=2;
            e9.Descripcion="Choclo (Debajo del tobillo)";
            elementos.Add(e9);
            ElementoSelectorPersonalizado e10=new();
            e10.ID=10;
            e10.IDSelector=2;
            e10.Descripcion="Borcegui (Sobre el tobillo)";
            elementos.Add(e10);
            ElementoSelectorPersonalizado e11=new();
            e11.ID=11;
            e11.IDSelector=2;
            e11.Descripcion="Bota (Arriba del tobillo)";
            elementos.Add(e11);
        }
        if(idSelector==3){
            //Proteccion de pies -> Bota de PVC ->Tipo de proteccion
            ElementoSelectorPersonalizado e12=new();
            e12.ID=12;
            e12.IDSelector=3;
            e12.Descripcion="Sin Casquillo";
            elementos.Add(e12);
            ElementoSelectorPersonalizado e13=new();
            e13.ID=12;
            e13.IDSelector=3;
            e13.Descripcion="Con Casquillo";
            elementos.Add(e13);
        }
        return elementos;
    }
    
}
