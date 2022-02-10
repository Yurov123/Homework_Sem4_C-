// Возведите число А в натуральную степень B, используя цикл.

 
  Console.Write("Enter number : "); //число, которое нужно возвести в степень
  int num = int.Parse(Console.ReadLine());
  Console.Write("Enter degree : ");  //степень числа
  int n = int.Parse(Console.ReadLine());
  int num_n = 1; //число, возведенное в степень

  for(int i = 0; i < n; i++) 
  {
   num_n *= num;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  return 0;
 
















