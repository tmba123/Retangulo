var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





Rectangulo r = new Rectangulo();
Rectangulo r1 = new Rectangulo(10.0, 25.0);
Rectangulo r2 = new Rectangulo("20 40");




app.MapGet("/", () => "Perimetro: " + r1.getPerimetro() + " Área: " + r1.getArea());
app.Run();



class Rectangulo
{
    //Atributos da classe
    //Criação de 4 atributos privados da classe Rectangulo
    double lado1;
    double lado2;
    double area;
    double perimetro;



    //Polimorfismo - Várias formas
    //É um dos 4 pilares da POO e permite criar métodos com o mesmo nome mas parametros diferentes.
    //Não podemos ter dois métodos com o mesmo e o mesmo de tipo de parametros

    public Rectangulo()
    {
        this.lado1 = 10.0;
        this.lado2 = 20.0;
    }




    public Rectangulo(double lado1, double lado2)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
    }



    //" 10.0 20.0"
    public Rectangulo(String dados)
    {
        String[] separado = dados.Split(' ');
        Console.WriteLine(separado[0]);
        this.lado1 = Double.Parse(separado[0]);
        this.lado2 = Double.Parse(separado[1]);



    }



    public void calcularArea()
    {
        this.area = this.lado1 * this.lado2;
    }



    public void calcularPerimetro()
    {
        this.perimetro = this.lado1 * 2 + this.lado2 * 2;
    }



    public double getPerimetro()
    {
        calcularPerimetro();
        return this.perimetro;
    }



    public double getArea()
    {
        calcularArea();
        return this.area;
    }
}


