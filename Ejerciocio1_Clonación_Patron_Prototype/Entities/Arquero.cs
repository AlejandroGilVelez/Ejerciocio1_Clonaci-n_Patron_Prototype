namespace Ejerciocio1_Clonación_Patron_Prototype.Entities
{
    public class Arquero : Heroe
    {
        public Arquero()
        {
            Habilidades = new Habilidades { Ataque = 50, Defensa = 20, Magia = 15 };
            Nivel = 1;
            PuntosDeHabilidad = 0;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Arquero: {Nombre}, Nivel: {Nivel}, PH: {PuntosDeHabilidad}, Apariencia: {Apariencia}");
            Console.WriteLine($"Habilidades - Ataque: {Habilidades.Ataque}, Defensa: {Habilidades.Defensa}, Magia: {Habilidades.Magia}");
            Console.WriteLine($"Acción Habilidades son: {string.Join("- ", AccionHabilidad.Select(x => $"{x.Key} = {x.Value}"))}");
        }
    }
}
