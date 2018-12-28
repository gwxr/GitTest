using Core.Interface;
using System;

namespace Core.Service
{
    public class TestServiceA: ITestServiceA
    {
        public void Show()
        {
            Console.WriteLine("A123456");
        }
    }
}
