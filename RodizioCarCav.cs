using System;

class RodCarCav {

  public static void Main (string[] args) {
    int n = Int32.Parse(Console.ReadLine()); 

    string[] saida = new string[n];
    for (int i = 0; i < n; i++) {
       string placa = Console.ReadLine();
       if (placa.Length != 8) {
           saida[i] = "FALHA";
       }

       if ( ((char)placa[0] >= 'A' && (char)placa[0] <= 'Z')
        && ((char)placa[1] >= 'A' && (char)placa[1] <= 'Z')
        && ((char)placa[2] >= 'A' && (char)placa[2] <= 'Z')
        && (placa[3] == '-')
        && ((char)placa[4] >= '0' && (char)placa[4] <= '9')
        && ((char)placa[5] >= '0' && (char)placa[5] <= '9')
        && ((char)placa[6] >= '0' && (char)placa[6] <= '9')
        && ((char)placa[7] >= '0' && (char)placa[7] <= '9')
       ) {
   
        if (placa[7] == '1' || placa[7] == '2') {
            saida[i] = "SEGUNDA";
        } else if (placa[7] == '3' || placa[7] == '4') {
            saida[i] = "TERCA";
        } else if (placa[7] == '5' || placa[7] == '6') {
            saida[i] = "QUARTA";
        } else if (placa[7] == '7' || placa[7] == '8') {
            saida[i] = "QUINTA";
        } else if (placa[7] == '9' || placa[7] == '0') {
            saida[i] = "SEXTA";
        } 


       } else {
           saida[i] = "FALHA";
       }
    }

    for (int i = 0; i < n; i++)
    {
       Console.WriteLine(saida[i]);  
    }
   
  }
}