using Graphics = Microsoft.Maui.Graphics;
namespace PlatformImage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnResize(object sender, EventArgs e)
        {
            var image = await LoadImageAsync();
            try
            {
               var res = image.Resize(10, 10, ResizeMode.Fit,true);
               var x = res.Width;
               await DisplayAlert("Success", "Resize returned IIImage", "Yes");
                try
                {
                     x = image.Width;
                    await DisplayAlert("Error", "Resize did not dispose Original", "Ups again");
                }
                catch (ObjectDisposedException)
                {

                }

            }
            catch (ObjectDisposedException)
            {
                await DisplayAlert("Error", "Resize returned Disposed IIImage", "Ups");
                try
                {
                    var x = image.Width;
                    await DisplayAlert("Error", "Resize did not dispose Original", "Ups again");
                }
                catch (ObjectDisposedException)
                {

                }
            }
        }

        private async Task<Graphics.IImage> LoadImageAsync()
        {
            using (Stream stream = await FileSystem.OpenAppPackageFileAsync("dotnet_bot1.png"))
            {
                return Graphics.Platform.PlatformImage.FromStream(stream);
            }
        }

        private async void OnDownSize(object sender, EventArgs e)
        {
            var image = await LoadImageAsync();
            var w = image.Width;
            var h = image.Height;
            var res = image.Downsize(10, 10,true);
            try
            {
                var x = image.Width;
                await DisplayAlert("Error", "Downsize did not dispose Original", "Ups");
            }
            catch (ObjectDisposedException)
            {
                await DisplayAlert("Success", "Downsize disposed Original image", "Yes");

            }
            var max = Math.Max(w, h);
            var factor = (10F / max);

            var scaledx = w * factor;
            var scaledy = h * factor;
            if(res.Width != scaledx || res.Height != scaledy)
            {
                if (Math.Abs(res.Width - scaledx) < 1 && Math.Abs(res.Height - scaledy) < 1)
                {
                    await DisplayAlert("Error?", "Downsize did not return expected Aspect. Do we have a rounding issue?", "Ups?");
                }
                else
                {
                    await DisplayAlert("Error?", "Downsize did not scale to Aspect.Fit. Why is it maxWidth and maxHeight if it is just resizing to what ever given value?", "Ups?");
                }
                
            }
        }
    }

}
