using System;

namespace BaiTap
{
        class trungAnh
        {
            static void Main(String[] args)
            {
                //bai 1

                // float pi = 3.14f;
                // double S, V;

                // Console.Write("Ban kinh R(m) = ");
                // float R = Convert.ToSingle(Console.ReadLine());

                // S = 4*pi*R*R;
                // V = (4/3)*pi*R*R*R;

                // Console.WriteLine("Dien tich cua mat cau la: " + S + " m");
                // Console.WriteLine("The tich mat cau la: " + V + " m^3");
                //---------------------------------------------------------------//

                //Bai 2

                // Console.WriteLine("Nhap toa do diem A");
                // Console.Write("xA = ");
                // int xA = Convert.ToInt32(Console.ReadLine());
                // Console.Write("yA = ");
                // int yA = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Nhap toa do diem B");
                // Console.Write("xB = ");
                // int xB = Convert.ToInt32(Console.ReadLine());
                // Console.Write("yB = ");
                // int yB = Convert.ToInt32(Console.ReadLine());

                // double AB ;

                // AB = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA));
                // Console.WriteLine("Khoang cach AB la: " + AB);
                //----------------------------------------------------------//

                //Bai 3
                Console.WriteLine("Nhap toa do tam C");
                Console.Write("xC = ");
                int xC = Convert.ToInt32(Console.ReadLine());
                Console.Write("yC = ");
                int yC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ban kinh R = ");
                float R = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Nhap toa do tam M");
                Console.Write("xM = ");
                int xM = Convert.ToInt32(Console.ReadLine());
                Console.Write("yM = ");
                int yM = Convert.ToInt32(Console.ReadLine());

                double d;

                d = Math.Sqrt((xM-xC)*(xM-xC) + (yM-yC)*(yM-yC));
                
                if (d<R)
                    Console.WriteLine("Diem M nam trong duong tron!!");
                else if(d>R)
                    Console.WriteLine("Diem M nam ngoai duong tron!!");
                    else 
                    Console.WriteLine("Trung voi duong tron nhe!!");
            }
        }
}
