using System;
public class ThoiGian
 {
    public void ThoiGianHienHanh()
{
    Console.WriteLine("Hien thi thoi gian hien hanh");
         }
    // Các biến thành viên
    int Nam;
    int Thang;
    int Ngay;
    int Gio;
    int Phut;
    int Giay;
}
public class Tester
{
    static void Main()
{
        ThoiGian t = new ThoiGian();
        t.ThoiGianHienHanh();
        }
}
