namespace Ejerciocio1_Clonación_Patron_Prototype.Entities
{
    public abstract class Heroe : ICloneable
    {
        public string Nombre { get; set; } = string.Empty;
        public int Nivel { get; set; }
        public int PuntosDeHabilidad { get; set; }
        public string Apariencia { get; set; } = string.Empty;  // Características visuales del héroe

        public Dictionary<string, int> AccionHabilidad { get; set; } = [];

        public Habilidades Habilidades { get; set; } = new Habilidades(); // Clase que representa las habilidades del héroe

        // Método para clonar el héroe
        public object Clone()
        {
            Heroe clon = (Heroe)MemberwiseClone(); // Clonación superficial
            clon.Habilidades = (Habilidades)this.Habilidades.Clone(); // Clonación profunda de habilidades
            return clon;
        }

        public abstract void MostrarInfo();
    }
}
