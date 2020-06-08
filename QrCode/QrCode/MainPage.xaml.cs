namespace QrCode
{
    using QrCode.Services;
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;
    using Xamarin.Forms;


    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly DialogService dialogService;
        public MainPage()
        {
            InitializeComponent();
            dialogService = new DialogService();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await OpenScan();
        }

        private async Task OpenScan()
        {
            IQrCodeScanningService scanner = DependencyService.Get<IQrCodeScanningService>();
            string result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {

                string QrCode = result;
                await dialogService.ShowMessage("QrCode", QrCode);

            }
        }
    }
}
