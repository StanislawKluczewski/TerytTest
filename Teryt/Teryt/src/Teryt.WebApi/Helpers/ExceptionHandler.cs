using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Teryt.WebApi.Helpers
{
    public class ExceptionHandler
    {
        public int GetException(Object command, Type checkClass)
        {
			try
			{
				if(command is null)
				{
					throw new Exception("Not Found");
				}
				else if(command.GetType() != checkClass)
				{
					throw new Exception("Bad Request");
				}
			}
			catch (Exception ex)
			{
                if (ex.Message == "Not Found")
                {
                    return 404;
                }
                else if (ex.Message == "Bad Request")
                {
                    return 400;
                }
                else
                {
                    return 500;
                }
            }
            return 200;
        }
    }
}
