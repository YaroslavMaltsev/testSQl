using testSQl.Model;

namespace testSQl.Interfaces
{
    public interface IWindowsRepositories
    {
        public Task<DoubleGlazedWindows> GetWindowByArticleSP(string articleSP);
    }
}
