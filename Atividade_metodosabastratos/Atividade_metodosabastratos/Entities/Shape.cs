using System;
using System.Collections.Generic;
using System.Text;
using Atividade_metodosabastratos.Entities;
using Atividade_metodosabastratos.Entities.Enums;

namespace Atividade_metodosabastratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
