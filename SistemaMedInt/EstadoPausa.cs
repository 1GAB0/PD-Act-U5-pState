using System;

namespace SistemaMedInt
{
    public class EstadoPausa : EstadoBase
    {
        public override void Reanudar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [+] REANUDANDO: El goteo de medicamento continúa su curso...");
            contexto.SetEstado(new EstadoProceso());
        }
    }
}