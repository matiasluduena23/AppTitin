using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppTitin.Modelos
{
    class MetoActulizacion
    {
        //Metodos del formulario Actualizacion(base de datos) 
        public bool buscar(string tipo, string datos , string elemento)
        {
            bool r = true;

            var e = (from lista in XDocument.Load(@"C:\ZimmerGlass\Datos\"+datos+".xml")
                                  .Element(datos).Elements(elemento).Where(a => a.Element("tipo").Value == tipo)
                     select lista).Any();
            if (e == true)
            {
                r = false;
            }
            return r;
        }

        public void Guardar(string txttipo ,string txtprecio, string datos ,string elemento)
        {
            XDocument doc = XDocument.Load(@"C:\ZimmerGlass\Datos\" + datos+".xml");
            if (String.Empty != txttipo && String.Empty != txtprecio)
            {
                if (buscar(txttipo,datos, elemento))
                {
                    doc.Element(datos).Add(
                    new XElement(elemento, new XElement("precio", txtprecio),
                    new XElement("tipo", txttipo)));
                }
                else
                {
                    doc.Element(datos)
                        .Elements(elemento)
                        .Where(a => a.Element("tipo").Value == txttipo).FirstOrDefault()
                        .SetElementValue("precio", txtprecio);
                }
            }
            else
            {
                MessageBox.Show("Complete los campos!!","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

            doc.Save(@"C:\ZimmerGlass\Datos\" + datos+".xml");
        }

        public void eliminar(string tipo, string dato)
        {
            if (!String.IsNullOrEmpty(tipo))
            {
                if (MessageBox.Show("Desea eliminar el elemento  " + tipo+ "?", "Borrar" ,  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        XDocument doc = XDocument.Load(@"C:\ZimmerGlass\Datos\" + dato+".xml");
                        doc.Root.Elements().Where(a => a.Element("tipo").Value == tipo).FirstOrDefault().Remove();
                        doc.Save(@"C:\ZimmerGlass\Datos\" + dato+".xml");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar " + ex.Message);
                    }
                }
            }
        }


    }
}
