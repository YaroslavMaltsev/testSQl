using Microsoft.EntityFrameworkCore;
using testSQl.Data;
using testSQl.Interfaces;
using testSQl.Model;

namespace testSQl.Repositories
{
    internal class WindowsRepositories : IWindowsRepositories
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

        public WindowsRepositories()
        {
 
        }
        public async Task<DoubleGlazedWindows> GetWindowByArticleSP(string articleSP)
        {
            return await _dbContext.DoubleGlazedWindows.Where(i => i.ArticleSP == articleSP).FirstOrDefaultAsync();
        }
    }
}
