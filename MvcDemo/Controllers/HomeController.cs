using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var c = new Models.Class2() { name = "123" };
            //1、Automapper使用静态类创建映射

            //ViewBag.Tips = "1、Automapper使用静态类创建映射";

            //Mapper.Initialize(cfg => cfg.CreateMap<Models.Class1, Models.Class2>());

            //var productDTO = Mapper.Map<Models.Class2>(c);

            //2、Automapper使用实例方法创建映射

            //ViewBag.Tips = "2、Automapper使用实例方法创建映射";

            //MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.CreateMap<Models.Class1, Models.Class2>());

            //var mapper = configuration.CreateMapper();

            //var productDTO = mapper.Map<Models.Class2>(c);

            //3、使用Profie配置实现映射关系

            ViewBag.Tips = "3、使用Profie配置实现映射关系";

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<Helper.Class2>());

            var productDTO = configuration.CreateMapper().Map<Models.Class2>(c);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}