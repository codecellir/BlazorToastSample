namespace BlazorToastSample.Services
{
    public class ToastService
    {
        public event Action<string, ToastLevel>? OnShow;
        public event Action? OnClose;

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
        }

        public void CloseToast() => OnClose?.Invoke();
    }

    public enum ToastLevel : byte
    {
        Info,
        Success,
        Warning,
        Error
    };
    public enum ToastPosition : byte
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Center
    };
}
