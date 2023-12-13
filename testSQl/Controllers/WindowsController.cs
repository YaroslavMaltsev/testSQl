using testSQl.Interfaces;
using testSQl.Repositories;
using testSQl.Services;

namespace testSQl.Controllers
{
    public class WindowsController : IWindowsController
    {
        private readonly IWindowsRepositories _repositories = new WindowsRepositories(); 
     
        public void GetWindowsByArticleSP(string articleSP)
        {
            try
            {
                if (string.IsNullOrEmpty(articleSP))
                    throw new Exception();

                var windows = _repositories.GetWindowByArticleSP(articleSP).Result;

                if (windows == null)
                    throw new Exception();
                
                ServiceStandardMessages.ResponseMessages(windows.Chamberness, windows.ThicknessSP, windows.GlassThickness);
            }
            catch  
            {
                throw  new Exception($"Стеклопакет с таким {articleSP} артиклем не найден");
            }
            
        }
    }
}
