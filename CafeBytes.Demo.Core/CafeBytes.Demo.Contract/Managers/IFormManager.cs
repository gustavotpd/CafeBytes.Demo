using System;
using System.Threading.Tasks;

namespace CafeBytes.Demo.Contract
{
	public interface IFormManager
	{
		Task RegisterUser (object user);
	}
}

