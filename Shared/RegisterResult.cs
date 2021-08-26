using System.Collections.Generic;

namespace AuthenticationBlazorWebAssembly.Server.Controllers
{
    public class RegisterResult 
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}