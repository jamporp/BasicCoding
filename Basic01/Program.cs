int Integer; //8bit = 256(0-255) ปัจจุบัน 32bit = 255^4
char Character; //เก็บ1ตัวอักษร
Integer = 1;
Character = 'a';
Console.WriteLine(Integer);
Console.WriteLine(Character);
//
float _Float = 1.00f;
double _Double = 2.00;
Console.WriteLine("number1 = " + _Float);
Console.WriteLine("number2 = " + _Double);
//
string str1, str2;
String str3 = "string3", str4 = "string4";
str1 = null;
str2 = "";
Console.WriteLine("string1 = " + str1);
Console.WriteLine("string2 = " + str2);
bool check;
check = (str1 == str2);
Console.WriteLine("check = " + check);
//
object obj = new
{
    i = 1,
    str = "a b c",
    chk = true,
    f = 9.87
};
Console.WriteLine("obj = " + obj);
//
class Cls01
{
    int i;
    string str;
    bool chk;
    float f;
}
// Console.WriteLine("class01 = " + Cls01); ยังดูค่าไม่ได้เพราะยังไม่ได้สร้าง
// Cls01 class01 = new Cls01(); ยังสร้างขึ้นมาไม่ได้ ให้ไปดูที่สร้างได้ที่69
//
//ฟังก์ชั่น
/*
void func01(){

}
 */ //ฟังก์ชั่นจะต้องสร้างชึ้นมา ในClass
class cls02
{
    void func02()
    {

    }
    int func03()
    {
        return 0;
    }
    string func04()
    {
        // return "";
        return null;
    }
}
//
class _class
{
    _class()
    {
        Cls01 class01 = new Cls01();
        Console.WriteLine("class01 = " + class01);
        //มันไม่ขึ้นเพราะใช้งาน Class ผิดรูปแบบ ปกติที่C# จะให้ใช้
    }
}
//
namespace _Name //Basic01 ลองแล้วแต่ไม่ได้
{
    class Program
    {
        Program()
        {
            Cls01 class01 = new Cls01();
            Console.WriteLine("class01 = " + class01);
            //มันไม่ขึ้นเพราะใช้งาน Class ผิดรูปแบบ ปกติที่C# จะให้ใช้
        }
    }
}
//
namespace Basic01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cls01 class01 = new Cls01();
            Console.WriteLine("class01 = " + class01);
            Console.WriteLine("Hello");
            //เป็นรูปแบบถูกต้องที่runได้แล้ว แต่ต้องไม่มีCodeก่อนหน้าที่อยู่นอก Namespace(คือเอา86ขึ้นไปออก)
        }
    }
}