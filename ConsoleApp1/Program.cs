// See https://aka.ms/new-console-template for more information

// 單行註解
/* 多行註解 */

// WriteLine() 會換行，Write() 不會
// Console 是類別、WriteLine 是方法

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            // 常數用法（用來固定值，不被覆蓋）
            const int a = 10;
            Console.WriteLine(a);
            
            // 變數顯示方式
            string name = "John";
            int b = 30;
            Console.WriteLine("Hello"+ name);
            Console.WriteLine(a+b);
            
            // 型態轉換
            int myInt = 20;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            double myDouble2 = 3.94;
            int myInt2 = (int)myDouble2;
            Console.WriteLine(myInt2);
            
            Console.WriteLine(Convert.ToInt32(myDouble));
            
            // Get User Input
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: "+userName);
            
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" +age);
            
            // 運算子
            int x = 2;
            x++;    // 算術運算子
            Console.WriteLine(x);
            
            int y = 3;
            y += 3; // 賦值運算值
            Console.WriteLine(y);
            
           // Math 裡的方法 
            Console.WriteLine(Math.Max(2,10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(4.7));
            
            string str = "He's \"name\"";
            Console.WriteLine(str);
            
            // 靜態/實體方法
            Fruit apple = new Fruit();  
            apple.Color = "紅色";     
            apple.ShowColor();      // 實體方法，要 new 新物件
            
            Console.WriteLine(Fruit.Group);     // 靜態方法，不用 new 也能呼叫
            
            // 建構子的使用
            Student s1 = new Student("Ruby", 2000, true);
            Student s2 = new Student("Fiora", 1000, false);
            Student s3 = new Student("Ella", 3000, false);
            Student s4 = new Student("Marta", 3000, true);
            
            s1.ShowInfo();
            Console.WriteLine("-----------");
            s2.ShowInfo();
            Console.WriteLine("-----------");
            s3.ShowInfo();
            Console.WriteLine("-----------");
            s4.ShowInfo();
            Console.WriteLine("-----------");
            
            Student.ShowTuitionStats();
            // 另一種寫法
            List<Student> students = new List<Student>
            {
                new Student("Tom", 1000, true),
                new Student("Fifi", 1000, false),
                new Student("Ala", 3000, false),
            };
            Console.WriteLine("\n 以下學生尚未繳費：");
            List<Student> unpaidStudents = students.Where(s =>!s.Paid).ToList();

            foreach (Student s in unpaidStudents)
            {
                Console.WriteLine($"{s.Name}還沒繳學費");
            }
            
            // 使用 Enum
            Console.WriteLine("\n 請輸入訂單狀態代碼：");
            Console.WriteLine("0 = Pending");
            
            string input = Console.ReadLine();

            if (int.TryParse(input, out int statusCode) && Enum.IsDefined(typeof(OrderStatus), statusCode))
            {
                OrderStatus currentStatus = (OrderStatus)statusCode;
                Console.WriteLine($"\n你輸入的訂單狀態是：{currentStatus}");

                switch (currentStatus)
                {
                    case OrderStatus.Pending:
                        Console.WriteLine("訂單尚未處理");
                        break;
                    case OrderStatus.Processing:
                        Console.WriteLine("處理中 ");
                        break;
                    case OrderStatus.Shipped:
                        Console.WriteLine("已出貨");
                        break;
                    case OrderStatus.Delivered:
                        Console.WriteLine("已送達");
                        break;
                    case OrderStatus.Cancelled:
                        Console.WriteLine("已取消");
                        break;
                }
            }
            else
            {
                Console.WriteLine("輸入錯誤，請輸入有效訂單狀態碼（0~4）");
            }
        }
    } 
}