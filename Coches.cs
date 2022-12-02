/***
 * 
 * @author Jordi Matorrales
 * 
 */



class Coches
{
    private static int _velocidad { get; set; }
    private static string _marca { get; set; }
    private static string _matricula { get; set; }
    private static string _color {get; set;}
    private static bool _estaParado { get; set; }
    private static int _orientacion { get; set;} // 0- arriba, 1- derecha, 2- izquierda

    public Coches(int velocidad, string marca, string matricula, string color, int orientacion)
    {
        _velocidad = velocidad;
        _marca = marca;
        _matricula = matricula;
        _color = color;
        _estaParado = false;
        _orientacion = orientacion;
    }
    public void acelerar(int velocidad)
    {
        _velocidad += velocidad;
    }
    public void frenar(int velocidad)
    {
        _velocidad -= velocidad;
        if (_velocidad <= 0) 
        {
            _velocidad = 0;
            _estaParado = true;
        }
    }
    public void girar(int posicion)
    {
        _orientacion = posicion;
    }

}