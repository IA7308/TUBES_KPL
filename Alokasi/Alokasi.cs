
namespace Alokasi
{
    public class Alokasi
    {
        public static List<string> Kendaraan = new List<string>{ "Motor", "Truck" };
       
        public static string Penempatan( string tempat, string waktu) {
            for (int i = 0; i < Kendaraan.Count; i++) {
                Console.WriteLine(i+ ". " + Kendaraan[i]);
            }
            Console.WriteLine("Pilih Kendaraan : ");
            int pilihan = int.Parse(Console.ReadLine());

            
            return "Pakai kendaraan : " + Kendaraan[pilihan] +"\n"+"Dijemput di : " + tempat + "\n"+ "Pada pukul : " + waktu;
        }
    }
}