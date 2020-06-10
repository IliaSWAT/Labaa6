using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    interface IMove
    {
        void Move();
    }
    interface IStop
    {
        void Stop();
    }
    interface IOverclockingTo100
    {
        void OverclockingTo100();
    }
    abstract class Car : IMove, IStop, IOverclockingTo100
    {
        protected string model; //стандартные поля для всех машин
        protected double cost;
        protected double gasoline_per_kilometer;
        protected double weight, length, width, height, max_speed, time_to_100;
        protected double min_speed = 0;

        public abstract double TimeTo100 { set; get; }
        public abstract double Cost { set; get; }
        public abstract double GasolinePerKilometer { set; get; }
        public abstract double Weight { set; get; }
        public abstract double Length { set; get; }
        public abstract double Width { set; get; }
        public abstract double Height { set; get; }
        public abstract double MaxSpeed { set; get; }
        public abstract double MinSpeed { get; }
        public abstract string Model { set; get; }
        public abstract string Mark { get; }
        public abstract void Move();
        public abstract void Stop();
        public abstract void OverclockingTo100();

    }

    class Audi : Car
    {
        private string mark = "AUDI";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }

        public Audi(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой AUDI с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой AUDI с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой AUDI разгоняется до сотки за {0} секунд", time_to_100);
        }
    }
    class Sedan : Car
    {
        private string mark = "Sedan";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Sedan(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.time_to_100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Sedan с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Sedan с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Sedan разгоняется до сотки за {0} секунд", time_to_100);
        }
    }

    class Suv : Car
    {
        private string mark = "Suv";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Suv(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Suv с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Suv с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Suv разгоняется до сотки за {0} секунд", time_to_100);
        }
    }
    class Coupe : Car
    {
        private string mark = "Coupe";
        public override string Mark { get { return mark; } }
        public override double TimeTo100 // свойство для записи
        {
            set
            {
                if (value > 0)
                {
                    time_to_100 = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return time_to_100;
            }
        }
        public override double Cost
        {
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return cost;
            }
        }

        public override double GasolinePerKilometer
        {
            set
            {
                if (value > 0)
                {
                    gasoline_per_kilometer = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return gasoline_per_kilometer;
            }
        }

        public override double Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return weight;
            }
        }

        public override double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return length;
            }
        }

        public override double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return width;
            }
        }

        public override double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return height;
            }
        }

        public override double MaxSpeed
        {
            set
            {
                if (value > 0)
                {
                    max_speed = value;
                }
                else
                    throw new Exception("Исключение");
            }
            get
            {
                return max_speed;
            }
        }
        public override double MinSpeed { get { return min_speed; } }
        public override string Model { set { model = value; } get { return model; } }
        public Coupe(double cost, double gasoline_per_kilometer, double weight, double length, double width, double height, double max_speed, string model, double time_to_100)
        {
            this.Cost = cost;
            this.GasolinePerKilometer = gasoline_per_kilometer;
            this.Weight = weight;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.MaxSpeed = max_speed;
            this.Model = model;
            this.TimeTo100 = time_to_100;
        }
        public override void Move()
        {
            Console.WriteLine("Едет машина с маркой Coupe с моделью {0}", model);
        }
        public override void Stop()
        {
            Console.WriteLine("Останавливается машина с маркой Coupe с моделью {0}", model);
        }
        public override void OverclockingTo100()
        {
            Console.WriteLine("Машина с маркой Coupe разгоняется до сотки за {0} секунд", time_to_100);
        }
    }
    class CompareGasoline : IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            if (c1.GasolinePerKilometer > c2.GasolinePerKilometer)
            {
                return 1;
            }
            else if (c1.GasolinePerKilometer < c2.GasolinePerKilometer)
            {
                return -1;
            }
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double cost_taks = 0;

            Audi[] allroad_audi = new Audi[4]; // массив марки Ауди модели "Allroad"
            for (int i = 0; i < allroad_audi.Length; i++)
            {
                allroad_audi[i] = new Audi(1000, 20, 40, 4.3, 1.5, 1.9, 130, "Allroad", 7.5);
            }

            Audi[] e_tron_audi = new Audi[4];// массив марки Ауди модели "e-tron"
            for (int i = 0; i < e_tron_audi.Length; i++)
            {
                e_tron_audi[i] = new Audi(2350, 34, 37.8, 4.6, 1.8, 2, 160, "e-tron", 5.4);
            }

            Sedan[] A1_sedan = new Sedan[4]; // массив марки Седан модели "А1"
            for (int i = 0; i < A1_sedan.Length; i++)
            {
                A1_sedan[i] = new Sedan(3120, 43.8, 44.1, 5.1, 1.9, 2.5, 210, "A1", 4.2);
            }

            Suv[] Q1_suv = new Suv[4]; //массив марки Сув модели "Q1"
            for (int i = 0; i < Q1_suv.Length; i++)
            {
                Q1_suv[i] = new Suv(3400, 35.8, 39.7, 5, 3, 4, 250, "Q1", 8.4);
            }

            Coupe[] T1_coupe = new Coupe[4]; // массив марки Коуп модели "T1"
            for (int i = 0; i < T1_coupe.Length; i++)
            {
                T1_coupe[i] = new Coupe(4327, 54.6, 54, 6, 3.4, 2.3, 180, "T1", 7.8);
            }

            ArrayList help_list = new ArrayList();//это просто божественное решение, я аж сам в a*уе
            help_list.AddRange(allroad_audi);
            help_list.AddRange(e_tron_audi);
            help_list.AddRange(A1_sedan);
            help_list.AddRange(Q1_suv);
            help_list.AddRange(T1_coupe);

            Car[] taks_park = new Car[help_list.Count];//а это я вообще когда придумал чуть со стула не упал...
            for (int i = 0; i < help_list.Count; i++)
            {
                taks_park[i] = (Car)help_list[i];//А ИМЕННО ВОТ ЭТА СТРОЧКА
            }
            for (int i = 0; i < taks_park.Length; i++)
            {
                cost_taks += taks_park[i].Cost;
            }

            Array.Sort(taks_park, new CompareGasoline());

            Console.WriteLine("Сортировка по бензину, не стал заморачиваться над красотой вывода");
            for (int i = 0; i < taks_park.Length; i++)
            {
                Console.WriteLine("model = {0}, mark = {1}, gasoline per kilometr = {2}", taks_park[i].Model, taks_park[i].Mark, taks_park[i].GasolinePerKilometer);
            }

            Console.WriteLine("Цена автопарка - {0}", cost_taks);
            Console.WriteLine("Вам еще диапазон надо ввести для скорости, минимальное и максимальное значение скорости:");

            int max_value = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите максимальное значение:");
                    max_value = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Сложно ввести число?");
                    continue;
                }
            }

            for (int i = 0; i < taks_park.Length; i++)
            {
                if (taks_park[i].MaxSpeed <= max_value)
                {
                    Console.WriteLine("model - {0}, mark - {1}, maxSpeed - {2}", taks_park[i].Model, taks_park[i].Mark, taks_park[i].MaxSpeed); ;
                }
            }
            Console.ReadKey();
        }
    }
}
