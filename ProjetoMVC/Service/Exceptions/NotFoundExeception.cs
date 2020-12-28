using System;


namespace ProjetoMVC.Service.Exceptions
{
    public class NotFoundExeception : ApplicationException
    {
        public NotFoundExeception(string message) : base(message)
        {
        }
    }
}
