using UNIDAD_03_ENTIDADES;


namespace EJERCICIO_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listVacunasMasc1 = new List<string>(); 
            Mascota masc1 = new Mascota("DOGGO", new DateTime(2010, 11, 19), Especie.Perro, listVacunasMasc1);
            List<Mascota> mascotas1 = new List<Mascota>();
            mascotas1.Add(masc1);
            Clientes clientes = new Clientes("FORMOSA 2716", "MARIANO", "NARA", "1134225678", mascotas1);


            List<string> listVacunasMasc2 = new List<string>();
            listVacunasMasc2.Add("TRIPLE FELINA");
            Mascota masc2 = new Mascota("MICHI", new DateTime(2016, 09, 21), Especie.Felino, listVacunasMasc2);
            List<Mascota> mascotas2 = new List<Mascota>();
            mascotas2.Add(masc2);
            Clientes cliente2 = new Clientes("RUCCI 891", "ROCIO", "BESSIO", "1138225232", mascotas2);

            List<string> listVacunasMasc3 = new List<string>();
            listVacunasMasc3.Add("RABIA");
            Mascota masc3 = new Mascota("MARGA", new DateTime(2011, 05, 13), Especie.Felino, listVacunasMasc1);
            Mascota masc4 = new Mascota("ROCKY", new DateTime(2013, 10, 23), Especie.Perro, listVacunasMasc3);
            List<Mascota> mascotas3 = new List<Mascota>();
            mascotas3.Add(masc3);
            mascotas3.Add(masc4);
            Clientes cliente3 = new Clientes("PERON 4321", "CLAUDIA", "HERRERP", "1198347782", mascotas3);

            List<Clientes> listaClientes = new List<Clientes>();
            listaClientes.Add(clientes);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);

            Veterinaria veterinaria = new Veterinaria(5,listaClientes);

            Console.WriteLine(veterinaria.Mostrar());
        }
    }
}