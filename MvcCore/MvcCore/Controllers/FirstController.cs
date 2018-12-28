using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interface;
using log4net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCore.Utility;

namespace MvcCore.Controllers
{
    public class FirstController : Controller
    {
        //方法一
        private ILoggerFactory _factory = null;
        //方法二
        private ILogger<FirstController> _logger=null;

        private ITestServiceA _ITestServiceA = null;
        private ITestServiceB _ITestServiceB = null;


        //属性注入 暂不成功
        private ITestServiceA ITestServiceA { get; set; }


        //AOP
        private IA _iA = null;
        public FirstController(ILoggerFactory factory, 
            ILogger<FirstController> logger,
            ITestServiceA testServiceA,
            ITestServiceB testServiceB,
            IA ia)
        {
            this._factory = factory;
            this._logger = logger;
            this._ITestServiceA = testServiceA;
            this._ITestServiceB = testServiceB;
            _iA = ia;
        }
        public IActionResult Index()
        {
            this._logger.LogError("这里是firstController");
            this._logger.LogWarning("这里是firstController             LogWarning");
            _factory.CreateLogger<FirstController>().LogError("工厂方法创建错误日志");


            this._logger.LogWarning($"_ITestServiceA={this._ITestServiceA.GetHashCode()}");
            this._logger.LogWarning($"_ITestServiceB={this._ITestServiceB.GetHashCode()}");

            this._ITestServiceA.Show();


            this._iA.Show(123, "走自己的路");
            return View();
        }
    }
}