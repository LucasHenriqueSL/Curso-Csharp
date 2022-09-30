using System;
using System.Collections.Generic;
using System.Text;
using Atividade_metodosabastratos.Entities;
using Atividade_metodosabastratos.Entities.Enums;

namespace Atividade_metodosabastratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
