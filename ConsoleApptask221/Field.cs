﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask221
{
    public abstract class Field
    {
        protected int _valueX; // Переменная для хранения X
        protected int _valueY; // Переменная для хранения Y
        public Field(int valueX, int valueY)
        {
            _valueX = valueX;
            _valueY = valueY;
        }

        protected int Width = 20; //ширина поля
        protected int Height = 10; //высота поля

        public int PositionX
        {
            get
            {
                return _valueX;
            }
        }

        public int PositionY 
        { 
            get 
            {
                return _valueY;
            } 
        }
    }
}
