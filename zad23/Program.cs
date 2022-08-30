Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int next =1;
while (next <= n){
   
    int cube = next*next*next;
    next++;
    Console.Write($"{cube}, ");
}

