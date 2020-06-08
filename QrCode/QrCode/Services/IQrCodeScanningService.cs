namespace QrCode.Services
{
    using System.Threading.Tasks;

    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
