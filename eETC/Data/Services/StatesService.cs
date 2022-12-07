using eETC.Data.Base;
using eETC.Models;

namespace eETC.Data.Services
{
	public class StatesService :EntityBaseRepository<State> ,IStatesService
	{

		public StatesService(AppDbContext context) : base(context)
		{

		}
	}
}
