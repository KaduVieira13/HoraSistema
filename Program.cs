using System;

namespace HoraSistema
{
              class Program
              {
                            static void Main(string[] args)
                            {
                                          DateTime horaSistema = DateTime.Now;
                                          string horaLonga = horaSistema.ToLongTimeString();
                                          string datalonga = horaSistema.ToLongDateString();


                                          Console.WriteLine("--- Exibindo a hora deste computador --- \n");
                                          Console.WriteLine($"Olá, hoje é: {horaSistema}");
                                          Console.WriteLine($"Ou seja:  {datalonga}");
                                          Console.WriteLine($"E são exatamente: {horaLonga}");
                            }
              }
}
