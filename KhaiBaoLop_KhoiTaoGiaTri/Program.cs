using System;
public class ThoiGian
{
    public void ThoiGianHienHanh()
    {
        System.DateTime now = System.DateTime.Now;
        System.Console.WriteLine("\n Hien tai: \t" + now.Day + "/" + now.Month + "/" + now.Year + "\t" + now.Hour + ":" + now.Minute + ":" + now.Second);
        System.Console.WriteLine(" Thoi Gian: \t" + Ngay + "/" + Thang + "/" + Nam + "\t" + Gio + ":" + Phut + ":" + Giay);
     }
public ThoiGian(System.DateTime dt)
{
        Nam = dt.Year; Thang = dt.Month; Ngay = dt.Day;
        Gio = dt.Hour; Phut = dt.Minute;
        Giay = dt.Second;
    }
public ThoiGian(int Year, int Month, int Date,
int Hour, int Minute)
{
    Nam = Year;Thang = Month;Ngay = Date;
    Gio = Hour;Phut = Minute;
}

    private int Nam;
    private int Thang;
    private int Ngay;
    private int Gio;
    private int Phut;
    private int Giay = 30; // biến được khởi tạo.
}
public class Tester
{
    static void Main()
{
        System.DateTime currentTime =
        System.DateTime.Now;
        ThoiGian t1 = new ThoiGian(currentTime);
        t1.ThoiGianHienHanh();
        ThoiGian t2 = new ThoiGian(2001, 7, 3, 10, 5);
        t2.ThoiGianHienHanh();
        }
}