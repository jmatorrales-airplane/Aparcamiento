using System;
/***
 * 
 * @author Jordi Matorrales
 * 
 */
class Aparcamiento
{
    public static void Main(string[] args)
    {
        var misCoches = new Dictionary<int, Coche>()
        {
            { 1, new Coche() {Velocidad = 10, Marca = "Mercedes", Matricula = "1234X", Color = "Rojo", EstaParado=false, Orientacion=1 }},
            { 2, new Coche() {Velocidad = 8, Marca = "Volvo", Matricula = "6389Y", Color = "Verde", EstaParado=false, Orientacion=0 }}
        };

        //foreach (var index in Enumerable.Range(1, 2))
        //{
        //    Console.WriteLine($"Coche {index} is {misCoches[index].Marca} {misCoches[index].Color}");
        //}

        //for(int i = 1; i< misCoches.Count+1; i++)
        //{
        //    Console.WriteLine(misCoches[i].Marca);
        //}

        for(int i=0; i<misCoches.Count; i++)
        {
         //   Console.WriteLine(misCoches.Keys.ElementAt(i));
            misCoches.Keys.ElementAt(i);
            var listaCoches = misCoches.Keys.ElementAt(i);

        }



        //Console.WriteLine(misCoches[1].Color);

        //if (misCoches.TryGetValue(1, out var resultado))
        //{
        //    Console.WriteLine(resultado);
        //    Console.WriteLine(misCoches.ContainsKey(1));

        //}

    }
    class Coche
    {
        public int Velocidad { get; set; }
        public string Marca { get; set; }
        public string Matricula { get; set; }
        public string Color { get; set; }
        public bool EstaParado { get; set; }
        public int Orientacion { get; set; } // 0- arriba, 1- derecha, 2- izquierda

        public void acelerar(int velocidad)
        {
            Velocidad += velocidad;
        }
        public void frenar(int velocidad)
        {
            Velocidad -= velocidad;
            if (Velocidad <= 0)
            {
                Velocidad = 0;
                EstaParado = true;
            }
        }
        public void girar(int posicion)
        {
            Orientacion = posicion;
        }
    }
}


