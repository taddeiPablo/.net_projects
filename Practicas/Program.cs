using System;
using Practicas.Singleton;
using Practicas.Factory;
using Practicas.Factory.Interface;
using Practicas.AbstractFactory;
using Practicas.AbstractFactory.Interface;
using Practicas.Prototype;
using Practicas.Prototype.Interface;
using Practicas.Facade;
using Practicas.Facade.fachada;
using Practicas.Decorator;
using Practicas.Decorator.figuras;
using Practicas.Decorator.Interfaces;
using Practicas.Proxy.model;
using Practicas.Proxy.proxies;
using Practicas.Command.commands;
using Practicas.Memento.mementos;
using Practicas.Observer;
using Practicas.Strategy;
using Practicas.Dao.DaoImplements;
using Practicas.Dao.Interface;
using Practicas.Dao.Model;
using Practicas.Dao.conexiones;
namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TODOS LOS EJEMPLOS DE PATRONES
            /*Console.WriteLine("primer ejemplo de patron ( SINGLETON )");
// aqui en vez de realizar un new lo que hacemos es llamar a este metodo de clase 
// getInstance para obtener nuestra instancia. Esto lo podemos realizar muchas veces y siempre 
// recibiremos la misma instancia creada en la primer llamada inicial
ConexionSingleton conexion = ConexionSingleton.getInstance();
Console.WriteLine(conexion.mensage());
Console.ReadLine();
Console.Clear();
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("segundo ejemplo de patron ( FACTORY )");
// aqui vamos a utilizar este segundo ejemplo de patron FACTORY
FactoryConexiones fconexiones = new FactoryConexiones();
IConexiones SqlConn = fconexiones.getConexion("sql");
Console.WriteLine(SqlConn.Conectar());
Console.WriteLine(SqlConn.Desconectar());
IConexiones MysqlConn = fconexiones.getConexion("mysql");
Console.WriteLine(MysqlConn.Conectar());
Console.WriteLine(MysqlConn.Desconectar());
IConexiones definirConn = fconexiones.getConexion("");
Console.WriteLine(definirConn.Conectar());
Console.WriteLine(definirConn.Desconectar());
Console.ReadLine();
Console.Clear();
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("tercer ejemplo de patron ( FACTORY ABSTRACT)");
FabricaProducto fProducto = new FabricaProducto();
IAbstractFactory abstractFac = fProducto.getFactory("shape");
IShape circle = abstractFac.getShape("circle");
circle.draw();
IShape rectangle = abstractFac.getShape("rectangle");
rectangle.draw();
IShape square = abstractFac.getShape("square");
square.draw();
Console.ReadLine();
Console.Clear();
Console.WriteLine("----------------------------------------------------------------------------");
FabricaProducto fabricaProducto2 = new FabricaProducto();
IAbstractFactory abstractFactory2 = fabricaProducto2.getFactory("color");
IColor red = abstractFactory2.getColor("red");
red.fill();
IColor green = abstractFactory2.getColor("green");
green.fill();
IColor blue = abstractFactory2.getColor("blue");
blue.fill();
Console.ReadLine();
Console.Clear();
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("cuarto ejemplo de patron ( Prototype)");
CuentaAHImpl cuenta1 = new CuentaAHImpl();
cuenta1.Monto = 300;
Console.WriteLine("valores de esta cuenta original");
Console.WriteLine(cuenta1.Monto);
Console.WriteLine("ahora vamos a clonar esta cuenta");
CuentaAHImpl cuentaClone = (CuentaAHImpl)cuenta1.clonar();
if (cuentaClone != null)
{
    Console.WriteLine("se creo esta cuenta nueva clone de la cuenta1");
}
Console.WriteLine("COMPAREMOS LAS DOS CUENTAS");
Console.WriteLine(cuenta1.Monto);
Console.WriteLine(cuentaClone.Monto);
Console.ReadLine();
Console.Clear();
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("quinto ejemplo de patron ( FACADE)");
CheckFacade check1 = new CheckFacade();
CheckFacade check2 = new CheckFacade();
check1.buscar("1/1/2023", "2/2/2023","Buenos Aires", "Tokyo");
check2.buscar("1/1/2023", "2/2/2023", "Buenos Aires", "Tokyo");
Console.ReadLine();
Console.Clear();*/
            /*Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("sexto ejemplo de patron ( DECORATOR )");
            Circle nuevoCirculo = new Circle();
            Console.WriteLine("color del circulo al comienzo");
            nuevoCirculo.draw();
            RedShapeDecorator rsDecorator = new RedShapeDecorator(nuevoCirculo);
            Console.WriteLine("aqui aplicando nuevo color en nuestro circulo");
            rsDecorator.setNewColor("ROJO");
            Console.WriteLine("aqui color cambiado de nuestro circulo");
            rsDecorator.draw();
            Console.ReadLine();*/
            /*Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("septimo ejemplo de patron ( PROXY )");
            // crear una cuenta nueva
            Cuenta micuenta = new Cuenta(10000, "Pablo Taddei", 100);
            // generamos el proxy para las operaciones que se pueden realizar sobre esta cuenta
            CuentaProxy cproxy = new CuentaProxy();
            // aqui llamo al proxy y realizo un deposito de dinero
            micuenta = cproxy.depositarDinero(micuenta, 100);
            // aqui llamo al proxy y hago una extraccion de dinero
            micuenta = cproxy.retirardinero(micuenta, 50);
            // finalmente llamo al proxy para mostrar mi saldo actual
            cproxy.mostrarSaldo(micuenta);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("octavo ejemplo de patron ( COMMAND )");
            Command.commands.Cuenta micuenta = new Command.commands.Cuenta(200, 1);
            Command.commands.DepositarImpl opDepositar = new DepositarImpl(micuenta, 300);
            Command.commands.RetirarImpl opRetirar = new RetirarImpl(micuenta, 200);
            Command.commands.Invoker ivker = new Invoker();
            ivker.recibirOperaciones(opDepositar);
            ivker.recibirOperaciones(opRetirar);
            ivker.realizarOperaciones();*/
            #endregion

            #region MAS EJEMPLOS DE PATRONES IMPLEMENTADOS
            /*Juego mijuego = new Juego();
mijuego.Nombre = "jueguito";
mijuego.CheckPoint = 1;

CareTaker caretaker = new CareTaker();
Originator originator = new Originator();

Juego miJuego2 = new Juego();
miJuego2.Nombre = "jueguito";
miJuego2.CheckPoint = 2;
originator.Juego = miJuego2; // ya tiene un estado

Juego miJuego3 = new Juego();
miJuego3.Nombre = "jueguito";
miJuego3.CheckPoint = 3;
originator.Juego = miJuego3; // tiene otro estado

caretaker.addMemento(originator.guardar()); // GUARDANDO ESTADO

originator.Juego = miJuego3;
originator.restaurar(caretaker.getMemento(0));
Juego aux = originator.Juego;*/

            /*Subject subject = new Subject();

            new SolObservador(subject);
            new PesoArgObservador(subject);

            Console.WriteLine("convertidor de moneda esta app comvertira sus dolares a soles peruanos y pesos argentinos");
            int monto = Convert.ToInt32(Console.ReadLine());
            subject.Estado = monto;
            Console.ReadLine();*/
            #endregion

            /*Contexto context = new Contexto(new AntivirusSimple());
            context.ejecutar();*/

            // aqui instanciamos un objecto del tipo de la interface en este caso PersonaDaoImp
            // tambien para desacoplar mucho mas el codigo utilizamos la interface utilizando generics 
            // y de esa manera podemos determinar para que implementacion queremos utilizar
            // otro ejemplo de como realizar una injeccion de dependencias con el agregado de un desacople 
            // de codigo.
            Conexion conn = new Conexion("", "", "");
            ICRUD<Persona> dao = new PersonaDaoImp(conn);
            // aqui recorremos todos las personas en nuestra lista y aplicamos una expresion lambda
            dao.ListaTodos().ForEach(x => Console.WriteLine(x.Nombre));
        }
    }
}
