namespace ConsoleApp1;

public class Fruit
{
    public static string Group = "植物的一部分";  // 靜態，共通資訊

    public string Color;                         // 實體屬性
    public void ShowColor()                      // 實體方法
    {
        Console.WriteLine($"這顆水果的顏色是 {Color}");
    }
}