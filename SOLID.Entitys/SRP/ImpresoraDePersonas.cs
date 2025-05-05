namespace SOLID.Entitys.SRP
{
    public class ImpresoraDePersonas
    {
        public void Imprimir(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
        }
    }

}
