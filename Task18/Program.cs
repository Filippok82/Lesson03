//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

/* bool func(bool x, bool y)
{
 bool result = false;   
if (!(x&y)==!x|!y)
{
  result = true;
}
  return result;
}
Console.WriteLine(func(true,false)); */

bool x = true;
bool y = false;
bool f1 = !(x || y);
bool f2 = !x && !y;
Console.WriteLine(f1 == f2);
