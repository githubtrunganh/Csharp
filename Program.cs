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
                // Console.WriteLine("Giai phuong trinh bac nhat");
                // Console.WriteLine("Nhap a va b");
                // Console.Write("a = ");
                // float a = Convert.ToSingle(Console.ReadLine());
                // Console.Write("b = ");
                // float b = Convert.ToSingle(Console.ReadLine());

                // double x;
                // x = -b/a;

                // if(a==0)
                //     Console.WriteLine("Phuong trinh vo nghiem");
                // else if(a!=0 && b!=0)
                //         Console.WriteLine("Nghiem phuong trinh la x=" + x);
                //     else if(a!=0 && b==0)
                //             Console.WriteLine("phuong trinh vo so nghiem");
                //---------------------------------------------------------------//

                //Bai 8

                // Console.WriteLine("Tinh phuong trinh bac hai");
                // Console.WriteLine("Nhap a va b va c");
                // Console.Write("a = ");
                // float a = Convert.ToSingle(Console.ReadLine());
                // Console.Write("b = ");
                // float b = Convert.ToSingle(Console.ReadLine());
                // Console.Write("c = ");
                // float c = Convert.ToSingle(Console.ReadLine());

                // double delta,x1,x2,x;
                // delta = b*b - 4*a*c;
                // x = -b/(2*a);
                // x1 = (-b + Math.Sqrt(delta))/(2*a);
                // x2 = (-b - Math.Sqrt(delta))/(2*a);

                // if (a==0 && b==0 && c==0)
                //     Console.WriteLine("Cac gia tri khong duoc = 0 oke");

                // if(a==0 && b!=0 && c!=0){
                //     double d;
                //     d = -c/b;

                //     if(b==0 && c!=0)
                //         Console.WriteLine("Phuong trinh vo nghiem");
                //     else if(b!=0 && c!=0)
                //             Console.WriteLine("Nghiem phuong trinh la x = " + d);
                //         else if(b!=0 && c==0)
                //                 Console.WriteLine("phuong trinh vo so nghiem");
                // }
                // if(a!=0 && b!=0 && c!=0) {
                //     if(delta < 0)
                //         Console.WriteLine("Phuong trinh vo nghiem");
                //     else if(delta == 0)
                //             Console.Write("Phuong trinh co nghiem kep x = " + x);
                //         else{
                //             Console.WriteLine("Phuong trinh co 2 nghim phan biet");
                //             Console.Write("x1 = " + x1 + "\nx2 = " + x2);
                //         } 
                // }
                // if(a!=0 && b==0 && c!=0 && c>0) 
                //         Console.WriteLine("Phuong trinh vo nghiem");
                // else if(a!=0 && b==0 && c!=0 && c<0) {
                //         Console.WriteLine("Phuong trinh co 2 nghiem");
                //         Console.WriteLine("x1 =" + c + "\nx2 = " + -c);
                // }
                // if(a!=0 && b!=0 && c==0) {
                //     Console.WriteLine("Phuong trinh co 2 nghiem");
                //     Console.Write("x1 =" + 0 + "\nx2 =" + -b/a);
                // }else if(a!=0 && b==0 && c==0)
                //     Console.WriteLine("Phuong trinh co 1 nghiem   x = " + 0);
                //-----------------------------------------------------------------//
                //Bai 9

                // Console.WriteLine("Nhap so do cua goc (Phut)");
                // Console.Write("x = ");
                // double x = Convert.ToDouble(Console.ReadLine());

                // x = x / 60; // doi phut thanh goc
                // double goc = (x/9)%4; 
                // Math.Ceiling(x);
                // Console.WriteLine("X thuoc goc vuong thu " + (x/9)%4);
                // Console.WriteLine("cos(x) = " + Math.Cos(x * 3.14/180));
                //----------------------------------------------------------------//
                //Bai 10
                // Console.Write("Thang: ");
                // int m = Convert.ToInt32(Console.ReadLine());

                // if(m>12)
                //     Console.WriteLine("Co thang lon hon 12 a?? Nhap lai!!");
                // if(m==1 || m==2 || m==3 || m==4){
                //     Console.WriteLine("Thang do thuoc quy 1");
                // }else if(m==5 || m==6 || m==7 || m==8){
                //         Console.WriteLine("Thang do thuoc quy 2");
                // }else if(m==9 || m==10 || m==11 || m==12) {
                //         Console.WriteLine("Thang do thuoc quy 3");
                //     }   
                //---------------------------------------------------------------//
                //Bai 10
                

            }
        }
}
