using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PezziTest
    {

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiDueCaseInizio()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Quarta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiDueCaseInizio()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Settima,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Quinta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorrePuoMoversiInVerticale()
        {
            //Given
            Torre torre = new Torre(Colore.Nero);
            //When
            bool esito = torre.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Prima);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorrePuoMoversiInOrizzontale()
        {
            //Given
            Torre torre = new Torre(Colore.Nero);
            //When
            bool esito = torre.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.H,
                    traversaArrivo: Traversa.Ottava);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LalfierePuoMuovereInDiagonale()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Nero);
            //When
            bool esito = alfiere.PuòMuovere(
                    colonnaPartenza: Colonna.C,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.H,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaDonnaPuoMuovereInVerticale()
        {
            //Given
            Donna donna = new Donna(Colore.Nero);
            //When
            bool esito = donna.PuòMuovere(
                    colonnaPartenza: Colonna.D,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.D,
                    traversaArrivo: Traversa.Prima);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaDonnaPuoMuovereInOrizzontale()
        {
            //Given
            Donna donna = new Donna(Colore.Nero);
            //When
            bool esito = donna.PuòMuovere(
                    colonnaPartenza: Colonna.D,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Ottava);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaDonnaPuoMuovereInDiagonale()
        {
            //Given
            Donna donna = new Donna(Colore.Nero);
            //When
            bool esito = donna.PuòMuovere(
                    colonnaPartenza: Colonna.D,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.H,
                    traversaArrivo: Traversa.Quarta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlCavalloPuoMuovereAdElle()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                    colonnaPartenza: Colonna.B,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.C,
                    traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlRePuoMuovereInVerticaleDiUnaCasa()
        {
            //Given
            Re re = new Re(Colore.Nero);
            //When
            bool esito = re.PuòMuovere(
                    colonnaPartenza: Colonna.E,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.E,
                    traversaArrivo: Traversa.Settima);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlRePuoMuovereInOrizzontaleDiUnaCasa()
        {
            //Given
            Re re = new Re(Colore.Nero);
            //When
            bool esito = re.PuòMuovere(
                    colonnaPartenza: Colonna.E,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.F,
                    traversaArrivo: Traversa.Ottava);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlRePuoMuovereInDiagonaleDiUnaCasa()
        {
            //Given
            Re re = new Re(Colore.Nero);
            //When
            bool esito = re.PuòMuovere(
                    colonnaPartenza: Colonna.E,
                    traversaPartenza: Traversa.Ottava,
                    colonnaArrivo: Colonna.F,
                    traversaArrivo: Traversa.Settima);

            //Then
            Assert.True(esito);
        }

    }

}