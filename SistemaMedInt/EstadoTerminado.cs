using System;

namespace SistemaMedInt
{
    public class EstadoTerminado : EstadoBase
    {
        public override void Reiniciar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [+] Vía desconectada. Reiniciando el sistema para el próximo paciente...");
            contexto.SetEstado(new EstadoPreparacion());
        }
    }
}