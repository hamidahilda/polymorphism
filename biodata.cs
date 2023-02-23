using System;
public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ibu = new Ibu();
     familyhobi kakak = new Kakak();
     familyhobi anak = new Anak();
     
     familydata ibuku = new familydata("Robiatul Adawiyah",54,083833496424);
    familydata kakakku = new familydata("Muhammad Sholehudin Al-Ayyubi",23,083833496424);
    familydata aku = new familydata("Hilda Hamida",16,083833722201);
     Console.WriteLine("DATA IBU:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
   Console.WriteLine("DATA KAKAK:\n"+kakakku.nama+"\n"+kakakku.umur+"\n"+kakakku.nohp);
     kakak.Hobi();
     Console.WriteLine("DATA ANAK:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Masak");
        }
    }
    class Kakak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("belajar ilmu hukum");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("membaca");
        }
    }
}
