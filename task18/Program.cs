// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// закон де мораган
bool x=false;
bool y=false;
bool f1=!(x || y);
bool f2= !x && !y;
Console.WriteLine (f1);
Console.WriteLine (f1);

bool q=(2*2==4); // пример использования бул
Console.WriteLine (q);