using System;

namespace Scacchi.Modello.Pezzi {
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore)
        {
            this.colore = colore;    
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo)
        {
            int distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza);
            int distanzaTraLeColonne = Math.Abs((int) colonnaArrivo - (int) colonnaPartenza);
            
            // ^ XOR
            return (distanzaTraLeTraverse == 2 && distanzaTraLeColonne == 1) ^ 
                   (distanzaTraLeColonne == 2 && distanzaTraLeTraverse == 1);
        }
    }
}