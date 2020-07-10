using System;
using System.Linq;

class MainClass {

  static double tof(int C){
    double F = (C * 9/5) + 32;
    return F;
  }

  public static void Main (string[] args) {
    int[] celsius = new int[7];
    double[] fahrenheit = new double[7];

    for(int i=0 ; i < 7 ; i++ ){
      Console.WriteLine("Enter temperature in Celsius: "); 
      var t = Console.ReadLine();
      int temp = Convert.ToInt32(t);
      celsius[i] = temp;
      fahrenheit[i] = tof(celsius[i]);
    }
    Console.WriteLine("Temperature in Fahrenheits: ");
    double totalf = 0;
    foreach (double i in fahrenheit){
      Console.WriteLine(i);
      totalf += i;
    }
    Console.WriteLine("Average weekly temperatyrure is " + totalf/7 + " degree Fahrenheit");
  }
  
   


}