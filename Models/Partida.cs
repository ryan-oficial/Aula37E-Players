using System;

namespace Aula37E_Players.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }
        public int IdJogador1 { get; set; }
        public int IdJogador2 { get; set; }
        public DateTime Horario { get; set; }
    }
}