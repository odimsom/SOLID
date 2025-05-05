using SOLID.Entitys.OCP.Country;
using SOLID.Entitys.OCP.Interfaces;
using SOLID.Entitys.OCP;
using SOLID.Entitys.SRP;
using System.Runtime;

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

        //Implementatiton OCP
        var taxCalculator = new TaxCalculator(new ITaxStrategy[]
        {
            new IndiaTaxStrategy(),
            new USATaxStrategy(),
            new UKTaxStrategy()
        });

        decimal impuesto = taxCalculator.Calculate(60000, 10000, "India");
        Console.WriteLine($"Impuesto calculado: {impuesto:C}");
    }
}
