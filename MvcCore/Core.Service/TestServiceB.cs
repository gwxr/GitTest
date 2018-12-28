using Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public class TestServiceB: ITestServiceB
    {
        public void Show()
        {
            Console.WriteLine("A123456");
        }
    }
}
