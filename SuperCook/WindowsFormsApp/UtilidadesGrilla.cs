using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class UtilidadesGrilla
    {
        public void CargarCamposAcciones(DataGridView grilla)
        {
            int indiceColumnaEditar = ObtenerIndice(grilla, "Editar");
            int indiceColumnaEliminar = ObtenerIndice(grilla, "Eliminar");

            foreach (DataGridViewRow row in grilla.Rows)
            {
                row.Cells[indiceColumnaEliminar].Value = "Eliminar";
                row.Cells[indiceColumnaEditar].Value = "Editar";
            }
        }

        public int ObtenerIndice(DataGridView grilla, string nombreColumna)
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return column.Index;
                }
            }
            return -1;
        }
    }
}
