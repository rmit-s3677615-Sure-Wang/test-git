using System;
using System.Collections.Generic;
using System.Text;

namespace day04
{
    class Ticket
    {
        private double _distance;
        private double _price;

        public Ticket(double distance) {
            if (distance < 0)
            {
                distance = 0; 
            }
            // 初始化时，只能将值直接给字段，因为没有set方法
            this._distance = distance;
        }
        public double Distance
        {
            get { return _distance; }
        }

        public double Price
        {
            get {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance >= 101 && _distance < 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance >= 201 && _distance < 300)
                {
                    return _distance * 0.9;
                }
                else 
                {
                    return _distance * 0.8;
                } 
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine("distance:{0} /n price:{1}", Distance, Price);
        }
 
    }
}
