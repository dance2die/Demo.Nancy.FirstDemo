using Nancy;

namespace Demo.Nancy.FirstDemo.ModuleDemo
{
	public class CarModule : NancyModule
	{
		public CarModule()
		{
			Get["/status"] = _ => "Hello world!";
		}
	}
}