using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WangJun.Yun;

namespace WangJun.MailProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            WangJunMail.GetInst("smtp.163.com", 25, false, "tushu2019", "7573Wj7573").Send("tushu2019@163.com", "tushu2019@163.com", "测试", "测试111");
            Console.ReadKey();
        }
    }
}
