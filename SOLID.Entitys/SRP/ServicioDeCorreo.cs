namespace SOLID.Entitys.SRP
{
    public class ServicioDeCorreo
    {
        public void EnviarCorreo(Persona persona, string mensaje)
        {
            Console.WriteLine($"Enviando correo a {persona.CorreoElectronico} con el mensaje: {mensaje}");
            // Aquí iría la lógica real de envío
        }
    }

}
