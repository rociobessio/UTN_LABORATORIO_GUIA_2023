namespace ENTIDADES_ARCHIVOS
{
    public static class Archivo_Explicacion
    {
        static string ruta;

        /// <summary>
        /// La ruta siempre sera el escritorio.
        /// Cada vez que se incializa ya tengo la ruta
        /// </summary>
        static Archivo_Explicacion()
        {
            //-->Ruta absoluta la escritorio 
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"/Archivos";
        }

        /// <summary>
        /// Metodo estatico que me permite ESCRIBIR EN UN
        /// ARCHIVO DE TEXTO.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static void Escribir()
        {

            //-->Me para en el ejecutable del proyecto
            // string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory; 

            string completa = ruta + @"/Archivo.txt";//-->Barra si o si y @ tambien.

            //->Lo creo en el escritorio,
            //StreamWriter lo escribe,
            //si existe lo pisa y sino lo crea
            //-->Le paso la ruta y su nombre
            //StreamWriter streamWriter = new StreamWriter(completa);

            //--> El using es un bloque d codigo que dentro declaro objetos,
            // al salir del using se borra, solo se reconoce dentro del scope del using
            //--> No es necesario cerrar el archivo.
            try
            {
                if (!Directory.Exists(ruta))//-->Pregunto si NO existe la ruta
                {
                    Directory.CreateDirectory(ruta);//-->Si no existe la creo
                }
                using (StreamWriter streamWriter = new StreamWriter(completa,true))//-->Si existe hace append con el true
                {
                    streamWriter.WriteLine("Estoy");
                    streamWriter.WriteLine("En Laboratorio");
                    streamWriter.WriteLine("2");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            //-->Escribo linea por linea.
            //streamWriter.WriteLine("Estoy");
            //streamWriter.WriteLine("En Laboratorio");
            //streamWriter.WriteLine("2");

            //-->Cierro el archivo
            //streamWriter.Close();
        }



        public static string Leer()
        {   
            //--> El using es un bloque d codigo que dentro declaro objetos,
            // al salir del using se borra, solo se reconoce dentro del scope del using
            //--> No es necesario cerrar el archivo.
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))//-->Si existe lo leo
                {
                    using (StreamReader streamReader = new StreamReader(ruta + @"/Archivo.txt"))
                    {
                        string line;

                        datos = streamReader.ReadToEnd();//-->Leo todo de una, no es necesario el while

                        //while ((line = streamReader.ReadLine()) != null)//-->Leo mientras no sea null
                        //{
                        //    datos += "\n" + line;
                        //}
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            } 
        }
    }
}