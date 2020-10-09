using System;

namespace PrimesDemo 
{
  class Primes 
  {
    static void Main(string[] args) {
      var n = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < n; i++) 
      {
        Console.WriteLine("{0} is {1}", i, IsPrime(i) ? "prime" : "not prime");
      }

    }

    static bool IsPrime(int n) {
      if (n < 2) return false;

      for (int i = 2; i <= Math.Sqrt(n); i++) 
      {
        if (n % i == 0)
          return false;
      }
      return true;
    }
  }
}