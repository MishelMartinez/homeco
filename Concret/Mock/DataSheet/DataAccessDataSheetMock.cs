using InmobiliariasHomeCo.Abstract.DataSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.DataSheets;

namespace InmobiliariasHomeCo.Concret.Mock.DataSheets
{
    public class DataAccessDataSheetMock : IDataAccessDataSheet
    {
        public DataSheet[] GetDataSheet()
        {
            return new DataSheet[]{
             new  DataSheet()
             {
                 idinmueble = "MX18-EC3225",
                 describeimg1= "Casa de 2 pisos",
                 describeimg2= "Habitación principal",
                 describeimg3= "Baños con acabados de lujo",
                 describeimg4= "Vista trasera",
                 img1= "assets/images/property/casa1.1.jpg",
                 img2= "assets/images/property/casa1.3.jpg",
                 img3= "assets/images/property/casa1.2.jpg",
                 img4= "assets/images/property/casa1.jpg",
                 tipodeinmueble="Casa",
                 colonia="El Refugio",
                 cp="52632",
                 noexterior="122",
                 state= "Venta",
                 subtipodeinmueble= "Fraccionamiento",
                 zona= "Zona Residencial",
                 calle= "Fray Junípero Serra",
                 nointerior= "122",
                 price= "$2,771,395" + "MXN",
                 describe= "Para los que buscamos comodidad, la casa tiene pasillo y CUARTO DE SERVICIO, jardín de 150m2, terraza, lámparas, mosquiteros, persianas, con cisterna e hidroneumático. 2 lugares de estacionamiento y alarma. Además de todo, cuenta con un salón de juegos con medio baño. Cumbres del Lago, uno de los fraccionamientos más bonitos de Juriquilla y con alta plusvalía. 317m2 de terreno y 372m2 de construcción, muy buen precio relación con metros cuadrados.",
                 tamaniodeterreno= "317" + "M2",
                 niveles= "2 Pisos",
                 habitaciones= "4",
                 cocinaintegrada= "Si",
                 construido= "250" + "M2",
                 mediobanio= "2",
                 banioscompletos= "3",
                 estacionamiento= "3",
                 describeareas= "Jardín,4 Bodegas, Terraza, Lava trastes, Asador, Sala de TV, Lámparas, Estudio, Mosquiteros, 500 Lts Cisterna, 4 Closets, Cerca Eléctrica, Canchas Deportivas, Sistema de Riego."

             }
        };

        }
    }
}
