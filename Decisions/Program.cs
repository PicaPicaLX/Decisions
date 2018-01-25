using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 这是一个练习，目的是进行逻辑操作

/* 练习使用 “if” 、“else” 、“else if” 等操作
 * “==”作用是判定输入的值与目标值是否相等，然后返回TRUE 或 FALSE
 * “if” 命令后如果判定为TRUE则执行花括号内的代码，执行完后再执行花括号外的；判定为FALSE则直接执行花括号外的
 * “else” 和 “else if” 类似 “if” 的用法
 */

// 下面编写一个打开不同的门能获得不同奖品的游戏
namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {


            //------------------------------------------------------- 使用if语句的方法---------------------------

            Console.WriteLine("<<< LX's Big Giveaway! >>>"); // 游戏名称
            Console.Write("Choose a door: 1, 2 or 3: "); // 选择一扇门
            string userValue = Console.ReadLine(); // 将用户输入赋值给变量“userValue”，且是strain类型，下面开始判定

            // 方法1（若要使用请删除下面的注释符号）----------------------------------------------------------------
            /*
            if (userValue=="1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue=="2")
            {
                string message = "You won a new bot! ";
                Console.WriteLine(message);            
            }
            else if (userValue=="3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry we " +
                    "didn't understand";
                Console.WriteLine(message);
            }
                
            Console.ReadLine();
              // 这种方法能够考虑所有情况：输入1~3或者其他值，缺点是方法“Console.WriteLine(message)”出现了太多次
            */


            // 方法2（若要使用请删除下面的注释符号）----------------------------------------------------------------
            /*
            string message = " "; // 在外部定义变量“message”为strain类型，但是值为一个空格，随后开始判定
            if (userValue == "1")
            {
                 message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                 message = "You won a new bot! ";
            }
            else if (userValue == "3")
            {
                 message = "You won a new cat!";
            }
            else
            {
                 message = "Sorry we didn't understand";
            }

            Console.WriteLine(message);
            Console.ReadLine();
            */
            // 这种方法大大简化了代码，先判定，判定完成后直接执行花括号外代码，缺点是代码有些疏松，不方便阅读


            // 方法3（若要使用请删除下面的注释符号）----------------------------------------------------------------
            /*
            string message = " "; // 在外部定义变量“message”为strain类型，但是值为一个空格；随后开始判定
            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new bot! ";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry we didn't understand. ";
                //message = message + "You Lose."; // 将上面已赋值为“Sorry we didn't understand. "的
                变量“message”和“You lose."连接
                message += "You lose."; // 复制和连接运算符：“+=”，作用是先将变量“message”里的信息提取，再把它
                和字符串“You lose。”连接，最后一起显示
            }

            Console.WriteLine(message);1
            Console.ReadLine();
            */
            // 这种方法练习了+=运算符；若删除90和94行的花括号，则无论输入的值，都会在结果的最后加上“You lose.”


            // 方法4（若要使用请删除下面的注释符号）----------------------------------------------------------------
            /*
            string message = (userValue == "1") ? "boat" : "strand of lint";
            
            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");
            Console.ReadLine();
            */
            // 这种方法适合于只有两种情况需要考虑的情况：选1则获得bot，选其他任何则获得strand of lint
            //但是对于这种简单的情况来说，这些代码还是太长


            // 方法5（若要使用请删除下面的注释符号）----------------------------------------------------------------
            /*
            string message = (userValue == "1") ? "boat" : "strand of lint"; // 这一步判断用户输入的是不是1，是的话执行冒号前的，否则执行冒号后的

            Console.WriteLine("You won a {0}", message); // 这是一个替换的用法，用后面的替换花括号和里面的值，花括号里必须是0，否则程序出错
            Console.ReadLine();
            */
            //这种方法与方法4相比，大大减少了代码量

            // 方法6（若要使用请删除下面的注释符号）----------------------------------------------------------------

            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.WriteLine("You enterde: {0}, therefore you won a {1}!", userValue, message); // 这一步也是替换，想显示用户输入和获得的奖品，因此用{0}和{1}按顺序代替后面的短语
            Console.ReadLine();
        }
    }
}
