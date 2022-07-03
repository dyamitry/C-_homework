int CutNumber()
{
    int num = new Random().Next(100,1000);
    Coonsole.WriteLine("Current random number is " + num);

    int Sotni = num / 100;
    int Ed = num % 10;

    int result = sotni * 10 + Ed;
    return result;
}

