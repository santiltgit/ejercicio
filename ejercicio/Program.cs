using System;

namespace ejercicios
{
    //ejercicio#1

    //public class Persona
    //{
    //    private string _nombre;
    //    private int _edad;
    //    private string _documento;

    //    public string Nombre
    //    {
    //        get => _nombre;
    //        set => _nombre = value;
    //    }

    //    public int Edad
    //    {
    //        get => _edad;
    //        set
    //        {
    //            if (value < 0)
    //                throw new ArgumentException("La edad no puede ser negativa");
    //            _edad = value;
    //        }
    //    }

    //    public string Documento
    //    {
    //        get => _documento;
    //        set => _documento = value;
    //    }

    //    public void MostrarDatos()
    //    {
    //        Console.WriteLine($"Nombre: {Nombre}");
    //        Console.WriteLine($"Edad: {Edad}");
    //        Console.WriteLine($"Documento: {Documento}");
    //    }

    //    public bool EsMayorDeEdad()
    //    {
    //        return Edad >= 18;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Persona persona = new Persona();
    //            persona.Nombre = "Juan Pérez";
    //            persona.Edad = 25;
    //            persona.Documento = "12345678A";

    //            persona.MostrarDatos();
    //            Console.WriteLine($"¿Es mayor de edad? {persona.EsMayorDeEdad()}");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error: {ex.Message}");
    //        }
    //   }
    //}

    //ejercicio#2

    //public class CuentaBancaria
    //{
    //    private string _titular;
    //    private decimal _saldo;
    //    private string _numeroCuenta;

    //    public string Titular
    //    {
    //        get => _titular;
    //        set => _titular = value;
    //    }

    //    public decimal Saldo
    //    {
    //        get => _saldo;
    //        private set => _saldo = value;
    //    }

    //    public string NumeroCuenta
    //    {
    //        get => _numeroCuenta;
    //        set => _numeroCuenta = value;
    //    }

    //    public void Depositar(decimal cantidad)
    //    {
    //        if (cantidad <= 0)
    //            throw new ArgumentException("La cantidad a depositar debe ser positiva");

    //        Saldo += cantidad;
    //        Console.WriteLine($"Depósito exitoso: +{cantidad:C}");
    //    }

    //    public void Retirar(decimal cantidad)
    //    {
    //        if (cantidad <= 0)
    //            throw new ArgumentException("La cantidad a retirar debe ser positiva");

    //        if (Saldo - cantidad < 0)
    //            throw new InvalidOperationException("Saldo insuficiente para realizar el retiro");

    //        Saldo -= cantidad;
    //        Console.WriteLine($"Retiro exitoso: -{cantidad:C}");
    //    }

    //    public void MostrarSaldo()
    //    {
    //        Console.WriteLine($"Saldo actual: {Saldo:C}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            CuentaBancaria cuenta = new CuentaBancaria();
    //            cuenta.Titular = "María García";
    //            cuenta.NumeroCuenta = "ES9121000418450200051332";

    //            cuenta.Depositar(1000);
    //            cuenta.MostrarSaldo();

    //            cuenta.Retirar(300);
    //            cuenta.MostrarSaldo();

    //            cuenta.Depositar(500);
    //            cuenta.MostrarSaldo();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Error: {ex.Message}");
    //        }
    //    }
    //}

    //ejercicio#3

    //public class Vehiculo
    //{
    //    public string Marca { get; set; }
    //    public string Modelo { get; set; }
    //    public int Año { get; set; }
    //    public decimal Precio { get; set; }

    //    public virtual void MostrarInfo()
    //    {
    //        Console.WriteLine($"Marca: {Marca}");
    //        Console.WriteLine($"Modelo: {Modelo}");
    //        Console.WriteLine($"Año: {Año}");
    //        Console.WriteLine($"Precio: {Precio:C}");
    //    }
    //}

    //public class Automovil : Vehiculo
    //{
    //    public int CantidadPuertas { get; set; }

