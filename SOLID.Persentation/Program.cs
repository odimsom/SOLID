using SOLID.Entitys.SRP;

class Program
{
    static void Main()
    {
        //Implementacion del SRP
        var persona = new Persona
        {
            Nombre = "Carlos",
            Edad = 30,
            Direccion = "Calle Principal 123",
            CorreoElectronico = "carlos@example.com"
        };

        var impresora = new ImpresoraDePersonas();
        var servicioCorreo = new ServicioDeCorreo();

        impresora.Imprimir(persona);
        servicioCorreo.EnviarCorreo(persona, "Hola Carlos, este es un mensaje de prueba.");
    }
}
