using System;

namespace Aula1_exemplo{

    class Calculadora{
        public String Nome {get; set;}

        public double v1 {get; private set;}
        public double v2 {get; private set;}

        public Calculadora(double v1=0, double v2=0)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public double Somar(){
            return this.v1 + this.v2;
        }

        public double Subtrair(){
            return this.v1 - this.v2;
        }

        public double Multiplicar(){
            return this.v1 * this.v2;
        }
        public double Dividir(){
            return this.v1 / this.v2;
        }

        public double DividirResto(){
            return this.v1 % this.v2;
        }
    }
}