using System;
//using System.IO;
using System.Text.RegularExpressions;

class Test
{
    public static void Main()
    {
        // тестовая строка
        String strTest = "         ";
        Console.WriteLine(strTest);

        //Проверка IP адреса     
        Regex check = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
        Console.WriteLine(check.IsMatch(strTest));

        // Проверка логина
        Regex login_regex = new Regex("^[a-zA-Zа-яА-Я0-9 !$&%'()*+,-./:;<=>?#_]{0,30}$");
        if (login_regex.IsMatch(strTest))  {
            Console.WriteLine("ок");
        }
        else {
            Console.WriteLine("ошибка");
        }

        // Проверка пароля
        Regex password_regex = new Regex("^[a-zA-Zа-яА-Я0-9 !$&%'()*+,-./:;<=>?#_]{6,30}$");
        if (password_regex.IsMatch(strTest)){
            Console.WriteLine("ок");
        }
        else Console.WriteLine("ошибка");
        }


        
        
        
        //string source = "ivanov98";
 
        /* if (login_regex.Match(strTest).Success) // если совпадение удачно 
        {
        Console.WriteLine("Login is correct");
        }
        else
        {
        Console.WriteLine("Login is incorrect");
        }*/


// запуск теста
        //Console.WriteLine("start");
        /*DateTime testTime = new DateTime();
        testTime = DateTime.Now;

        // проверка корректности
        int testOk = 0;
        List<string> testFail = new List<string>();
        bool a = true;
        Console.WriteLine("bool = " + a);
        Console.ReadLine();
        for (int i = 1; i < strTest.Length + 1; i++)
        {
            bool cont = CorTest();
            if (a == cont)
            {
                testOk++;
            }
            else
            {
                testFail.Add(i + " test " + DateTime.Now);
            }
            Thread.Sleep(1000);
        }
        Console.WriteLine("finish");
        // отчет
        
        
        string strTestTime = testTime.ToString(); 
        string result = "report\n" + "название тестов \n" + " тесты запущены "+ testTime.ToString() 
                        + "\n всего тестов " + testOk.ToString();
        Console.WriteLine(result);
        Console.WriteLine("report");
        Console.WriteLine("название тестов");
        Console.WriteLine("тесты запущены "+ strTestTime);
        Console.WriteLine("всего тестов " + strTest.Length);
        Console.WriteLine("выполнено корректно = " + testOk);
        Console.WriteLine("провалены следующие тесты: ");
        for (int i = 0; i < testFail.Count; i++)
        {
            Console.WriteLine(testFail[i]);
        }



        // рандом корректности
        bool CorTest()
        {
            var random = new Random();
            return random.Next(2) == 1;
        }


        string path = @"E:\DASHA\Работа\rdc\Test2.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(result);
            }
        }*/

}

