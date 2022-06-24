using System;
class animal{
    string nombre{get;set;}
    string color{get;set;}

    public animal(string nombre, string color){
        this.nombre=nombre;
        this.color=color;
    }

    public void imprimir(){
        Console.WriteLine("--------------------");
        Console.WriteLine("Nombre:"+ nombre);
        Console.WriteLine("Color:"+ color);

        }

    public void nada(){
        Console.WriteLine("Nada");
    }    

    public void volar(){
        Console.WriteLine("vuela");
    }
}