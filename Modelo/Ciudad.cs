namespace Modelo
{
    public class Ciudad
    {
        private string nombre;
        public int ID { get; set; }
        public string Nombre 
        {
            get { return nombre.ToUpper(); }
            set { if (!String.IsNullOrEmpty(value)) nombre = value; }
        } 
    }
}