namespace ConsoleApp1;

public class Student
{
    public string Name;
    public int Fee;
    public bool Paid;
    
    // 用來存學生人數
    private static int studentCount = 0;
    
    // 用來存已付和未付學生人數
    private static int paidCount = 0;
    private static int unpaidCount = 0;

    public Student(string name, int fee, bool paid= false)
    {
        Name = name;
        this.Fee = fee;
        this.Paid = paid;
        studentCount++; // 建立時累加人數
        
        // 統計繳費狀況。統計寫在這裡才會每一次新增資料的時候計算到，不要寫在方法，因為呼叫時才跑不是新增就跑資料。
        if (paid)
            paidCount++;
        else
            unpaidCount++;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"學生姓名： {Name}");
        Console.WriteLine($"學費金額： {Fee}");
        Console.WriteLine($"是否以付費： {Paid}");

        Console.WriteLine(Paid ? "已繳費" : "尚未繳費");
    }

    public static void ShowTuitionStats()
    {
        Console.WriteLine($"已繳學費：{paidCount} 人");
        Console.WriteLine($"未繳學費：{unpaidCount} 人");
        Console.WriteLine($"總人數：{studentCount} 人");
    }
}