using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_4
{
    public class Building
    {
        private static int _Id;

        private int _Height;

        private int _Floors;

        private int _Flats;

        private int _Entrance;

        public int Id
        {
            get
            {
                return _Id;
            }
        }
        public int Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение меньше или равно 0");
                }
                else
                {
                    _Height = value;
                }
            }
        }
        public int Floors
        {
            get
            {
                return _Floors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение меньше или равно 0");
                }
                else
                {
                    _Floors = value;
                }
            }
        }
        public int Flats
        {
            get
            {
                return _Flats;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение меньше или равно 0");
                }
                else if (value % _Entrance != 0)
                {
                    throw new Exception("Количество квартир должно быть кратным количеству подъездов");
                }
                else if (value / _Entrance < _Floors)
                {
                    throw new Exception("Количество квартир в подъезде меньше чем этажей");
                }
                else
                {
                    _Flats = value;
                }
            }
        }
        public int Entrance
        {
            get
            {
                return _Entrance;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение меньше или равно 0");
                }
                else
                {
                    _Entrance = value;
                }
            }
        }

        internal Building()
        {

        }


        /// <summary>
        /// Создает новый Id здания
        /// </summary>
        public static void IdCreator()
        {
            _Id += 1;
        }
        /// <summary>
        /// Возвращает последний созданный Id здания
        /// </summary>
        /// <returns></returns>
        public static int IdGetter()
        {
            return _Id;
        }

        public void HeightSetter(int Height)
        {
            if (Height <= 0)
            {
                throw new Exception("Значение меньше или равно 0");
            }
            else
            {
                _Height = Height;
            }

        }
        public int HeightGetter()
        {
            return _Height;
        }
        public void FloorsSetter(int Floors)
        {
            if (Floors <= 0)
            {
                throw new Exception("Значение меньше или равно 0");
            }
            else
            {
                _Floors = Floors;
            }
        }
        public int FloorsGetter()
        {
            return _Floors;
        }
        public void FlatsSetter(int Flats)
        {
            if (Flats <= 0)
            {
                throw new Exception("Значение меньше или равно 0");
            }
            else if (Flats % _Entrance != 0)
            {
                throw new Exception("Количество квартир должно быть кратным количеству подъездов");
            }
            else if (Flats / _Entrance < _Floors)
            {
                throw new Exception("Количество квартир в подъезде меньше чем этажей");
            }
            else
            {
                _Flats = Flats;
            }
        }
        public int FlatsGetter()
        {
            return _Flats;
        }
        public void EntranceSetter(int Entrance)
        {
            if (Entrance <= 0)
            {
                throw new Exception("Значение меньше или равно 0");
            }
            else
            {
                _Entrance = Entrance;
            }
        }
        public int EntranceGetter()
        {
            return _Entrance;
        }

        public float FloorHeingt()
        {
            return _Height / _Floors;
        }
        public int FlatsInEntrance()
        {
            return _Flats / _Entrance;
        }
        public int FlatsInFloor()
        {
            return FlatsInEntrance() / _Floors;
        }
    }
}
