using System;
using System.IO;

class Test
{
    public static void Main()
    { 
        // тестовая строка
        String strTest = "test";
        Console.WriteLine(strTest);

        // запуск теста
        //Console.WriteLine("start");
        DateTime testTime = new DateTime();
        testTime = DateTime.Now;

        // проверка корректности
        int testOk = 0;
        List<string> testFail = new List<string>();
        bool a = true;

        for (int i = 1; i < strTest.Length + 1; i++)
        {
            bool cont = CorTest();
            //Console.WriteLine("cont = " + cont);
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
        //Console.WriteLine("finish");
        // отчет
        string strTestTime = testTime.ToString(); 
        string result = "report\n" + "название тестов " + " тесты запущены "+ testTime.ToString() + "всего тестов ";
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


        string path = @"E:\DASHA\Работа\rdc\Test1.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(result);
            }
        }
    }
}


