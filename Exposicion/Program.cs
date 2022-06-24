using System;
namespace EXPOSICION{
    class program{
        static void Main(string []args){

            pato Pato=new pato("Lucas", "Amarillo");
            Pato.imprimir();
            Pato.nada();
            Pato.volar();

            pinguino Pinguino=new pinguino("Pepe", "Blanco");
            Pinguino.imprimir();
            Pinguino.nada();

        }
    }
}

