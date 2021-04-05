using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public class Estate1
    {
        public int      IdProperty      { get; set; }
        public string   PropertyKey     { get; set; }
        public DateTime FechaCaptura    { get; set; }
        public int      IdStreet        { get; set; }
        public string   Number          { get; set; }
        public string   InteriorNumber  { get; set; }
        public byte     IdRegion        { get; set; }
        public bool     Provisional     { get; set; }


        public string   Surface         { get; set; }
        public byte     IdGround        { get; set; }


        public bool     Maintenance     { get; set; }
        public bool     Furnished       { get; set; }
        public bool     Bailor          { get; set; }
        public bool     LegalPolicy     { get; set; }
        public string   Other           { get; set; }
        public bool     IsPrivate       { get; set; }
        public bool     Services        { get; set; }


        public string   OperationType   { get; set; }
        public int      IdProdCat       { get; set; }
        public int      IdProduct       { get; set; }
        public decimal  Commission      { get; set; }
        public int      IdSalesRep      { get; set; }
        public decimal  AmountRent      { get; set; }
        public decimal  AmountBuy       { get; set; }
        public byte     Stat            { get; set; }
        public decimal  FinalPrc        { get; set; }
        public int      IdSalesFinal    { get; set; }


        public string   Description     { get; set; }
        public bool     Policy          { get; set; }

        public bool              EscrituraLiberada      { get; set; }
        public string            NumEscritura           { get; set; }
        public bool              CreditoVigente         { get; set; }
        public Nullable<decimal> DeudaCredito           { get; set; }
        public bool              LibreGravamen          { get; set; }
        public bool              ServiciosAlCorriente   { get; set; }
        public bool              VentaUltimos3anhos     { get; set; }
        public bool              ConoceLeyAntilavado    { get; set; }
        public string            OtroEstatusLegal       { get; set; }
    }
}
