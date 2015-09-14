using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Personaje
    {
        private string clase="", arma1="", arma2="";
        private int daño1, daño2, dañoesp1, dañoesp2, fight=1;

        public void Seleccionar()
        {
            int opcion;
            try
            {
                Console.WriteLine("Tipo de personaje:");
                Console.WriteLine("1.- GUERRERO ");
                Console.WriteLine("2.- MAGO");
                Console.WriteLine("3.- ELFO");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        this.clase = "Guerrero";
                        break;
                    case 2:
                        this.clase = "Mago";
                        break;
                    case 3:
                        this.clase = "Elfo";
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        Seleccionar();
                        break;
                }
            }
            catch(FormatException){
                Console.WriteLine("Opcion Invalida");
                Seleccionar();
            }
            
        }

        public void Armaprincipal() {
            int opcion;
            try { 
            Console.WriteLine("Elige tu arma principal");
            Console.WriteLine("1.- Espada   ATK (6)     SP.ATK (15)");
            Console.WriteLine("2.- Hacha   ATK (9)     SP.ATK (13)");
            Console.WriteLine("3.- Cetro mágico ATK (4)     SP.ATK  (18)");
            Console.WriteLine("4.- Vara mágica ATK (2)     SP.ATK  (20)");
            Console.WriteLine("5.- Arco ATK (9)     SP.ATK  (12)");
            Console.WriteLine("6.- Daga ATK (10)     SP.ATK  (11)");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    this.arma1 = "Espada";
                    this.daño1 = 6;
                    this.dañoesp1 = 15;
                    break;
                case 2:
                    this.arma1 = "Hacha";
                    this.daño1 = 9;
                    this.dañoesp1= 13;
                    break;
                case 3:
                    this.arma1 = "Cetro mágico";
                    this.daño1 = 4;
                    this.dañoesp1= 18;
                    break;
                case 4:
                    this.arma1 = "Vara mágica";
                    this.daño1 = 2;
                    this.dañoesp1= 20;
                    break;
                case 5:
                    this.arma1 = "Arco";
                    this.daño1 = 9;
                    this.dañoesp1= 12;
                    break;
                case 6:
                    this.arma1 = "Daga";
                    this.daño1 = 10;
                    this.dañoesp1= 11;
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    Armaprincipal();
                    break;
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion Invalida");
                Armaprincipal();
            }
        }
        public void Armasecundaria()
        {
            try { 
            int opcion;
            Console.WriteLine("Elige tu arma secundaria");
            Console.WriteLine("1.- Espada   ATK (6)     SP.ATK (15)");
            Console.WriteLine("2.- Hacha   ATK (9)     SP.ATK (13)");
            Console.WriteLine("3.- Cetro mágico ATK (4)     SP.ATK  (18)");
            Console.WriteLine("4.- Vara mágica ATK (2)     SP.ATK  (20)");
            Console.WriteLine("5.- Arco ATK (9)     SP.ATK  (12)");
            Console.WriteLine("6.- Daga ATK (10)     SP.ATK  (11)");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    this.arma2 = "Espada";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 6;
                        this.dañoesp2 = 15;
                    }
                    break;
                    
                case 2:
                    this.arma2 = "Hacha";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 9;
                        this.dañoesp2 = 13;
                    }
                    break;
       
                case 3:
                    this.arma2 = "Cetro mágico";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 4;
                        this.dañoesp2 = 18;
                    }
                    break;
                case 4:
                    this.arma2 = "Vara mágica";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 2;
                        this.dañoesp2 = 20;
                    }
                    break;
                case 5:
                    this.arma2 = "Arco";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 9;
                        this.dañoesp2 = 12;
                    }
                    break;
                case 6:
                    this.arma2 = "Daga";
                    if (this.arma2.Equals(this.arma1))
                    {
                        Console.WriteLine("Selecciona un arma distinta a la que ya tienes");
                        Armasecundaria();
                    }
                    else
                    {
                        this.daño2 = 10;
                        this.dañoesp2 = 11;
                    }
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    Armasecundaria();
                    break;
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion Invalida");
                Armasecundaria();
            }
        }
        public void Pelear()
        {
            try { 
            while (fight == 1) {
                int opcion;
                Console.WriteLine("¿Qué vas a hacer?");
                Console.WriteLine("1.- Atacar con {0}", arma1);
                Console.WriteLine("2.- Atacar con {0}", arma2);
                Console.WriteLine("3.- Rendirse");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AtaquePrincipal();
                        break;
                    case 2:
                        AtaqueSecundario();
                        break;
                    case 3:
                        Rendirse();
                        break;
                    
                    default:
                        Console.WriteLine("Opcion Invalida");
                        Pelear();
                        break;
                }

            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion Invalida");
                Pelear();
            }
        }

        public void AtaquePrincipal()
        {
            try { 
            int opcion;
            Console.WriteLine("¿Tipo de Ataque?");
            Console.WriteLine("1.- Ataque Normal");
            Console.WriteLine("2.- Ataque Especial");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El {0} ha atacado normalmente con su {1} al árbol",this.clase,this.arma1);
                    Console.WriteLine("Ha hecho un daño de {0}, sin embargo el árbol no ha sentido ni cosquillas...", this.daño1);
                    break;
                case 2:
                    Console.WriteLine("El {0} ha atacado especialmente con su {1} al árbol", this.clase, this.arma1);
                    Console.WriteLine("Ha hecho un daño incrementado de {0}, pero el árbol tan sólo se ríe...", this.dañoesp1);
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    AtaquePrincipal();
                    break;
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion Invalida");
                AtaquePrincipal();
            }
        }

        public void AtaqueSecundario()
        {
            try { 
            int opcion;
            Console.WriteLine("¿Tipo de Ataque?");
            Console.WriteLine("1.- Ataque Normal");
            Console.WriteLine("2.- Ataque Especial");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("El {0} ha atacado normalmente con su {1} al árbol", this.clase, this.arma2);
                    Console.WriteLine("Ha hecho un daño de {0}, sin embargo el árbol no ha sentido ni cosquillas...", this.daño2);
                    break;
                case 2:
                    Console.WriteLine("El {0} ha atacado especialmente con su {1} al árbol", this.clase, this.arma2);
                    Console.WriteLine("Ha hecho un daño incrementado de {0}, pero el árbol tan sólo se ríe...", this.dañoesp2);
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    AtaqueSecundario();
                    break;
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Opcion Invalida");
                AtaqueSecundario();
            }
        }

        public void Rendirse() {
            Console.WriteLine("El {0} ha caído rendido al suelo, mientras el árbol lo observa con superioridad", this.clase);
            Console.WriteLine("¡FIN DE LA PELEA!");
            this.fight = 0;
        }

        public void Imprimir()
        {
            Console.WriteLine("El {0} ha encontrado un árbol enemigo... ¡A PELEAR!",this.clase);
        
        }
        static void Main(string[] args)
        {
            Personaje per = new Personaje();
            per.Seleccionar();
            per.Armaprincipal();
            per.Armasecundaria();
            per.Imprimir();
            per.Pelear();
            Console.ReadKey();
        }
    }
}
