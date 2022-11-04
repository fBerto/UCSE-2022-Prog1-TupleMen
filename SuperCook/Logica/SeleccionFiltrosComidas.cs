using System;

namespace Logica
{
    public class SeleccionFiltrosComidas
    {
        public bool PorSaludable { get; set; }
        public bool PorMomentoComida { get; set; }
        public bool PorFecha { get; set; }
        public bool PorReceta {get; set; }
        public bool EsSaludable {get; set; }
        public MomentosComida Momento { get; set; }
        public DateTime FechaMenor { get; set; }
        public DateTime FechaMayor { get; set; }
        public Receta Receta { get; set; }

        public SeleccionFiltrosComidas(bool porSaludable, bool porMomentoComida, bool porFecha, bool porReceta, bool esSaludable,
            MomentosComida momento, DateTime fechaMenor, DateTime fechaMayor, Receta receta)
        {
            PorSaludable = porSaludable;
            PorMomentoComida = porMomentoComida;
            PorFecha = porFecha;
            PorReceta = porReceta;
            EsSaludable = esSaludable;
            Momento = momento;
            FechaMenor = fechaMenor;
            FechaMayor = fechaMayor;
            Receta = receta;
        }
    }
}
