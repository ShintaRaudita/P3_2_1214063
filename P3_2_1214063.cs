/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld
{
  static void Main ()
  {
    Console.WriteLine ("MENU PERSEGI PANGJANG");
    Console.WriteLine ("1. Hitung Luas");
    Console.WriteLine ("2. Hitung Keliling");
    
    Console.WriteLine("Menu Pilihan: ");
    int Pilihan = int.Parse(Console.ReadLine());
    
    if(Pilihan == 1)
    {
        Console.WriteLine("MENGHITUNG LUAS PERSEGI PANJANG");
        Console.WriteLine("Masukkan Panjang: ");
        int PLuas = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukkan Lebar: ");
        int LLuas = int.Parse(Console.ReadLine());
        
        int Luas_pj = PLuas * LLuas;
        Console.WriteLine("Luas Persegi Panjang: " + Luas_pj);
        
        Console.WriteLine("Ingin mengulang kembali (Y/T)?");
        string Pesan = Console.ReadLine();
        
        //Bila user menginput “Y” maka akan muncul bagian dibawah. 
        if (Pesan == "Y")
        {
            Console.WriteLine("TERIMA KASIH");   
        }else //end if (Pesan == "Y")
        {
            Console.WriteLine("SAMPAI JUMPA");
        } //end else
        
        
    }else if (Pilihan == 2) //end if (Pilihan == 1)
    
    {
        Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
        Console.WriteLine("Masukkan Panjang: ");
        int PKeliling = int.Parse(Console.ReadLine());
        Console.WriteLine("Masukkan Lebar: ");
        int LKeliling = int.Parse(Console.ReadLine());

        int Keliling_pj = 2*(PKeliling + LKeliling);
        Console.WriteLine("Keliling Persegi Panjang: " + Keliling_pj);
        
        Console.WriteLine("Ingin mengulang kembali (Y/T)?");
        string Pesan = Console.ReadLine();
        
        //Bila user menginput “Y” maka akan muncul bagian dibawah. 
        if (Pesan == "Y")
        {
            Console.WriteLine("TERIMA KASIH");   
        }else //end if (Pesan == "Y")
        {
            Console.WriteLine("SAMPAI JUMPA");
        }
        
    }//else if (Pilihan == 2)
    
  } //end static void Main ()
}//end class HelloWorld
