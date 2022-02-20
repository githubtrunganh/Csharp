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
                // Console.WriteLine("Nhap toa do tam C");
                // Console.Write("xC = ");
                // int xC = Convert.ToInt32(Console.ReadLine());
                // Console.Write("yC = ");
                // int yC = Convert.ToInt32(Console.ReadLine());
                // Console.Write("Ban kinh R = ");
                // float R = Convert.ToSingle(Console.ReadLine());
                // Console.WriteLine("Nhap toa do tam M");
                // Console.Write("xM = ");
                // int xM = Convert.ToInt32(Console.ReadLine());
                // Console.Write("yM = ");
                // int yM = Convert.ToInt32(Console.ReadLine());

                // double d;

                // d = Math.Sqrt((xM-xC)*(xM-xC) + (yM-yC)*(yM-yC));
                
                // if (d<R)
                //     Console.WriteLine("Diem M nam trong duong tron!!");
                // else if(d>R)
                //     Console.WriteLine("Diem M nam ngoai duong tron!!");
                //     else 
                //     Console.WriteLine("Trung voi duong tron nhe!!");
                //--------------------------------------------------------------//

                // Bai 4
                // Console.WriteLine("Nhap 3 canh cua tam giac");
                // Console.Write("a = ");
                // int a = Convert.ToInt32(Console.ReadLine());
                // Console.Write("b = ");
                // int b = Convert.ToInt32(Console.ReadLine());
                // Console.Write("c = ");
                // int c = Convert.ToInt32(Console.ReadLine());

                // float p ;
                // double S;

                // p = (a+b+c)/2;
                // S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

                // if(a==b && b==c && c==a )
                //     {
                //         Console.WriteLine("Tam giac deu");
                //         Console.WriteLine("Dien tich cua tam giac deu la: " + S);
                //     }
                // else if(a==b || b==c || c==a)
                //     {
                //         Console.WriteLine("Tam giac can");
                //         Console.WriteLine("Dien tich tam giac deu la " + S);
                //     }
                //     else if(a*a == b*b+c*c || b*b == a*a+c*c || c*c == a*a+b*b)
                //             {
                //                 Console.WriteLine("Tam giac vuong");
                //                 Console.WriteLine("Dien tich tam giac vuong la " + S);
                //             }
                //---------------------------------------------------------------------------------//

                //Bai 7
                Console.WriteLine("Giai phuong trinh bac nhat");
                Console.WriteLine("Nhap a va b");
                Console.Write("a = ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.Write("b = ");
                float b = Convert.ToSingle(Console.ReadLine());

                double x;
                x = -b/a;

                if(a==0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if(a!=0 && b!=0)
                        Console.WriteLine("Nghiem phuong trinh la x=" + x);
                    else if(a!=0 && b==0)
                            Console.WriteLine("phuong trinh vo so nghiem");
                
            }
        }
}
