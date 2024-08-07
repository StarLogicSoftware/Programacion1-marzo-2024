﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    public class Sala
    {
        // Constructor de la clase
        // sirve para inicializar un objeto. Se ejecuta una sola vez al instanciar
        //  (hacer un new) de la clase
        public Sala(int capacidad, string nombre)
        {
            Reservas = new List<Curso>();

            NombreSala = nombre;
            Capacidad = capacidad;
        }

        public string NombreSala;
        public int Capacidad;
        public List<Curso> Reservas;

        public void AgregarReserva(Curso cursoAReservar)
        {
            Reservas.Add(cursoAReservar);
        }

        public bool RemoverReserva(string nombreCurso)
        {
            //var cursoAEliminar = Reservas.Find(c => c.Nombre == nombreCurso);
            // Busca un curso donde en su nombre contenga algo del texto pasado en nombreCurso
            var cursoAEliminar = Reservas.Find(c => c.Nombre.Contains(nombreCurso));

            if(cursoAEliminar != null)
            {
                Reservas.Remove(cursoAEliminar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarReservas()
        {
            if(Reservas.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var curso in Reservas)
                {
                    Console.WriteLine($"Curso: {curso.Nombre}, instructor: {curso.Instructor}" +
                        $" horas cursado: {curso.DuracionHoras}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("No hay reservas para esta sala");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public int ObtenerTotalHorasReservadas()
        {
            int totalHoras = 0;

            foreach (var curso in Reservas)
            {
                totalHoras += curso.DuracionHoras;
            }

            return totalHoras;
        }

        public List<Curso> ObtenerCursosPorInstructor(string nombreInstructor)
        {
            var cursosSegunInstructor = Reservas.FindAll(c => c.Instructor == nombreInstructor);

            return cursosSegunInstructor;

            return Reservas.FindAll(c => c.Instructor == nombreInstructor); // lo mismo
        }
    }
}
