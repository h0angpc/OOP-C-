using System;
using System.Collections.Generic;
using System.Linq;

interface ISoSanh<T>
{
    int SoSanh(T other);
}

class SinhVien : ISoSanh<SinhVien>
{
    public string HoTen { get; set; }
    public double DiemTrungBinh { get; set; }
    public SinhVien()
    {
        HoTen = "";
        DiemTrungBinh = 0.0;
    }
    public SinhVien(string hoTen, double diemTrungBinh)
    {
        HoTen = hoTen;
        DiemTrungBinh = diemTrungBinh;
    }
    public int SoSanh(SinhVien other)
    {
        if (DiemTrungBinh > other.DiemTrungBinh)
            return 1;
        else if (DiemTrungBinh < other.DiemTrungBinh)
            return -1;
        else
            return 0;
    }

    public override string ToString()
    {
        return $"Ho ten: {HoTen}, ĐTB: {DiemTrungBinh}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        NhapDanhSachSinhVien(danhSachSinhVien);

        Console.WriteLine("Danh sach sinh vien truoc khi sap xep:");
        XuatDanhSachSinhVien(danhSachSinhVien);

        danhSachSinhVien.Sort((sv1, sv2) => sv1.SoSanh(sv2));

        Console.WriteLine("\nDanh sach sinh vien sau khi sap xep theo DTB:");
        XuatDanhSachSinhVien(danhSachSinhVien);
    }

    static void NhapDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
    {
        int soLuong;
        do
        {
            Console.Write("Nhap so luong sinh vien (so nguyen duong): ");
        } while (!int.TryParse(Console.ReadLine(), out soLuong) || soLuong <= 0);

        for (int i = 0; i < soLuong; i++)
        {
            Console.Write($"Nhap thong tin sinh vien {i + 1}:\nHo Ten: ");
            string hoTen = Console.ReadLine();

            double diemTrungBinh;
            do
            {
                Console.Write("Diem trung binh (0 <= ĐTB <= 10): ");
            } while (!double.TryParse(Console.ReadLine(), out diemTrungBinh) || diemTrungBinh < 0 || diemTrungBinh > 10);

            SinhVien sv = new SinhVien(hoTen, diemTrungBinh);
            danhSachSinhVien.Add(sv);
        }
    }

    static void XuatDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
    {
        foreach (SinhVien sv in danhSachSinhVien)
        {
            Console.WriteLine(sv);
        }
    }
}


