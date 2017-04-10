using System;

namespace Scacchi.Modello.Pezzi {
    public class Donna : IPezzo
    {
        private readonly Colore colore;
        public Donna(Colore colore)
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
            bool stessaColonna = colonnaPartenza == colonnaArrivo;
            bool stessaTraversa = traversaPartenza == traversaArrivo;

            int distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza);
            int distanzaTraLeColonne = Math.Abs((int) colonnaArrivo - (int) colonnaPartenza);
            
            // ^ XOR
            return  (stessaColonna || stessaTraversa) ^ (distanzaTraLeTraverse == distanzaTraLeColonne);
        }
    }
}