public interface Carta
{
    //defino los metodos
    string Cartasas();
    string metodo();
}

public class mensaje : Carta
{
    //creo la carta con el mensahe
    public string Cartasas()
    {
        return "Gracias por tu apoyo y comprensión. Estoy deseando continuar nuestra colaboración.\n";
    }
    public string metodo()
    {
        return "";
    }
}
public abstract class CartaMetodo : Carta
{
    //Protejo la carta
    protected Carta Metodo; 
    //Creo la base de la carta 
    public CartaMetodo(Carta Cartasa)
    {
        this.Metodo = Cartasa;
    }
    public virtual string Cartasas()
    {
        return Metodo.Cartasas();
    }
    public virtual string metodo()
    {
        return Metodo.metodo();
    }
}
public class MensajeEncriptado : CartaMetodo
{    
    //creo la una variable que tiene la carta
    public MensajeEncriptado(Carta Cartasa) : base(Cartasa) { }
    //esto retornara cada vez que los llame
    public override string Cartasas()
    {
        return base.Cartasas() + "";
    }
    public override string metodo()
    {
        return "No se puede leer la carta,carta encriptada\n";
    }

}
public class ComprimirMensaje : CartaMetodo
{
    public ComprimirMensaje(Carta Cartasa) : base(Cartasa) { }
    //esto retornara cada vez que los llame
    public override string Cartasas()
    {
        return base.Cartasas() + "";
    }
    public override string metodo()
    {
        return "La carta pesa lo suficiente para leer en cualquier dispositivo\n";
    }

}
public class FirmarMensaje : CartaMetodo
{
    public FirmarMensaje(Carta Cartasa) : base(Cartasa) { }
    //esto retornara cada vez que los llame
    public override string Cartasas()
    {
        return base.Cartasas() + "";
    }
    public override string metodo()
    {
        return "Firmada por Juan Martinez";
    }

}
class program
{
    public static void Main(string[] args)
    {
        //aqui creo una carta
        Carta carta = new mensaje();
        //las llamo
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());

        carta = new MensajeEncriptado(carta);
        Console.WriteLine(carta.metodo());


        carta = new ComprimirMensaje(carta);
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());


        carta = new FirmarMensaje(carta);
        Console.WriteLine(carta.Cartasas() + "" + carta.metodo());
    }
}