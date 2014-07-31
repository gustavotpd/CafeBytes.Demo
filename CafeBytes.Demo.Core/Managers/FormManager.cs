using System;
using System.Threading.Tasks;
using CafeBytes.Demo.Contract;
using CafeBytes.Demo.Http;

namespace CafeBytes.Demo.Core
{
	public class FormManager : IFormManager
	{

		private readonly FormProvider _formProvider;

		public FormManager ()
		{
			_formProvider = new FormProvider ();
		}


		public Task RegisterUser (Person user)
		{
			_formProvider.RegisterUser (new Uri(),user);
		}
	}
}