    //    public override void MostrarInfo()
    //    {
    //        base.MostrarInfo();
    //        Console.WriteLine($"Cantidad de Puertas: {CantidadPuertas}");
    //        Console.WriteLine("Tipo: Automóvil");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class Motocicleta : Vehiculo
    //{
    //    public int Cilindraje { get; set; }

    //    public override void MostrarInfo()
    //    {
    //        base.MostrarInfo();
    //        Console.WriteLine($"Cilindraje: {Cilindraje}cc");
    //        Console.WriteLine("Tipo: Motocicleta");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Vehiculo[] vehiculos = new Vehiculo[3];

    //        vehiculos[0] = new Automovil
    //        {
    //            Marca = "Toyota",
    //            Modelo = "Corolla",
    //            Año = 2023,
    //            Precio = 25000,
    //            CantidadPuertas = 4
    //        };

    //        vehiculos[1] = new Motocicleta
    //        {
    //            Marca = "Honda",
    //            Modelo = "CBR600",
    //            Año = 2023,
    //            Precio = 12000,
    //            Cilindraje = 600
    //        };

    //        vehiculos[2] = new Automovil
    //        {
    //            Marca = "BMW",
    //            Modelo = "X5",
    //            Año = 2023,
    //            Precio = 65000,
    //            CantidadPuertas = 5
    //        };

    //        foreach (var vehiculo in vehiculos)
    //        {
    //            vehiculo.MostrarInfo();
    //        }
    //    }
    //}

    //ejercicio#4

    //public class Producto
    //{
    //    public string Nombre { get; set; }
    //    public decimal Precio { get; set; }
    //    public int Stock { get; set; }

    //    public virtual decimal AplicarDescuento()
    //    {
    //        return Precio; // Sin descuento por defecto
    //    }

    //    public virtual void MostrarInfo()
    //    {
    //        Console.WriteLine($"Nombre: {Nombre}");
    //        Console.WriteLine($"Precio original: {Precio:C}");
    //        Console.WriteLine($"Precio con descuento: {AplicarDescuento():C}");
    //        Console.WriteLine($"Stock: {Stock}");
    //    }
    //}

    //public class Electronico : Producto
    //{
    //    public int GarantiaMeses { get; set; }

    //    public override decimal AplicarDescuento()
    //    {
    //        return Precio * 0.90m; // 10% de descuento
    //    }

    //    public override void MostrarInfo()
    //    {
    //        base.MostrarInfo();
    //        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
    //        Console.WriteLine("Tipo: Electrónico");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class Ropa : Producto
    //{
    //    public string Talla { get; set; }

    //    public override decimal AplicarDescuento()
    //    {
    //        return Precio * 0.80m; // 20% de descuento
    //    }

    //    public override void MostrarInfo()
    //    {
    //        base.MostrarInfo();
    //        Console.WriteLine($"Talla: {Talla}");
    //        Console.WriteLine("Tipo: Ropa");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Producto[] productos = new Producto[3];

    //        productos[0] = new Electronico
    //        {
    //            Nombre = "Smartphone",
    //            Precio = 500,
    //            Stock = 15,
    //            GarantiaMeses = 24
    //        };

    //        productos[1] = new Ropa
    //        {
    //            Nombre = "Camiseta",
    //            Precio = 25,
    //            Stock = 100,
    //            Talla = "M"
    //        };

    //        productos[2] = new Electronico
    //        {
    //            Nombre = "Laptop",
    //            Precio = 1200,
    //            Stock = 8,
    //            GarantiaMeses = 36
    //        };

    //        foreach (var producto in productos)
    //        {
    //            producto.MostrarInfo();
    //        }
    //    }
    //}

    //ejercicio#5

    //public class Empleado
    //{
    //    public string Nombre { get; set; }
    //    public decimal SalarioBase { get; set; }

    //    public virtual decimal CalcularSalario()
    //    {
    //        return SalarioBase;
    //    }

    //    public virtual void MostrarInformacion()
    //    {
    //        Console.WriteLine($"Nombre: {Nombre}");
    //        Console.WriteLine($"Salario Base: {SalarioBase:C}");
    //        Console.WriteLine($"Salario Total: {CalcularSalario():C}");
    //    }
    //}

