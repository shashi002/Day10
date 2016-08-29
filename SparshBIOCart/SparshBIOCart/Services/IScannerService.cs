using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface IScanner
    {
        Task<ScanResult> Scan();
    }

    public class ScanResult
    {
        public string Text { get; set; }
    }
}