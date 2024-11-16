namespace Ejerciocio1_Clonación_Patron_Prototype.Entities
{
    public class Mago : Heroe
    {
        public Mago()
        {
            Habilidades = new Habilidades { Ataque = 20, Defensa = 10, Magia = 80 };
            Nivel = 1;
            PuntosDeHabilidad = 0;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Mago: {Nombre}, Nivel: {Nivel}, PH: {PuntosDeHabilidad}, Apariencia: {Apariencia}");
            Console.WriteLine($"Habilidades - Ataque: {Habilidades.Ataque}, Defensa: {Habilidades.Defensa}, Magia: {Habilidades.Magia}");
            Console.WriteLine($"Acción Habilidades son: {string.Join("- ", AccionHabilidad.Select(x => $"{x.Key} = {x.Value}"))}");
        }
    }
}
