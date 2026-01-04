using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_VeterinariaServices.Models;

namespace TP_VeterinariaServices.DAOs
{
    public class VeterinariaDAO
    {
        public string EdadMadurez;
        public string PesoPromedio;
        public string NombreCliente;
        public string DNICliente;
        public bool ExisteDNI;
        public string Usuario_Actual;
        public bool Verdadero;
        public bool ExisteUsuario;

        //PARA CONECTARSE DESDE OTRA PC, SIMPLEMENTE CAMBIAR EL NOMBRE DEL SERVIDOR AL DE SU 'SQL SERVER'
        private readonly string sConexion = ConfigurationManager
            .AppSettings["strConex"];

        //METODO PARA OBTENER LA CONEXION
        private SqlConnection GetConexion()
        {
            SqlConnection cn = new SqlConnection(this.sConexion);
            cn.Open();
            return cn;
        }

        //METODO PARA INICIAR SESION
        public bool IniciarSesion(string usuario, string pass, bool verdadero)
        {
            //Conexion
            SqlConnection conex = this.GetConexion();

            //Comando sql para iniciar sesion, sesible a mayuscula y minuscula.
            string sQuery = @"SELECT * 
                              FROM Usuarios 
                              WHERE usuario = '" + usuario + "' " +
                             "COLLATE Latin1_General_BIN " +
                             "AND pass = '" + pass + "' COLLATE Latin1_General_BIN";
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Leemos los datos 
            SqlDataReader lector = cmd.ExecuteReader();

            //Si encontro un resultado
            if (lector.Read())
            {
                verdadero = true;

            }
            //No encontro ningun resultado
            else
            {
                verdadero = false;

            }
            //Guardamos el resultado del bool
            Verdadero = verdadero;

            //Finalizamos la lectura
            lector.Close();
            conex.Close();

            return Verdadero;


        }

        //METODO PARA VERIFICAR SI EL USUARIO YA EXISTE
        public bool UsuarioExiste(string usuario, bool existe)
        {
            //Comando sql para verificar si ya existe el usuario
            string sQuery = @"SELECT Count(1) 
                              FROM Usuarios 
                              WHERE usuario = '" + usuario + "'";

            SqlConnection conex = this.GetConexion();
            SqlCommand cmdValidacion = conex.CreateCommand();
            cmdValidacion.CommandText = sQuery;

            //Usamos ExScalar para ejecutar la consulta y guardamos el valor (int) en UsuarioExistente
            int UsuarioExistente = (int)cmdValidacion.ExecuteScalar();

            //Si encontro algun valor deja un mensaje de que ya existe
            if (UsuarioExistente > 0)
            {
                MessageBox.Show("El usuario ingresado ya esta en uso");
                existe = true;
            }
            else
            {
                existe = false;
            }
            //Guardamos el resultado del bool
            ExisteUsuario = existe;

            //Finalizamos la lectura
            conex.Close();
            return ExisteUsuario;

        }

