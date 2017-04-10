using System;

namespace Scacchi.Modello.Pezzi {
    public class Pedone : IPezzo
    {
        private readonly Colore colore;
        public Pedone(Colore colore)
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
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var traversaIniziale = false;
            var distanzaTraLeTraverse = 0;


            if (this.colore == Colore.Bianco)
            {
                traversaIniziale = (traversaPartenza == Traversa.Seconda) ? true : false;
                distanzaTraLeTraverse = (int) traversaArrivo - (int) traversaPartenza;
            }
            else
            {
                traversaIniziale = (traversaPartenza == Traversa.Settima) ? true : false;
                distanzaTraLeTraverse = - ((int) traversaArrivo - (int) traversaPartenza);
            }

            if (stessaColonna && (distanzaTraLeTraverse == 1 || (traversaIniziale == true && distanzaTraLeTraverse == 2))){
                return true;
            } else {
                return false;
            }

        }
    }
}