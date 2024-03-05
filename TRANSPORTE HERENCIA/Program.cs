// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using TRANSPORTE_HERENCIA;

Console.WriteLine("EJERCICIO TRANSPORTE");
Console.WriteLine();


Double costo, tiempo, distancia, costo_total, ResultadoMultiplicacion;
string Destino, Tipo_transporte, Compañia, Corredor, Linea;

Bus_interurbano bus_interurbano = new Bus_interurbano();
Console.WriteLine("Ingrese datos del bus_interurbano:");
Console.Write("costo: ");
bus_interurbano.Costo = Convert.ToDouble(Console.ReadLine());
Console.Write("destino: ");
bus_interurbano.Destino = Console.ReadLine();
Console.Write("distancia: ");
bus_interurbano.Compañia = Console.ReadLine();

Console.WriteLine();

Taxi taxi = new Taxi();
Console.WriteLine("Ingrese datos del taxi:");
Console.Write("distancia: ");
taxi.Distancia = Convert.ToDouble(Console.ReadLine());
Console.Write("tiempo: ");
taxi.Tiempo = Convert.ToDouble(Console.ReadLine());
costo_total = taxi.operar();
Console.Write("destino: ");
taxi.Destino = Console.ReadLine();
ResultadoMultiplicacion = taxi.operar();


Console.WriteLine();

Bus_urbano bus_urbano = new Bus_urbano();
Console.WriteLine("Ingrese datos del bus_urbano:");
Console.Write("costo: ");
bus_urbano.Costo = Convert.ToDouble(Console.ReadLine());
Console.Write("corredor: ");
bus_urbano.Corredor = Console.ReadLine();
Console.WriteLine();

Metro metro = new Metro();
Console.WriteLine("Ingrese datos del metro:");
Console.Write("costo: ");
metro.Costo = Convert.ToDouble(Console.ReadLine());
Console.Write("comapañia: ");
metro.Compañia = Console.ReadLine();
Console.Write("linea: ");
metro.Linea = Console.ReadLine();

Console.WriteLine("metro:");



Console.WriteLine();

Teleferico teleferico = new Teleferico();
Console.WriteLine("Ingrese datos del teleferico:");
Console.Write("costo: ");
teleferico.Costo = Convert.ToDouble(Console.ReadLine());
Console.Write("compañia: ");
teleferico.Compañia = Console.ReadLine();
Console.Write("distancia: ");
teleferico.Linea = Console.ReadLine();



Console.WriteLine();


Console.WriteLine("Datos del taxi:");

Console.WriteLine("El destino es: " + taxi.Destino);
Console.WriteLine($"la duracion del viaje es de:   {taxi.Tiempo} horas");
Console.WriteLine($"La distancia son:   {taxi.Distancia} kilometros");
Console.WriteLine($"El costo del boleto del taxi es :  {ResultadoMultiplicacion}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("bus_interurbano:");

Console.WriteLine("El costo es: " + bus_interurbano.Costo);
Console.WriteLine($"El destino: " + bus_interurbano.Destino);
Console.WriteLine($"La compañia es:" + bus_interurbano.Compañia);
Console.WriteLine();

Console.WriteLine("bus_urbano:");
Console.WriteLine("El costo es: " + bus_urbano.Costo);
Console.WriteLine($"El corredor es: " + bus_urbano.Corredor);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("metro:");

Console.WriteLine("El costo es: " + metro.Costo);
Console.WriteLine($"La compañia es: " + metro.Compañia);
Console.WriteLine($"La linea es: " + metro.Linea);


Console.WriteLine();
Console.WriteLine("teleferico:");
Console.WriteLine("El costo es: " + teleferico.Costo);
Console.WriteLine($"La compañia es: " + teleferico.Compañia); ;
Console.WriteLine($"La linea es: " + teleferico.Linea);