    //public class EmpleadoTiempoCompleto : Empleado
    //{
    //    public override decimal CalcularSalario()
    //    {
    //        return SalarioBase; // Salario base sin cambios
    //    }

    //    public override void MostrarInformacion()
    //    {
    //        base.MostrarInformacion();
    //        Console.WriteLine("Tipo: Tiempo Completo");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class EmpleadoPorHoras : Empleado
    //{
    //    public int HorasTrabajadas { get; set; }

    //    public override decimal CalcularSalario()
    //    {
    //        return SalarioBase * HorasTrabajadas;
    //    }

    //    public override void MostrarInformacion()
    //    {
    //        base.MostrarInformacion();
    //        Console.WriteLine($"Horas Trabajadas: {HorasTrabajadas}");
    //        Console.WriteLine("Tipo: Por Horas");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Empleado[] empleados = new Empleado[3];

    //        empleados[0] = new EmpleadoTiempoCompleto
    //        {
    //            Nombre = "Carlos López",
    //            SalarioBase = 3000
    //        };

    //        empleados[1] = new EmpleadoPorHoras
    //        {
    //            Nombre = "Ana Martínez",
    //            SalarioBase = 20,
    //            HorasTrabajadas = 160
    //        };

    //        empleados[2] = new EmpleadoTiempoCompleto
    //        {
    //            Nombre = "Pedro Sánchez",
    //            SalarioBase = 3500
    //        };

    //        foreach (var empleado in empleados)
    //        {
    //            empleado.MostrarInformacion();
    //        }
    //    }
    //}

    //ejercicio#6

    //public class Factura
    //{
    //    public string NumeroFactura { get; set; }
    //    public string Cliente { get; set; }
    //    public decimal Total { get; set; }

    //    public virtual void GenerarFactura()
    //    {
    //        Console.WriteLine($"Factura: {NumeroFactura}");
    //        Console.WriteLine($"Cliente: {Cliente}");
    //        Console.WriteLine($"Total: {Total:C}");
    //    }
    //}

    //public class FacturaElectronica : Factura
    //{
    //    public override void GenerarFactura()
    //    {
    //        base.GenerarFactura();
    //        Console.WriteLine("Método: Factura enviada por correo electrónico");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class FacturaFisica : Factura
    //{
    //    public override void GenerarFactura()
    //    {
    //        base.GenerarFactura();
    //        Console.WriteLine("Método: Factura impresa");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Factura> facturas = new List<Factura>();

    //        facturas.Add(new FacturaElectronica
    //        {
    //            NumeroFactura = "FAC-001",
    //            Cliente = "Empresa ABC",
    //            Total = 1500
    //        });

    //        facturas.Add(new FacturaFisica
    //        {
    //            NumeroFactura = "FAC-002",
    //            Cliente = "Cliente Individual",
    //            Total = 250
    //        });

    //        facturas.Add(new FacturaElectronica
    //        {
    //            NumeroFactura = "FAC-003",
    //            Cliente = "Corporación XYZ",
    //            Total = 7500
    //        });

    //        foreach (var factura in facturas)
    //        {
    //            factura.GenerarFactura();
    //        }
    //    }
    //}

    //ejercicio#7

    //public class Publicacion
    //{
    //    public string Autor { get; set; }
    //    public string Contenido { get; set; }
    //    public DateTime FechaPublicacion { get; set; }

    //    public virtual void MostrarPublicacion()
    //    {
    //        Console.WriteLine($"Autor: {Autor}");
    //        Console.WriteLine($"Fecha: {FechaPublicacion:g}");
    //        Console.WriteLine($"Contenido: {Contenido}");
    //    }
    //}

    //public class PublicacionTexto : Publicacion
    //{
    //    public override void MostrarPublicacion()
    //    {
    //        base.MostrarPublicacion();
    //        Console.WriteLine("Tipo: Publicación de Texto");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class PublicacionImagen : Publicacion
    //{
    //    public string UrlImagen { get; set; }

