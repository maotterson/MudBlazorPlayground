using MudBlazor;

namespace MudBlazorPlayground.Shared.Utils.Snackbar;
public static class SnackbarUtils
{
    public static void SetSnackbarConfiguration(this SnackbarConfiguration snackbarConfiguration)
    {
        snackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomCenter;
        snackbarConfiguration.PreventDuplicates = true;
        snackbarConfiguration.NewestOnTop = false;
        snackbarConfiguration.ShowCloseIcon = true;
        snackbarConfiguration.VisibleStateDuration = 10000;
        snackbarConfiguration.HideTransitionDuration = 500;
        snackbarConfiguration.ShowTransitionDuration = 500;
        snackbarConfiguration.SnackbarVariant = Variant.Filled;
    }
}
