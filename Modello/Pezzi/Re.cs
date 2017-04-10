using System;

namespace Scacchi.Modello.Pezzi {
    public class Re : IPezzo
    {
        private readonly Colore colore;
        public Re(Colore colore)
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
            return (distanzaTraLeTraverse == 0 || distanzaTraLeTraverse == 1) &&
                   (distanzaTraLeColonne == 0 || distanzaTraLeColonne == 1); 
        }
    }
}