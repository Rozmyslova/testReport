
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

for (int i = 1; i < strTest.Length + 1; i++){
    bool cont = CorTest();
    //Console.WriteLine("cont = " + cont);
    if (a == cont) {
        testOk++;
    } else {
        testFail.Add(i + " test " + DateTime.Now);
    }
    Thread.Sleep(100);
}
//Console.WriteLine("finish");
// отчет

Console.WriteLine("report");
Console.WriteLine("название тестов");
Console.WriteLine("тесты запущены " + testTime);
Console.WriteLine("всего тестов " + strTest.Length);
Console.WriteLine("выполнено корректно = " + testOk + " тестов");
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



