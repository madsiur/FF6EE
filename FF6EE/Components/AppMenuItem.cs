using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace FF6EE.Components
{
    public class AppMenuItem : MenuItem
    {
        public static readonly StyledProperty<IBrush> ForeGroundColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(ForeGroundColor));

        public IBrush ForeGroundColor
        {
            get => GetValue(ForeGroundColorProperty);
            set => SetValue(ForeGroundColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> ForegroundIsDisabledColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(ForegroundIsDisabledColor));

        public IBrush ForegroundIsDisabledColor
        {
            get => GetValue(ForegroundIsDisabledColorProperty);
            set => SetValue(ForegroundIsDisabledColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BackgroundColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BackgroundColor));

        public IBrush BackgroundColor
        {
            get => GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BackgroundIsPressedColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BackgroundIsPressedColor));

        public IBrush BackgroundIsPressedColor
        {
            get => GetValue(BackgroundIsPressedColorProperty);
            set => SetValue(BackgroundIsPressedColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BackgroundIsMouseOverColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BackgroundIsMouseOverColor));

        public IBrush BackgroundIsMouseOverColor
        {
            get => GetValue(BackgroundIsMouseOverColorProperty);
            set => SetValue(BackgroundIsMouseOverColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BorderColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BorderColor));

        public IBrush BorderColor
        {
            get => GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BorderIsPressedColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BorderIsPressedColor));

        public IBrush BorderIsPressedColor
        {
            get => GetValue(BorderIsPressedColorProperty);
            set => SetValue(BorderIsPressedColorProperty, value);
        }

        public static readonly StyledProperty<IBrush> BorderIsMouseOverColorProperty =
            AvaloniaProperty.Register<AppMenuItem, IBrush>(nameof(BorderIsMouseOverColor));

        public IBrush BorderIsMouseOverColor
        {
            get => GetValue(BorderIsMouseOverColorProperty);
            set => SetValue(BorderIsMouseOverColorProperty, value);
        }
    }
}
