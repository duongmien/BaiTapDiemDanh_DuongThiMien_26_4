using System;

namespace KiemTraGiuaKy_DuongThiMien
{
    class PTB2
    {
        private double a_234;
        private double b_234;
        private double c_234;

        public PTB2(double a_234, double b_234, double c_234)
        {
            A_234 = a_234;
            B_234 = b_234;
            C_234 = c_234;
        }

        protected double A_234 { get => a_234; set => a_234 = value; }
        protected double B_234 { get => b_234; set => b_234 = value; }
        protected double C_234 { get => c_234; set => c_234 = value; }
        public double delta()
        {
            return b_234 * b_234 - 4 * a_234 * c_234;
        }
        public void result()
        {
            double dt_234 = delta();
            if (dt_234 < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                if (dt_234 == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: x1=x2="+(- b_234 / 2 * a_234));
                }
                else
                {
                    double x1_234 = -b_234 + Math.Sqrt(dt_234) / 2 * a_234;
                    double x2_234 = -b_234 - Math.Sqrt(dt_234) / 2 * a_234;
                    Console.WriteLine("Phuong trinh co hai nghiem");
                    Console.WriteLine("Nghiem x1: x1= " + x1_234);
                    Console.WriteLine("Nghiem x2: x2= " + x2_234);
                }
            }
        }
    }
    class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 tham so cho phuong trinh bac 2");
            Console.Write("a: ");
            double a_234 = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b_234 = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c_234 = double.Parse(Console.ReadLine());
            PTB2 ptb2 = new PTB2(a_234, b_234, c_234);
            ptb2.result();
        }
    }
}
