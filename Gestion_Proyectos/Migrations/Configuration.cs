namespace Gestion_Proyectos.Migrations
{
    using Gestion_Proyectos.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gestion_Proyectos.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Gestion_Proyectos.Models.ApplicationDbContext context)
        {
            context.Proyectos.AddOrUpdate(p => p.Nombre,
                new Proyecto
                {
                    Nombre = "App Tareas",
                    Descripcion = "Desarrollo de una aplicación móvil para la gestión de tareas.",
                    FechInicio = new DateTime(2024, 1, 15),
                    FechFin = new DateTime(2024, 7, 15)
                },
                new Proyecto
                {
                    Nombre = "CMS Personalizado",
                    Descripcion = "Implementación de un CMS personalizado para una empresa de medios digitales.",
                    FechInicio = new DateTime(2024, 2, 1),
                    FechFin = new DateTime(2024, 8, 30)
                },
                new Proyecto
                {
                    Nombre = "Web Store",
                    Descripcion = "Desarrollo de una tienda en línea para una empresa de comercio electrónico.",
                    FechInicio = new DateTime(2024, 3, 10),
                    FechFin = new DateTime(2024, 9, 30)
                },
                new Proyecto
                {
                    Nombre = "Sistema Inventarios",
                    Descripcion = "Creación de un sistema de gestión de inventarios para una cadena de supermercados.",
                    FechInicio = new DateTime(2024, 4, 5),
                    FechFin = new DateTime(2024, 10, 15)
                },
                new Proyecto
                {
                    Nombre = "Plataforma Educativa",
                    Descripcion = "Desarrollo de una plataforma en línea para la educación a distancia.",
                    FechInicio = new DateTime(2024, 5, 20),
                    FechFin = new DateTime(2024, 11, 30)
                },
                new Proyecto
                {
                    Nombre = "App Salud",
                    Descripcion = "Diseño de una aplicación móvil para el monitoreo de la salud y el bienestar.",
                    FechInicio = new DateTime(2024, 6, 8),
                    FechFin = new DateTime(2024, 12, 20)
                },
                new Proyecto
                {
                    Nombre = "Gestor Documentos",
                    Descripcion = "Implementación de un sistema de gestión de documentos para una empresa legal.",
                    FechInicio = new DateTime(2024, 7, 15),
                    FechFin = new DateTime(2025, 1, 31)
                },
                new Proyecto
                {
                    Nombre = "Red Social",
                    Descripcion = "Desarrollo de una red social para conectar a personas de intereses comunes.",
                    FechInicio = new DateTime(2024, 8, 3),
                    FechFin = new DateTime(2025, 2, 28)
                },
                new Proyecto
                {
                    Nombre = "App Finanzas",
                    Descripcion = "Creación de una aplicación móvil para la gestión de finanzas personales.",
                    FechInicio = new DateTime(2024, 9, 18),
                    FechFin = new DateTime(2025, 3, 15)
                },
                new Proyecto
                {
                    Nombre = "Sistema Reservas",
                    Descripcion = "Desarrollo de un sistema de reservas en línea para una cadena hotelera.",
                    FechInicio = new DateTime(2024, 10, 12),
                    FechFin = new DateTime(2025, 4, 30)
                }
            );
        }
    }
}
