using Android.Views;
using Google.Android.Material.Button;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using AView = Android.Views.View;

namespace MauiApp2.Platforms.Android
{
    public partial class CustomButtonHandler : ButtonHandler
    {
        CustomButtonTouchListener TouchListener { get; } = new CustomButtonTouchListener();
        CustomButtonClickListener ClickListener { get; } = new CustomButtonClickListener();

        protected override MaterialButton CreatePlatformView()
        {
            MaterialButton platformButton = new MauiMaterialButton(Context)
            {
                IconGravity = MaterialButton.IconGravityTextStart,
                SoundEffectsEnabled = false
            };

            return platformButton;
        }

        protected override void ConnectHandler(MaterialButton platformView)
        {
            ClickListener.Handler = this;
            platformView.SetOnClickListener(ClickListener);

            TouchListener.Handler = this;
            platformView.SetOnTouchListener(TouchListener);
        }

        public static void OnClick(IButton? button, AView? v)
        {
            button?.Clicked();
        }

        public static bool OnTouch(IButton? button, AView? v, MotionEvent? e)
        {
            switch (e?.ActionMasked)
            {
                case MotionEventActions.Down:
                    button?.Pressed();
                    break;
                case MotionEventActions.Cancel:
                case MotionEventActions.Up:
                    button?.Released();
                    break;
            }

            return false;
        }
    }
    class CustomButtonClickListener : Java.Lang.Object, AView.IOnClickListener
    {
        public CustomButtonHandler? Handler { get; set; }

        public void OnClick(AView? v)
        {
            CustomButtonHandler.OnClick(Handler?.VirtualView, v);
        }
    }
    class CustomButtonTouchListener : Java.Lang.Object, AView.IOnTouchListener
    {
        public CustomButtonHandler? Handler { get; set; }

        public bool OnTouch(AView? v, global::Android.Views.MotionEvent? e)
        {
            return CustomButtonHandler.OnTouch(Handler?.VirtualView, v, e);
        }
    }

}
