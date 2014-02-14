using System;

public class DataSingleton
{
    // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    //Variables
    private int secondLeft;
    private int secondRight;

 
    // Constructor privado para evitar la instanciación directa
    private DataSingleton()
    {
    }
 
    // Propiedad para acceder a la instancia
    public static Singleton Instance
    {
        get
        {
            return instance.Value;
        }
    }


}
