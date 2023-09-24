using System;
class Nguoi
{
   public class Date
{
   private int ngay;
   private int thang;
     public Date() { ngay = 1; thang = 1; }
     public void Xuat()
{
    Console.WriteLine(ngay + "/" +thang);
}
 }
 private string ten;
 private string ho;
 private Date ns;
 public Nguoi()
{
    ten = "An"; ho = "Nguyen Van"; ns = new
Date();
}
 public void Xuat()
 {
     ns.Xuat(); Console.WriteLine(ho + " " + ten);
     }
 }
 class Progarm
 {
    
 static void Main(string[] args)
 {
         Nguoi a = new Nguoi();
         a.Xuat();
         Nguoi.Date ns = new Nguoi.Date();
         ns.Xuat();
         }
     }