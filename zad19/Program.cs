int[] array = new int[5];
int num = new Random().Next(10000, 100000);
int x = num;
int i = 0;
Console.WriteLine($"число {num} является палиндромом?");
while (x > 0){
    int a = x % 10;
    array[i] = a;
    i++;
    x=x/10;
}
//array[0] = 5;
//array[1] = 2;
//array[3] = 2;
//array[4] = 5;
//Console.Write(array[0]);
//Console.Write(array[1]);
//Console.Write(array[2]);
//Console.Write(array[3]);
//Console.Write(array[4]);
//Console.WriteLine();
if(array[0] == array[4] && array[1] == array[3]) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}