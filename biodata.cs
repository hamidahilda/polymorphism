using System;

namespace MyApplication
{
  class Keluarga
  {
    public string Name   
    { get; set; }  
    public string Ttl
    { get; set; }
    public string Umur
    { get; set; }
    public virtual void hobi(){
        Console.WriteLine("hobi");
    }
  }
  class Ayah : Keluarga {
      public override void hobi(){
          Console.WriteLine("hobi: membaca");
      }
  }
  class Ibu : Keluarga {
      public override void hobi(){
          Console.WriteLine("hobi: masak");
      }
  }
  class Kakak : Keluarga {
      public override void hobi(){
          Console.WriteLine("hobi: belajar");
      }
  }
  class Aku : Keluarga {
      public override void hobi(){
          Console.WriteLine("hobi: membaca");
      }
  }
  class Program
  {  
    static void Main(string[] args)
    {
       Console.WriteLine("\tData Keluarga"); Console.WriteLine("\t=============");
      Keluarga myAy = new Keluarga();
      myAy.Name = "Suprapto";
      myAy.Ttl ="Sidoarjo, 21 april 1968";
      myAy.Umur ="53";
      Console.WriteLine("nama ayah:" + myAy.Name);
Console.WriteLine("Ttl:" + myAy.Ttl);
Console.WriteLine("Umur:"+ myAy.Umur);
      Keluarga myAyah = new Ayah();
      myAyah.hobi();
      //biodata Ayah
      Console.WriteLine("===============");
      Keluarga myIb = new Keluarga();
      myIb.Name = "Robiatul Adawiyah";
      myIb.Ttl ="Pasuruan. 11 oktober 1969";
      myIb.Umur ="54";
      Console.WriteLine("nama ibu:" + myIb.Name);
Console.WriteLine("Ttl:" + myIb.Ttl);
Console.WriteLine("Umur:"+myIb.Umur);
      Keluarga myIbu = new Ibu();
      myIbu.hobi();
      //biodata ibu
      Console.WriteLine("===============");
      Keluarga myKak = new Keluarga();
      myKak.Name = "M. Sholehuddin Al-Ayyubi";
      myKak.Ttl ="11 Februari 2000";
      myKak.Umur ="23";
      Console.WriteLine("nama Kakak:" + myKak.Name);
Console.WriteLine("Ttl:" + myKak.Ttl);
Console.WriteLine("Umur:"+ myKak.Umur);
      Keluarga myKakak = new Kakak();
      myKakak.hobi();
      //biodata kakak
      Console.WriteLine("===============");
      Keluarga myAk = new Keluarga();
      myAk.Name = "Hilda Hamida";
      myAk.Ttl ="2 Mei 2007";
      myAk.Umur ="16";
      Console.WriteLine("namaKu:" + myAk.Name);
Console.WriteLine("Ttl:" + myAk.Ttl);
Console.WriteLine("Umur:"+ myAk.Umur);
      Keluarga myAku = new Aku();
      myAku.hobi();
      //biodataku
      
    }
  }
}
