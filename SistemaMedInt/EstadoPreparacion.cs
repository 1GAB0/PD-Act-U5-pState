using System;

namespace SistemaMedInt
{
    public class EstadoPreparacion : EstadoBase
    {
        public override void IniciarGoteo(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [+] Preparación exitosa. Iniciando el bombeo de medicamento al paciente...");
            contexto.SetEstado(new EstadoProceso());
        }
    }
}