    //    public override void MostrarPublicacion()
    //    {
    //        base.MostrarPublicacion();
    //        Console.WriteLine($"Imagen: {UrlImagen}");
    //        Console.WriteLine("Tipo: Publicación con Imagen");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //public class PublicacionVideo : Publicacion
    //{
    //    public string UrlVideo { get; set; }
    //    public TimeSpan Duracion { get; set; }

    //    public override void MostrarPublicacion()
    //    {
    //        base.MostrarPublicacion();
    //        Console.WriteLine($"Video: {UrlVideo}");
    //        Console.WriteLine($"Duración: {Duracion:mm\\:ss}");
    //        Console.WriteLine("Tipo: Publicación con Video");
    //        Console.WriteLine("-------------------");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Publicacion> publicaciones = new List<Publicacion>();

    //        publicaciones.Add(new PublicacionTexto
    //        {
    //            Autor = "Usuario1",
    //            Contenido = "Hola mundo, esta es mi primera publicación!",
    //            FechaPublicacion = DateTime.Now
    //        });

    //        publicaciones.Add(new PublicacionImagen
    //        {
    //            Autor = "Usuario2",
    //            Contenido = "Mira esta hermosa puesta de sol",
    //            FechaPublicacion = DateTime.Now.AddHours(-2),
    //            UrlImagen = "https://ejemplo.com/sunset.jpg"
    //        });

    //        publicaciones.Add(new PublicacionVideo
    //        {
    //            Autor = "Usuario3",
    //            Contenido = "Tutorial de programación en C#",
    //            FechaPublicacion = DateTime.Now.AddDays(-1),
    //            UrlVideo = "https://ejemplo.com/video.mp4",
    //            Duracion = TimeSpan.FromMinutes(15)
    //        });

    //        foreach (var publicacion in publicaciones)
    //        {
    //            publicacion.MostrarPublicacion();
    //        }
    //    }
    //}

    //ejercicio#8

    //public interface IReservable
    //{
    //    void Reservar();
    //    void CancelarReserva();
    //}

    //public class HabitacionHotel : IReservable
    //{
    //    public string NumeroHabitacion { get; set; }
    //    public string Tipo { get; set; }

    //    public void Reservar()
    //    {
    //        Console.WriteLine($"Habitación {NumeroHabitacion} ({Tipo}) reservada exitosamente.");
    //    }

    //    public void CancelarReserva()
    //    {
    //        Console.WriteLine($"Reserva de habitación {NumeroHabitacion} cancelada.");
    //    }
    //}

    //public class SalonEventos : IReservable
    //{
    //    public string NombreSalon { get; set; }
    //    public int Capacidad { get; set; }

    //    public void Reservar()
    //    {
    //        Console.WriteLine($"Salón {NombreSalon} (Capacidad: {Capacidad}) reservado para evento.");
    //    }

    //    public void CancelarReserva()
    //    {
    //        Console.WriteLine($"Reserva del salón {NombreSalon} cancelada.");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IReservable[] reservables = new IReservable[4];

    //        reservables[0] = new HabitacionHotel
    //        {
    //            NumeroHabitacion = "101",
    //            Tipo = "Individual"
    //        };

    //        reservables[1] = new HabitacionHotel
    //        {
    //            NumeroHabitacion = "205",
    //            Tipo = "Suite"
    //        };

    //        reservables[2] = new SalonEventos
    //        {
    //            NombreSalon = "Grand Ballroom",
    //            Capacidad = 200
    //        };

    //        reservables[3] = new SalonEventos
    //        {
    //            NombreSalon = "Sala de Conferencias",
    //            Capacidad = 50
    //        };

    //        // Realizar reservas
    //        foreach (var reservable in reservables)
    //        {
    //            reservable.Reservar();
    //        }

    //        Console.WriteLine("\n--- Cancelando algunas reservas ---\n");

    //        // Cancelar algunas reservas
    //        reservables[1].CancelarReserva();
    //        reservables[3].CancelarReserva();
    //    }
    //}
}