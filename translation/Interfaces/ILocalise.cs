using System;
namespace translation
{
	public interface ILocalise
	{
		string GetCurrent();

		void SetLocale();
	}
}
