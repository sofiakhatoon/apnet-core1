using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplication.Controllers
{

public struct YodaString{
    private string _value ;
    public YodaString( string value ) 
		{
            this._value = value;
		}
}
public abstract class CompositionPlugin { 
    
}
public class MyCompositionPlugin : CompositionPlugin { 
      private string _value ;
    
    public YodaString value {get{return new YodaString("F");} }
    	public override bool Equals(object obj)
		{
			if ( ( _value == null ) || ( obj == null ) )
				return false ;

			

			if (obj is string)
				return this._value.Equals((string)obj);

			throw new Exception("Cannot compare object of type [" + obj.GetType().FullName + "] to yodaString");
		}
}
    public class HomeController : Controller
    {
     private static List<MyCompositionPlugin> GetList(int key){
        List<MyCompositionPlugin> obj1 = new List<MyCompositionPlugin>();

        obj1.Add(new MyCompositionPlugin());   
        obj1.Add(new MyCompositionPlugin());   
        obj1.Add(new MyCompositionPlugin());  
        return obj1;
    }
        public IActionResult Index()
        {
            ViewData["Message"] = "You just created a ASP.Net Core web application!";
        Object obj1 = typeof(Type);
        Object obj2 = typeof(String);
     
           if(obj2.Equals(obj2)){ 
            return null;
            }
           
            return View();
        }

        public IActionResult Error()
        {
            ViewData["Message"] = "We've encountered an error :(";
            return View();
        }
    }
}
