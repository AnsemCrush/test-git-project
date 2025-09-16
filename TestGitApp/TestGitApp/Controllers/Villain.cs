using Microsoft.AspNetCore.Mvc;

namespace TestGitApp.Controllers
{
    public class Villain
    {


        [HttpGet]
        public String GetAllVillains(String villainType)
        {

            return villainType;
        }
    }
}
