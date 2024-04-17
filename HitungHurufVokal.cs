//12. Menghitung huruf vokal dalam teks user
using System;
using System.Collections.Generic;

class HitungHurufVokal{
    static void Main(){
        Console.WriteLine ("Menghitung huruf vokal dalam teks");
        Console.Write("Masukkan teks: ");
        string teks = Console.ReadLine();
        
        Dictionary<char, int> hasil = HitungVokal(teks);
        
        foreach (var pasangan in hasil){
            Console.WriteLine($"Huruf {pasangan.Key}: {pasangan.Value}");
        }
    }

    static Dictionary<char, int> HitungVokal(string teks){
        
        char[] vokal = new char[] { 'a', 'e', 'i', 'o', 'u' };
        
        Dictionary<char, int> jumlahVokal = new Dictionary<char, int>();

        foreach (char v in vokal){
            jumlahVokal[v] = 0;
        }

        foreach (char karakter in teks.ToLower()){
            if (Array.IndexOf(vokal, karakter) >= 0){
                jumlahVokal[karakter]++;
            }
        }

        return jumlahVokal;
    }
}