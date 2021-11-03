// два друга идут навстречу друг другу и между ними бегает задача. сколько раз она пробежеит между ними
int count = 0;
double distance = 10000;
double firstFrSpeed = 1;
double secondFrSpeed = 2;
double dogSpeed = 5;
int friend = 2;
double time = 0;

while (distance > 10)
{

    if (friend == 1)
    {
        time = distance / (firstFrSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFrSpeed + secondFrSpeed) * time;
    }
    else
    {
        time = distance / (secondFrSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFrSpeed + secondFrSpeed) * time;
    }
count++;
}
Console.WriteLine("Собака пробежит столько раз  "+count);

