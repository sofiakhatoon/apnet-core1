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
	    public override bool Equals(object obj)
			{
				if ( ( _value == null ) || ( obj == null ) )
					return false ;



				if (obj is string)
					return this._value.Equals((string)obj);

				throw new Exception("Cannot compare object of type [" + obj.GetType().FullName + "] to SodaString");
			}
		public static bool operator == ( YodaString dt1, string dt2 )
			{
				return dt1._value == dt2  ;
			}
				public static bool operator != ( YodaString dt1, string dt2 )
			{
				return ! ( dt1._value == dt2 ) ;
			}

	}
	public abstract class CompositionPlugin { 

	}
	public class MyCompositionPlugin : CompositionPlugin { 


	    public YodaString entype {get{return new YodaString("F");} }


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
           
	       
       		   List<MyCompositionPlugin> obj1 = new List<MyCompositionPlugin>();
		       for (int i = 0; i <= 5 - 1; i++)
				{
					obj1 = GetList(i);
				}

  
   	if(obj1[0].entype.Equals("F"))
            ViewData["Message"] = "Bad code";
	    else
	     ViewData["Message"] = "You just created a ASP.Net Core web application!";
            return View();
        }

        public IActionResult Error()
        {
            ViewData["Message"] = "We've encountered an error :(";
            return View();
        }
    }
}
