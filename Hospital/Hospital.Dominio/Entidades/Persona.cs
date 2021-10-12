namespace Hospital.Dominio.Entidades
{
    public class Persona
    {
        public int Id {get; set;} //ID lo reconoce como Primary Key
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
    }
}