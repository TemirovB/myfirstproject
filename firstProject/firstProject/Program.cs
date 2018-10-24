using System;

namespace firstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
    first code




               int n, k;
               Console.WriteLine("первое число");
               n = Convert.ToInt32(Console.ReadLine());

               int m;
               Console.WriteLine("второе число");
               m = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("умножьте первое число на второе");
               k = Convert.ToInt32(Console.ReadLine());


               if (k == n*m)
                   Console.WriteLine("cool");

               else
                   Console.WriteLine("not cool");
               Console.WriteLine(n*m);


               int n;
               Console.WriteLine("первое число");
               n = Convert.ToInt32(Console.ReadLine());

               int m;
               Console.WriteLine("второе число");
               m = Convert.ToInt32(Console.ReadLine());

               if (n+m % 2 == 0)
                   Console.WriteLine("четное");
               else
                   Console.WriteLine("нечетное");








   second code 





               string n;
               Console.WriteLine("Введите пароль");
               n = Convert.ToString(Console.ReadLine());

               // var b = ("password");
               string b = Convert.ToString("password");


               if (n == b) {
                   Console.WriteLine("Доступ открыт");


               }
               else if (n != b)
               {
                   Console.WriteLine("ВВедите еще раз");
                   n = Convert.ToString(Console.ReadLine());


               }
               if (n == b)
               {
                   Console.WriteLine("Доступ открыт");

               }
               else {
                   Console.WriteLine("Ошибка, доступ закрыт");

               }






   third code 





               char n;
               Console.WriteLine("первая буква англ. алфавита");
               n = Convert.ToChar(Console.ReadLine());

               char m;
               Console.WriteLine("последняя буква англ. алфавита");
               m = Convert.ToChar(Console.ReadLine());

               char a = Convert.ToChar("a");
               char b = Convert.ToChar("z");



               if (n == a && m == b){
                   Console.WriteLine("верно");

               }
               else{
                   Console.WriteLine("неверно");

               }




   fifth code





               Random rnd = new Random();
               int month = rnd.Next(1, 13);

               Console.WriteLine(month);


               switch (month) {
                   case 1:
                       Console.WriteLine("january");
                       break;

                   case 2:
                       Console.WriteLine("february");

                       break;

                   case 3:
                       Console.WriteLine("march");

                       break;

                   case 4:
                       Console.WriteLine("april");

                       break;

                   case 5:
                       Console.WriteLine("may");

                       break;

                   case 6:
                       Console.WriteLine("june");

                       break;

                   case 7:
                       Console.WriteLine("july");

                       break;

                   case 8:
                       Console.WriteLine("august");

                       break;

                   case 9:
                       Console.WriteLine("september");

                       break;

                   case 10:
                       Console.WriteLine("october");

                       break;


                   default: 
                       Console.WriteLine("november or december");
                       break;


               }




   this is F task





               int n;
               Console.WriteLine("первое число");
               n = Convert.ToInt32(Console.ReadLine());

               int m;
               Console.WriteLine("второе число");
               m = Convert.ToInt32(Console.ReadLine());

               int k;
               Console.WriteLine("третье число");
               k = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine(Math.Max(Math.Max(m, n), k));




   this is U task




               int n;
               Console.WriteLine("первое число");
               n = Convert.ToInt32(Console.ReadLine());

               int m;
               Console.WriteLine("второе число");
               m = Convert.ToInt32(Console.ReadLine());

               int k;
               Console.WriteLine("третье число");
               k = Convert.ToInt32(Console.ReadLine());

               var l = n;

               if (n == m && l == k){
                   Console.WriteLine("3");

               }
               else if (n == m){
                   Console.WriteLine("2");

               }
               else if (n == k)
               {
                   Console.WriteLine("2");

               }
               else if (k == m)
               {
                   Console.WriteLine("2");

               }
               else {
                   Console.WriteLine("0");

               }




            //homework
            int n;
            Console.WriteLine("Введите код вашего города");
            n = Convert.ToInt32(Console.ReadLine()); 
            int min = Convert.ToInt32(Console.ReadLine());

            switch (n){
                case 7152:
                    Console.WriteLine(25*min);
                    break;
                case 7172:
                    Console.WriteLine(30*min);
                    break;
                case 7252:
                    Console.WriteLine(20*min);
                    break;
                case 727:
                    Console.WriteLine(28*min);
                    break;
                default:
                    break;
            }


            int a;
                        Console.WriteLine("первое число");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
                        Console.WriteLine("второе число");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;


            for (int i = a; i <= b;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum / (b - a+1));

            int a = -20;

            while(a >= -100)
            {
                Console.WriteLine(a);
                a -= 20;
               
            }
                         */

            int N;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i=N-5;i<=N+5;i++){
                if (i == N)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
