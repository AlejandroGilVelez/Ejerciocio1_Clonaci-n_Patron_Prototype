using Ejerciocio1_Clonación_Patron_Prototype.Entities;

namespace Ejerciocio1_Clonación_Patron_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear héroes originales
            Guerrero guerreroOriginal = new Guerrero
            {
                Nombre = "Ares",
                Apariencia = "Con armadura dorada",                
                AccionHabilidad = new Dictionary<string, int>
                {
                        { "Leer Mapas", 20 },
                        { "Rastrear salud", 20 }
                },
                Habilidades = new Habilidades
                {
                    Ataque = 20,
                    Defensa = 20,
                    Magia = 20,
                    Experiencia = 20
                }
            };

            Mago magoOriginal = new Mago
            {
                Nombre = "Merlín",
                Apariencia = "Con túnica azul",
                Habilidades = new Habilidades
                {
                    Ataque = 10,
                    Defensa = 10,
                    Magia = 10,
                    Experiencia = 10
                }
            };

            Arquero arqueroOriginal = new Arquero
            {
                Nombre = "Robin",
                Apariencia = "Con capucha verde",
                Habilidades = new Habilidades
                {
                    Ataque = 5,
                    Defensa = 5,
                    Magia = 5,
                    Experiencia = 5
                }
            };

            // Clonar héroes
            Guerrero guerreroClonado = (Guerrero)guerreroOriginal.Clone();
            guerreroClonado.Nombre = "Ares Clonado";
            guerreroClonado.Apariencia = "Con armadura plateada";
            guerreroClonado.Nivel = 2;
            guerreroClonado.Habilidades.Ataque = 98;
            guerreroClonado.Habilidades.Defensa = 99;
            guerreroClonado.AccionHabilidad.Add("Ataque Con Espada", 100);
            guerreroClonado.AccionHabilidad.Add("Defiende Con Escudo", 100);


            Mago magoClonado = (Mago)magoOriginal.Clone();
            magoClonado.Nombre = "Merlín Clonado";
            magoClonado.Apariencia = "Con túnica roja";
            magoClonado.Habilidades.Ataque = 80;
            magoClonado.Habilidades.Magia = 99;
            magoClonado.AccionHabilidad.Add("Ataque Con Barita", 100);
            magoClonado.AccionHabilidad.Add("Ataque Con Polvos", 70);

            Arquero arqueroClonado = (Arquero)arqueroOriginal.Clone();
            arqueroClonado.Nombre = "Robin Clonado";
            arqueroClonado.Apariencia = "Con capucha negra";
            arqueroClonado.Habilidades.Ataque = 90;
            arqueroClonado.Habilidades.Defensa = 92;
            arqueroClonado.AccionHabilidad.Add("Ataque Con Arco", 100);
            arqueroClonado.AccionHabilidad.Add("Ataque Con Flecha", 80);

            // Mostrar información
            guerreroOriginal.MostrarInfo();
            guerreroClonado.MostrarInfo();

            magoOriginal.MostrarInfo();
            magoClonado.MostrarInfo();

            arqueroOriginal.MostrarInfo();
            arqueroClonado.MostrarInfo();
        }
    }
}