        //METODO PARA AGREGAR UN NUEVO USUARIO
        public void AgregarUsuario(string usuario, string pass)
        {
            // Comando sql para agregar un nuevo usuario 
            string sQuery = @"INSERT INTO Usuarios (usuario, pass) 
                              VALUES ('" + usuario + "' " +
                              "," + " '" + pass + "' )";

            SqlConnection conex = this.GetConexion();
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Ejecutamos el Query, para insertar en la tabla el cmd
            cmd.ExecuteNonQuery();

            //mensaje de registro exitoso
            MessageBox.Show("Registro exitoso!");

            //cerramos la conexion
            conex.Close();
        }

        //METODO PARA SABER EL USUARIO LOGUEADO 
        public string UsuarioActual(string usuario, string usuario_actual)
        {

            //Conexion
            SqlConnection conex = this.GetConexion();

            // Comando sql para saber el usuario actual
            string sQuery = @" SELECT * 
                               FROM Usuarios 
                               WHERE usuario = '" + usuario + "'";
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Leemos los datos 
            SqlDataReader lector = cmd.ExecuteReader();

            //Si encontro un resultado
            if (lector.Read())
            {
                //Obtenemos el string de la columna "usuario"
                usuario_actual = lector["usuario"].ToString();
                
            }
            //GUARDAMOS EL USUARIO ACTUAL
            Usuario_Actual = usuario_actual;
            //Finalizamos la lectura y cerramos la conexion
            lector.Close();
            conex.Close();

            return Usuario_Actual;


        }

        //METODO PARA VERIFICAR SI YA EXISTE EL DNI DEL CLIENTE
        public bool DNIExiste(string dni, bool existe)
        {
            //Comando sql para verificar si ya existe el DNI
            string sQuery = @"SELECT Count(1) 
                              FROM Clientes 
                              WHERE dni = '" + dni + "'";

            SqlConnection conex = this.GetConexion();
            SqlCommand cmdValidacion = conex.CreateCommand();
            cmdValidacion.CommandText = sQuery;

            // Usamos ExScalar para ejecutar la consulta y guardamos el valor(int) en DNIExistente
            int DNIExistente = (int)cmdValidacion.ExecuteScalar();

            //Si encontro algun valor deja un mensaje
            if (DNIExistente > 0)
            {
                MessageBox.Show("El DNI ingresado ya esta en uso");
                existe = true;
            }
            else
            {
                existe = false;
            }

            //Guardamos el valor bool del DNI
            ExisteDNI = existe;

            //Cerramos la conexion
            conex.Close();

            return ExisteDNI;

        }

        // METODO PARA AGREGAR CLIENTES
        public void AgregarCliente(string nombre_cliente, string dni)
        {
            // Consulta sql para agregar clientes 
            string sQuery = @"INSERT INTO Clientes (nombre_cliente, dni) 
                              VALUES ('" + nombre_cliente + "' " +
                              "," + " '" + dni + "' )";

            SqlConnection conex = this.GetConexion();
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Ejecutamos el Query, para insertar en la tabla el cmd
            cmd.ExecuteNonQuery();

            //mensaje de registro exitoso
            MessageBox.Show("Registro exitoso!");

            //Cerramos la conexion
            conex.Close();

        }

        // METODO PARA OBTENER TODOS LOS CLIENTES
        public List<Cliente> getAllClientes()
        {
            // Lista clientes
            List<Cliente> listaResultado = new List<Cliente>();

            // Comando sql para obtener id, nombre y dni del cliente
            string sQuery = @"SELECT id, nombre_cliente, dni
                                FROM Clientes";
            SqlConnection conex = this.GetConexion();
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Leemos los datos 
            SqlDataReader lector = cmd.ExecuteReader();


            while (lector.Read())
            {
                // hacemos una copia de los clientes
                Cliente cliente = new Cliente();

                cliente.id = lector.GetInt32(0);
                cliente.nombre_cliente = lector.GetString(1);
                cliente.dni = lector.GetString(2);

                // agregamos la copia en la lista
                listaResultado.Add(cliente);
            }

            // Cerramos la conexion
            lector.Close();
            conex.Close();

            return listaResultado;

        }

        // METODO PARA MOSTRAR EL CLIENTE ACTUAL EN LA VENTANA INFORMACION CLIENTES
        public void LabelCliente(int id_cliente)
        {
            string nombre_cliente = "";
            string dni_cliente = "";
            // Consulta sql para mostrar nombre y dni del cliente seleccionado
            string sQuery = @"SELECT nombre_cliente, dni 
                                FROM Clientes 
                                WHERE id = '" + id_cliente + "'";
            SqlConnection conex = this.GetConexion();
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Leemos los datos 
            SqlDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                // obtenemos los valores
                nombre_cliente = lector["nombre_cliente"].ToString();
                dni_cliente = lector["dni"].ToString();
            }

            // Guardamos el nombre y el dni
            NombreCliente = nombre_cliente;
            DNICliente = dni_cliente;

            //Cerramos la lectura
            lector.Close();
            conex.Close();
        }

        public DataTable getEspecies()
        {

            DataTable dtEspecies = new DataTable();

            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = @"SELECT id, especie 
                                FROM Especies";

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            //guardamos el nombre y el valor de las especies para evitar errores
            sqlDataAdapter.Fill(dtEspecies);

            //Retornamos especie
            return dtEspecies;
        }
        public DataTable getInfoEspecies()
        {

            DataTable dtEspeciesInfo = new DataTable();

            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = @"SELECT especie 
                                FROM Especies";

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            //guardamos el nombre y el valor de las especies para evitar errores
            sqlDataAdapter.Fill(dtEspeciesInfo);

            //Retornamos especie
            return dtEspeciesInfo;
        }

        public void getLabelEspecie(string especieSeleccionada)
        {
            string edadMadurez = "";
            string pesoPromedio = "";
            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = @"SELECT edad_madurez, peso_promedio 
                                FROM Especies 
                                WHERE especie = '" + especieSeleccionada + "'";


            SqlDataReader lector = cmd.ExecuteReader();


            //cargamos los datos a los lbl
            if (lector.Read())
            {
                edadMadurez = lector["edad_madurez"].ToString() + " años";
                pesoPromedio = lector["peso_promedio"].ToString() + "kg";
            }
            EdadMadurez = edadMadurez;
            PesoPromedio = pesoPromedio;

            lector.Close();
        }
        public List<Animal> getAllAnimales(int id_cliente)
        {
            List<Animal> listaResultado = new List<Animal>();


            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = @"SELECT id, nombre, edad, peso, Cliente_ID, Especies_ID 
                                FROM Animales 
                                WHERE Cliente_ID = '" + id_cliente + "'";


            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {

                Animal animal = new Animal();


                animal.id = lector.GetInt32(0);
                animal.nombre = lector.GetString(1);
                animal.edad = lector.GetInt32(2);
                animal.peso = lector.GetDecimal(3);
                animal.Cliente_ID = lector.GetInt32(4);
                animal.Especie_ID = lector.GetInt32(5);
                if (animal.Especie_ID == 1)
                {
                    animal.especie = "Gato";
                }
                if (animal.Especie_ID == 2)
                {
                    animal.especie = "Perro";
                }
                if (animal.Especie_ID == 3)
                {
                    animal.especie = "Conejo";
                }

                listaResultado.Add(animal);
            }


            conex.Close();

            return listaResultado;

        }

        public void AgregarMascota(string nombreMascota, decimal pesoMascota, int edadMascota, int cliente_ID, int especie_ID)
        {
            //si no encontro nada, continua el codigo

            string sQuery = @"INSERT INTO Animales (nombre, peso, edad, Cliente_ID, Especies_ID) 
                              VALUES ('" + nombreMascota + "' " +
                              "," + " '" + pesoMascota + "' " +
                              "," + " '" + edadMascota + "' " +
                              "," + " '" + cliente_ID + "' " +
                              "," + " '" + especie_ID + "' )";

            SqlConnection conex = this.GetConexion();
            SqlCommand cmd = conex.CreateCommand();
            cmd.CommandText = sQuery;

            //Ejecutamos el Query, para insertar en la tabla el cmd
            cmd.ExecuteNonQuery();

            //mensaje de registro exitoso
            MessageBox.Show("Registro exitoso!");

            conex.Close();

        }

        public List<CantAnimalesXCliente> CantidadAnimalesXCliente()
        {
            List<CantAnimalesXCliente> listaResultado = new List<CantAnimalesXCliente>();

            string sQuery = @"SELECT Clientes.nombre_cliente, 
                            COUNT(Animales.id) AS CantXClient
                            FROM Animales
                            JOIN Clientes ON Animales.Cliente_ID = Clientes.id
                            GROUP BY Clientes.nombre_cliente
                            ORDER BY CantXClient ASC";

            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = sQuery;


            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                CantAnimalesXCliente cant = new CantAnimalesXCliente();

                cant.nombre = lector.GetString(0);
                cant.cantidad = lector.GetInt32(1);

                listaResultado.Add(cant);
            }


            conex.Close();

            return listaResultado;

        }

        public List<PesoDeEspecies> ReportesPesoMinMaxAVG(int edadMin, int edadMax)
        {
            List<PesoDeEspecies> listaResultado = new List<PesoDeEspecies>();

            string sQuery = @"SELECT e.especie, 
                              MIN(a.peso) AS PesoMinimo, 
                              MAX(a.peso) AS PesoMaximo, 
                              AVG(a.peso) AS PesoPromedio
                              FROM Animales a
                              JOIN Especies e ON a.Especies_ID = e.id
                              WHERE a.edad BETWEEN '" + edadMin +
                              "' AND ' " + edadMax +
                              "' GROUP BY e.especie";

            SqlConnection conex = this.GetConexion();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandText = sQuery;


            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                PesoDeEspecies peso = new PesoDeEspecies();

                peso.especie = lector.GetString(0);
                peso.pesoMin = lector.GetDecimal(1);
                peso.pesoMax = lector.GetDecimal(2);
                peso.pesoAVG = lector.GetDecimal(3);
                peso.pesoAVG = Math.Round(peso.pesoAVG, 2);

                listaResultado.Add(peso);
            }


            conex.Close();

            return listaResultado;

        }
    }
}
