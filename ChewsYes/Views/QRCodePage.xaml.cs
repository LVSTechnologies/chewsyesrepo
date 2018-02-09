using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ZXing.Mobile;

namespace ChewsYes.Views
{
    public partial class QRCodePage : ContentPage
    {
        public QRCodePage()
        {
            InitializeComponent();

            var Options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                PossibleFormats = new List<ZXing.BarcodeFormat>
                {
                    ZXing.BarcodeFormat.QR_CODE,
                    ZXing.BarcodeFormat .CODE_39
                },

                UseFrontCameraIfAvailable = false,
                UseCode39ExtendedMode = true
            };
            zxing.Options = Options;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            zxing.IsScanning = true;
        }

        private void zxing_OnScanResult(ZXing.Result result)
        {
            try
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    zxing.IsAnalyzing = false;
                    await DisplayAlert("Scan Result", result.Text, "OK");
                    zxing.IsAnalyzing = true;
                });
            }
            catch (Exception ex)
            {
            }
        }
    }
}
