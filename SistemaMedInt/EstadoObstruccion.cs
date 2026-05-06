using System;

namespace SistemaMedInt
{
    public class EstadoObstruccion : EstadoBase
    {
        public override void ResolverFalla(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [+] El personal médico ha resuelto la obstrucción. Reanudando el goteo seguro...");
            contexto.SetEstado(new EstadoProceso());
        }
    }
}