using System;

namespace SistemaMedInt
{
    public class EstadoProceso : EstadoBase
    {
        public override void DetectarFalla(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [!] ALARMA: ¡Burbuja o doblez en la manguera detectado! Deteniendo bomba por seguridad...");
            contexto.SetEstado(new EstadoObstruccion());
        }

        public override void DosisCompletada(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [+] El paciente ha recibido la dosis completa satisfactoriamente.");
            contexto.SetEstado(new EstadoTerminado());
        }
        
        public override void Pausar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [ii] PAUSA: Goteo detenido temporalmente por el paciente/personal médico.");
            contexto.SetEstado(new EstadoPausa());
        }
    }
}