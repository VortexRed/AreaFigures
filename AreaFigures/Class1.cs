using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AreaFigures
{
    public class Figures
    {
        //Перегруженный метод если тип фигуры неизвестен
        public double Area(int r) => Math.PI * (r * r);
        public double Area(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        //Метод который возврощает true когда треугольник прямоугольный
        public bool RightTriangle(int a, int b, int c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) return true;
            else return false;

        }
        //Метод для поиска площади треугольника
        public double AreaTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        //Метод для поска площади круна
        public double AreaCircle(int r) => Math.PI * (r * r);
    }
}