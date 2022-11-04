namespace Logica
{
    public class SeleccionFiltrosCompras
    {
        public bool PorTipoIngrediente { get; set; }
        public bool PorTipoBebida { get; set; }
        public bool PorEscasez { get; set; }
        public bool PorCosto { get; set; }
        public bool EsCostoMaximo { get; set; }
        public bool PorUnidadDeMedida { get; set; }
        public TiposIngredientes TipoIngrediente { get; set; }
        public TiposBebidas TipoBebida { get; set; }
        public GradosDeEscasez GradoDeEscasez { get; set; }
        public decimal Costo { get; set; }
        public UnidadesDeMedida UnidadDeMedida { get; set; }

        public SeleccionFiltrosCompras(bool porTipoIngrediente, bool porTipoBebida, bool porEscasez, bool porCosto,
            bool esCostoMaximo, bool porUnidadDeMedida, TiposIngredientes tipoIngrediente, TiposBebidas tipoBebida,
            GradosDeEscasez gradoDeEscasez, decimal costo, UnidadesDeMedida unidadDeMedida)
        {
            this.PorTipoIngrediente = porTipoIngrediente;
            this.PorTipoBebida = porTipoBebida;
            this.PorEscasez = porEscasez;
            this.PorCosto = porCosto;
            this.EsCostoMaximo = esCostoMaximo;
            this.PorUnidadDeMedida = porUnidadDeMedida;
            this.TipoIngrediente = tipoIngrediente;
            this.TipoBebida = tipoBebida;
            this.GradoDeEscasez = gradoDeEscasez;
            this.Costo = costo;
            this.UnidadDeMedida = unidadDeMedida;
        }
    }
}
