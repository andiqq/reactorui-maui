// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor;
public partial interface IStepper : IView
{
    EventCommand<ValueChangedEventArgs>? ValueChangedEvent { get; set; }
}

public partial class Stepper<T> : View<T>, IStepper where T : Microsoft.Maui.Controls.Stepper, new()
{
    public Stepper(Action<T?>? componentRefAction = null) : base(componentRefAction)
    {
        StepperStyles.Default?.Invoke(this);
    }

    EventCommand<ValueChangedEventArgs>? IStepper.ValueChangedEvent { get; set; }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && StepperStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    private EventCommand<ValueChangedEventArgs>? _executingValueChangedEvent;
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIStepper = (IStepper)this;
        if (thisAsIStepper.ValueChangedEvent != null)
        {
            NativeControl.ValueChanged += NativeControl_ValueChanged;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        var thisAsIStepper = (IStepper)this;
        if (_executingValueChangedEvent == null || _executingValueChangedEvent.IsCompleted)
        {
            _executingValueChangedEvent = thisAsIStepper.ValueChangedEvent;
            _executingValueChangedEvent?.Execute(sender, e);
        }
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.ValueChanged -= NativeControl_ValueChanged;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        if (newNode is Stepper<T> @stepper)
        {
            if (_executingValueChangedEvent != null && !_executingValueChangedEvent.IsCompleted)
            {
                @stepper._executingValueChangedEvent = _executingValueChangedEvent;
            }
        }

        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public partial class Stepper : Stepper<Microsoft.Maui.Controls.Stepper>
{
    public Stepper(Action<Microsoft.Maui.Controls.Stepper?>? componentRefAction = null) : base(componentRefAction)
    {
    }

    public Stepper(params IEnumerable<VisualNode?>? children)
    {
        if (children != null)
        {
            this.AddChildren(children);
        }
    }
}

public static partial class StepperExtensions
{
    public static T Maximum<T>(this T stepper, double maximum, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        //stepper.Maximum = maximum;
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.MaximumProperty, maximum);
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MaximumProperty, customAnimation ?? new RxDoubleAnimation(maximum));
        return stepper;
    }

    public static T Maximum<T>(this T stepper, Func<double> maximumFunc, IComponentWithState? componentWithState = null)
        where T : IStepper
    {
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.MaximumProperty, new PropertyValue<double>(maximumFunc, componentWithState));
        return stepper;
    }

    public static T Minimum<T>(this T stepper, double minimum, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        //stepper.Minimum = minimum;
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.MinimumProperty, minimum);
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MinimumProperty, customAnimation ?? new RxDoubleAnimation(minimum));
        return stepper;
    }

    public static T Minimum<T>(this T stepper, Func<double> minimumFunc, IComponentWithState? componentWithState = null)
        where T : IStepper
    {
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.MinimumProperty, new PropertyValue<double>(minimumFunc, componentWithState));
        return stepper;
    }

    public static T Value<T>(this T stepper, double value, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        //stepper.Value = value;
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.ValueProperty, value);
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.ValueProperty, customAnimation ?? new RxDoubleAnimation(value));
        return stepper;
    }

    public static T Value<T>(this T stepper, Func<double> valueFunc, IComponentWithState? componentWithState = null)
        where T : IStepper
    {
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.ValueProperty, new PropertyValue<double>(valueFunc, componentWithState));
        return stepper;
    }

    public static T Increment<T>(this T stepper, double increment, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        //stepper.Increment = increment;
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.IncrementProperty, increment);
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.IncrementProperty, customAnimation ?? new RxDoubleAnimation(increment));
        return stepper;
    }

    public static T Increment<T>(this T stepper, Func<double> incrementFunc, IComponentWithState? componentWithState = null)
        where T : IStepper
    {
        stepper.SetProperty(Microsoft.Maui.Controls.Stepper.IncrementProperty, new PropertyValue<double>(incrementFunc, componentWithState));
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Action? valueChangedAction)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new SyncEventCommand<ValueChangedEventArgs>(execute: valueChangedAction);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Action<ValueChangedEventArgs>? valueChangedAction)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new SyncEventCommand<ValueChangedEventArgs>(executeWithArgs: valueChangedAction);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Action<object?, ValueChangedEventArgs>? valueChangedAction)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new SyncEventCommand<ValueChangedEventArgs>(executeWithFullArgs: valueChangedAction);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Func<Task>? valueChangedAction, bool runInBackground = false)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new AsyncEventCommand<ValueChangedEventArgs>(execute: valueChangedAction, runInBackground);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Func<ValueChangedEventArgs, Task>? valueChangedAction, bool runInBackground = false)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new AsyncEventCommand<ValueChangedEventArgs>(executeWithArgs: valueChangedAction, runInBackground);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Func<object?, ValueChangedEventArgs, Task>? valueChangedAction, bool runInBackground = false)
        where T : IStepper
    {
        stepper.ValueChangedEvent = new AsyncEventCommand<ValueChangedEventArgs>(executeWithFullArgs: valueChangedAction, runInBackground);
        return stepper;
    }
}

public static partial class StepperStyles
{
    public static Action<IStepper>? Default { get; set; }
    public static Dictionary<string, Action<IStepper>> Themes { get; } = [];
}