using System;

namespace SistemaMedInt
{
    public abstract class EstadoBase
    {
        // error por defecto 
        public virtual void IniciarGoteo(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: No se puede iniciar el goteo en este estado.");
        }

        public virtual void DetectarFalla(SistemaMedicamento contexto)
        {
            Console.WriteLine("[X] Acción denegada: No hay ninguna falla que detectar en este momento.");
        }

        public virtual void ResolverFalla(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: No hay ninguna obstrucción para resolver.");
        }

        public virtual void DosisCompletada(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: La dosis no se está administrando actualmente.");
        }

        public virtual void Reiniciar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: No se puede reiniciar la máquina en este momento.");
        }

        public virtual void Pausar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: No se puede pausar en este estado.");
        }

        public virtual void Reanudar(SistemaMedicamento contexto)
        {
            Console.WriteLine(" [X] Acción denegada: El sistema no está pausado.");
        }
    }
    
}