namespace WPF_Basics.DI
{
    public interface IViewContainer
    {
        BindingWindow BindingWindow { get; }
        StylesWindow StylesWindow { get; }
    }
}