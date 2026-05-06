using System;

namespace SistemaMedInt
{
    public class SistemaMedicamento
    {
        private EstadoBase _estadoActual;

        public SistemaMedicamento()
        {
            // siempre se inicia en preparacion
            _estadoActual = new EstadoPreparacion();
            Console.WriteLine($" [INFO] La máquina ha iniciado en el estado: [{_estadoActual.GetType().Name}]");
        }

        public void SetEstado(EstadoBase nuevoEstado)
        {
            _estadoActual = nuevoEstado;
            Console.WriteLine($"\n ---> CAMBIO DE ESTADO: La bomba ahora está en [{nuevoEstado.GetType().Name}] <--- \n");
        }

        // metodos que dejan las llamadas al estado actual
        public void IniciarGoteo() => _estadoActual.IniciarGoteo(this);
        public void DetectarFalla() => _estadoActual.DetectarFalla(this);
        public void ResolverFalla() => _estadoActual.ResolverFalla(this);
        public void DosisCompletada() => _estadoActual.DosisCompletada(this);
        public void Reiniciar() => _estadoActual.Reiniciar(this);
        public void Pausar() => _estadoActual.Pausar(this);
        public void Reanudar() => _estadoActual.Reanudar(this);
    }
}