using Nancy;

namespace Demo.Nancy.FirstDemo.ModuleDemo
{
	public class CarModule : NancyModule
	{
		public CarModule()
		{
			Get["/status"] = _ => "Hello world!";
			Get["/car/{id}"] = parameters =>
			{
				int id = parameters.id;

				//return Negotiate
				//	.WithStatusCode(HttpStatusCode.OK)
				//	.WithModel(id);
				////.WithView("CarView");

				var test = new
				{
					ID = id,
					Name = "Sam Meister",
					Twitter = "@dance2die",
					Occupation = "Software Engineer"
				};

				return Response
					//.AsJson(id)
					.AsJson(test)
					.WithStatusCode(HttpStatusCode.OK);
			};

		}
	}
}