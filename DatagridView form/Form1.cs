using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatagridView_form
{
    public partial class Form1 : Form
    {
        //boolean para conectar y desconectar de sql
        bool conected = false;
        //------------------------------------------
        SqlConnection conexion = new SqlConnection("Data source=SYSADMIN; Initial Catalog=Biblioteca; User Id=root; Password=1234");
        public Form1()
        {
            InitializeComponent();
        }

        //accion al clickear el boton conect
        private void conex_Click(object sender, EventArgs e)
        {
            if (conected == false)
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conectados");
                    conected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                try
                {
                    conexion.Close();
                    MessageBox.Show("Desconectados");
                    conected = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        //----------------------------------
        //accion al clickear el boton select
        private void selec_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Necesita seleccionar una tabla en el combobox", "Seleccione tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand comando = new SqlCommand("EXECUTE " + comboBox1.SelectedItem + "Proc", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }
        //----------------------------------
        //accion al clickear el boton insert
        private void Inser_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Necesita seleccionar una tabla en el combobox", "Seleccione tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == "Autor")
            {
                SqlCommand agregar = new SqlCommand("EXECUTE " + comboBox1.SelectedItem + "InsertProc" +
                    " " + textBoxnombre_autor.Text + "," + textBoxnacionalidad_autor.Text + "," + textBoxapellido_autor.Text + " ", conexion);

                try
                {
                    //agregar.Parameters.Clear();
                    //agregar.Parameters.AddWithValue("@Nombre", textBoxnombre_autor.Text);
                    //agregar.Parameters.AddWithValue("@Nacionalidad", textBoxnacionalidad_autor.Text);
                    //agregar.Parameters.AddWithValue("@Apellido", textBoxapellido_autor.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido agregados correctamente", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Estudiante")
            {
                SqlCommand agregar = new SqlCommand("insert into Estudiante (Nombre,Direccion,Carrera,Edad) values (@Nombre, @Direccion, @Carrera, @Edad)", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Nombre", textBoxnombre_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Direccion", textBoxdireccion_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Carrera", textBoxcarrera_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Edad", textBoxedad_estudiante.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido agregados correctamente", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "LibAut")
            {
                SqlCommand agregar = new SqlCommand("insert into LibAut (IdAutor,IdLibro) values (@IdAutor, @IdLibro)", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdAutor", textBoxidautor_libaut.Text);
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxidlibro_libaut.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido agregados correctamente", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Libro")
            {
                SqlCommand agregar = new SqlCommand("insert into Libro (Titulo,Editorial,Categoria) values (@Titulo, @Editorial, @Categoria)", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Titulo", textBoxtitulo_libro.Text);
                    agregar.Parameters.AddWithValue("@Editorial", textBoxeditorial_libro.Text);
                    agregar.Parameters.AddWithValue("@Categoria", textBoxcategoria_libro.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido agregados correctamente", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Prestamo")
            {
                SqlCommand agregar = new SqlCommand("insert into Prestamo (IdLector,IdLibro,FechaPrestamo,FechaDevolucion) values (@IdLector, @IdLibro, @FechaPrestamo, @FechaDevolucion)", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLector", textBoxidlector_prestamo.Text);
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxidlibro_prestamo.Text);
                    agregar.Parameters.AddWithValue("@FechaPrestamo", dateTimePickerfechaprestamo_prestamo.Text);
                    agregar.Parameters.AddWithValue("@FechaDevolucion", dateTimePickerfechadevolucion_prestamo.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido agregados correctamente", "Datos agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar insertar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //----------------------------------
        //accion al clickear el boton update
        private void updat_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Necesita seleccionar una tabla en el combobox", "Seleccione tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == "Autor")
            {
                SqlCommand agregar = new SqlCommand("update Autor set Nombre = @Nombre, Nacionalidad = @Nacionalidad, Apellido = @Apellido where IdAutor = @IdAutor", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdAutor", textBoxid_autor.Text);
                    agregar.Parameters.AddWithValue("@Nombre", textBoxnombre_autor.Text);
                    agregar.Parameters.AddWithValue("@Nacionalidad", textBoxnacionalidad_autor.Text);
                    agregar.Parameters.AddWithValue("@Apellido", textBoxapellido_autor.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Estudiante")
            {
                SqlCommand agregar = new SqlCommand("update Estudiante set Nombre = @Nombre, Direccion = @Direccion, Carrera = @Carrera, Edad = @Edad where IdLector = @IdLector", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLector", textBoxid_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Nombre", textBoxnombre_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Direccion", textBoxdireccion_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Carrera", textBoxcarrera_estudiante.Text);
                    agregar.Parameters.AddWithValue("@Edad", textBoxedad_estudiante.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "LibAut")
            {
                SqlCommand agregar = new SqlCommand("update LibAut set IdAutor = @IdAutor, IdLibro = @IdLibro where IdLibroAutor = @IdLibroAutor", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLibroAutor", textBoxid_libaut.Text);
                    agregar.Parameters.AddWithValue("@IdAutor", textBoxidautor_libaut.Text);
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxidlibro_libaut.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Libro")
            {
                SqlCommand agregar = new SqlCommand("update Libro set Titulo = @Titulo, Editorial = @Editorial, Categoria = @Categoria where IdLibro = @IdLibro", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxid_libro.Text);
                    agregar.Parameters.AddWithValue("@Titulo", textBoxtitulo_libro.Text);
                    agregar.Parameters.AddWithValue("@Editorial", textBoxeditorial_libro.Text);
                    agregar.Parameters.AddWithValue("@Categoria", textBoxcategoria_libro.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Prestamo")
            {
                SqlCommand agregar = new SqlCommand("update Prestamo set IdLector = @IdLector, IdLibro = @IdLibro, FechaPrestamo = @FechaPrestamo, FechaDevolucion = @FechaDevolucion where IdPrestamo = @IdPrestamo", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdPrestamo", textBoxid_prestamo.Text);
                    agregar.Parameters.AddWithValue("@IdLector", textBoxidlector_prestamo.Text);
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxidlibro_prestamo.Text);
                    agregar.Parameters.AddWithValue("@FechaPrestamo", dateTimePickerfechaprestamo_prestamo.Text);
                    agregar.Parameters.AddWithValue("@FechaDevolucion", dateTimePickerfechadevolucion_prestamo.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar actualizar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //----------------------------------
        //accion al clickear el boton delete
        private void delet_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Necesita seleccionar una tabla en el combobox", "Seleccione tabla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == "Autor")
            {
                SqlCommand agregar = new SqlCommand("Execute "+ comboBox1.SelectedItem + "DeleteP "+ textBoxid_autor.Text, conexion);

                try
                {
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido eliminados correctamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else if (comboBox1.Text == "Estudiante")
            {
                SqlCommand agregar = new SqlCommand("delete from Estudiante where IdLector = @IdLector", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLector", textBoxid_estudiante.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido eliminados correctamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "LibAut")
            {
                SqlCommand agregar = new SqlCommand("delete from LibAut where IdLibroAutor = @IdLibroAutor", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLibroAutor", textBoxid_libaut.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido eliminados correctamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Libro")
            {
                SqlCommand agregar = new SqlCommand("delete from Libro where IdLibro = @IdLibro", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdLibro", textBoxid_libro.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido eliminados correctamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Prestamo")
            {
                SqlCommand agregar = new SqlCommand("delete from Prestamo where IdPrestamo = @IdPrestamo", conexion);

                try
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@IdPrestamo", textBoxid_prestamo.Text);
                    agregar.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido eliminados correctamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar los datos, error:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //----------------------------------

        //Combobox onchange-----------------------------------------------------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //blanqueo de autor
            labelnombre_autor.Visible = false;
            labelid_autor.Visible = false;
            labelnacionalidad_autor.Visible = false;
            labelapellido_autor.Visible = false;
            labelautor_autor.Visible = false;
            //--------------------
            textBoxid_autor.Visible = false;
            textBoxid_autor.Text = "";
            textBoxnombre_autor.Visible = false;
            textBoxnombre_autor.Text = "";
            textBoxnacionalidad_autor.Visible = false;
            textBoxnacionalidad_autor.Text = "";
            textBoxapellido_autor.Visible = false;
            textBoxapellido_autor.Text = "";
            //--------------------

            //blanqueo de estudiante
            labelestudiante_estudiante.Visible = false;
            labelid_estudiante.Visible = false;
            labelnombre_estudiante.Visible = false;
            labeldireccion_estudiante.Visible = false;
            labelcarrera_estudiante.Visible = false;
            labeledad_estudiante.Visible = false;
            //--------------------
            textBoxid_estudiante.Visible = false;
            textBoxid_estudiante.Text = "";
            textBoxnombre_estudiante.Visible = false;
            textBoxnombre_estudiante.Text = "";
            textBoxdireccion_estudiante.Visible = false;
            textBoxdireccion_estudiante.Text = "";
            textBoxcarrera_estudiante.Visible = false;
            textBoxcarrera_estudiante.Text = "";
            textBoxedad_estudiante.Visible = false;
            textBoxedad_estudiante.Text = "";
            //--------------------

            //blanqueo de libro autor
            labellibaut_libaut.Visible = false;
            labelid_libaut.Visible = false;
            labelidautor_libaut.Visible = false;
            labelidlibro_libaut.Visible = false;
            //--------------------
            textBoxid_libaut.Visible = false;
            textBoxid_libaut.Text = "";
            textBoxidautor_libaut.Visible = false;
            textBoxidautor_libaut.Text = "";
            textBoxidlibro_libaut.Visible = false;
            textBoxidlibro_libaut.Text = "";
            //---------------------

            //blanqueo de libro
            labellibro_libro.Visible = false;
            labelid_libro.Visible = false;
            labeltitulo_libro.Visible = false;
            labeleditorial_libro.Visible = false;
            labelcategoria_libro.Visible = false;
            //--------------------
            textBoxid_libro.Visible = false;
            textBoxid_libro.Text = "";
            textBoxtitulo_libro.Visible = false;
            textBoxtitulo_libro.Text = "";
            textBoxeditorial_libro.Visible = false;
            textBoxeditorial_libro.Text = "";
            textBoxcategoria_libro.Visible = false;
            textBoxcategoria_libro.Text = "";
            //-----------------------

            //blanqueo de prestamo
            labelprestamo_prestamo.Visible = false;
            labelid_prestamo.Visible = false;
            labelidlector_prestamo.Visible = false;
            labelidlibro_prestamo.Visible = false;
            labelfechaprestamo_prestamo.Visible = false;
            labelfechadevolucion_prestamo.Visible = false;
            //--------------------
            textBoxid_prestamo.Visible = false;
            textBoxid_prestamo.Text = "";
            textBoxidlector_prestamo.Visible = false;
            textBoxidlector_prestamo.Text = "";
            textBoxidlibro_prestamo.Visible = false;
            textBoxidlibro_prestamo.Text = "";
            dateTimePickerfechaprestamo_prestamo.Visible = false;
            dateTimePickerfechaprestamo_prestamo.ResetText();
            dateTimePickerfechadevolucion_prestamo.Visible = false;
            dateTimePickerfechadevolucion_prestamo.ResetText();

            if (comboBox1.Text == "Autor")
            {
                //visibilidad de formulario autor
                labelautor_autor.Visible = true;
                labelid_autor.Visible = true;
                labelnombre_autor.Visible = true;
                labelnacionalidad_autor.Visible = true;
                labelapellido_autor.Visible = true;
                //
                textBoxid_autor.Visible = true;
                textBoxnombre_autor.Visible = true;
                textBoxnacionalidad_autor.Visible = true;
                textBoxapellido_autor.Visible = true;
            }
            else if (comboBox1.Text == "Estudiante")
            {
                //visibilidad de formulario estudiante
                labelestudiante_estudiante.Visible = true;
                labelid_estudiante.Visible = true;
                labelnombre_estudiante.Visible = true;
                labeldireccion_estudiante.Visible = true;
                labelcarrera_estudiante.Visible = true;
                labeledad_estudiante.Visible = true;
                //--------------------
                textBoxid_estudiante.Visible = true;
                textBoxnombre_estudiante.Visible = true;
                textBoxdireccion_estudiante.Visible = true;
                textBoxcarrera_estudiante.Visible = true;
                textBoxedad_estudiante.Visible = true;
            }
            else if (comboBox1.Text == "LibAut")
            {
                //visibilidad de formulario LibroAutor
                labellibaut_libaut.Visible = true;
                labelid_libaut.Visible = true;
                labelidautor_libaut.Visible = true;
                labelidlibro_libaut.Visible = true;
                //--------------------
                textBoxid_libaut.Visible = true;
                textBoxidautor_libaut.Visible = true;
                textBoxidlibro_libaut.Visible = true;
            }
            else if (comboBox1.Text == "Libro")
            {
                //visibilidad de formulario Libro
                labellibro_libro.Visible = true;
                labelid_libro.Visible = true;
                labeltitulo_libro.Visible = true;
                labeleditorial_libro.Visible = true;
                labelcategoria_libro.Visible = true;
                //--------------------
                textBoxid_libro.Visible = true;
                textBoxtitulo_libro.Visible = true;
                textBoxeditorial_libro.Visible = true;
                textBoxcategoria_libro.Visible = true;
            }
            else if (comboBox1.Text == "Prestamo")
            {
                //visibilidad de formulario Prestamo
                labelprestamo_prestamo.Visible = true;
                labelid_prestamo.Visible = true;
                labelidlector_prestamo.Visible = true;
                labelidlibro_prestamo.Visible = true;
                labelfechaprestamo_prestamo.Visible = true;
                labelfechadevolucion_prestamo.Visible = true;
                //--------------------
                textBoxid_prestamo.Visible = true;
                textBoxidlector_prestamo.Visible = true;
                textBoxidlibro_prestamo.Visible = true;
                dateTimePickerfechaprestamo_prestamo.Visible = true;
                dateTimePickerfechadevolucion_prestamo.Visible = true;
            }
        }
        //Combobox onchange-----------------------------------------------------
    }
}
