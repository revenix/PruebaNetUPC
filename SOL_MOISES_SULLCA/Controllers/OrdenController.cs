using SOL_MOISES_SULLCA.Models;
using SOL_MOISES_SULLCA.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOL_MOISES_SULLCA.Controllers
{
    public class OrdenController : Controller
    {
        // GET: Orden
        public ActionResult Index()
        {
            List<OrdenTableViewModel> lst = null;

            using (BDVentaEntities db= new BDVentaEntities())
            {
                lst = (from od in db.orden_detalle
                       join o in db.orden on od.id_orden equals o.id 
                       join c in db.cliente on o.id_cliente equals c.id
                       join p in db.producto on od.id_producto equals p.id
                      
                       select new OrdenTableViewModel
                       {
                           cliente = c.nombre + " " + c.apellido_pat + " " + c.apellido_mat,
                           Producto = p.nombre,
                           cantidad = od.cantidad,
                           importe_unitario = od.importe,
                           importe_total = o.importe_total,
                           fecha_ingreso = o.fecha_ingreso,
                           fecha_estimada = o.fecha_entrega,
                           
                       }).ToList();

            } 
            return View(lst);
        }
    }
}