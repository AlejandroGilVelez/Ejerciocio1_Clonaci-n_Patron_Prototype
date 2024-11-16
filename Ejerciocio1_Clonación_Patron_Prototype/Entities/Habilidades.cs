namespace Ejerciocio1_Clonación_Patron_Prototype.Entities
{
    public class Habilidades : ICloneable
    {
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int Magia { get; set; }
        public int Experiencia { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
