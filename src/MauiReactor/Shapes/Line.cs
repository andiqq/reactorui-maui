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
namespace MauiReactor.Shapes;
public partial interface ILine : Shapes.IShape
{
}

public sealed partial class Line : Shapes.Shape<Microsoft.Maui.Controls.Shapes.Line>, ILine
{
    public Line(Action<Microsoft.Maui.Controls.Shapes.Line?>? componentRefAction = null) : base(componentRefAction)
    {
        LineStyles.Default?.Invoke(this);
    }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && LineStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public static partial class LineExtensions
{
    public static T X1<T>(this T line, double x1, RxDoubleAnimation? customAnimation = null)
        where T : ILine
    {
        //line.X1 = x1;
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.X1Property, x1);
        line.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Line.X1Property, customAnimation ?? new RxDoubleAnimation(x1));
        return line;
    }

    public static T X1<T>(this T line, Func<double> x1Func, IComponentWithState? componentWithState = null)
        where T : ILine
    {
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.X1Property, new PropertyValue<double>(x1Func, componentWithState));
        return line;
    }

    public static T Y1<T>(this T line, double y1, RxDoubleAnimation? customAnimation = null)
        where T : ILine
    {
        //line.Y1 = y1;
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.Y1Property, y1);
        line.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Line.Y1Property, customAnimation ?? new RxDoubleAnimation(y1));
        return line;
    }

    public static T Y1<T>(this T line, Func<double> y1Func, IComponentWithState? componentWithState = null)
        where T : ILine
    {
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.Y1Property, new PropertyValue<double>(y1Func, componentWithState));
        return line;
    }

    public static T X2<T>(this T line, double x2, RxDoubleAnimation? customAnimation = null)
        where T : ILine
    {
        //line.X2 = x2;
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.X2Property, x2);
        line.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Line.X2Property, customAnimation ?? new RxDoubleAnimation(x2));
        return line;
    }

    public static T X2<T>(this T line, Func<double> x2Func, IComponentWithState? componentWithState = null)
        where T : ILine
    {
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.X2Property, new PropertyValue<double>(x2Func, componentWithState));
        return line;
    }

    public static T Y2<T>(this T line, double y2, RxDoubleAnimation? customAnimation = null)
        where T : ILine
    {
        //line.Y2 = y2;
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.Y2Property, y2);
        line.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Line.Y2Property, customAnimation ?? new RxDoubleAnimation(y2));
        return line;
    }

    public static T Y2<T>(this T line, Func<double> y2Func, IComponentWithState? componentWithState = null)
        where T : ILine
    {
        line.SetProperty(Microsoft.Maui.Controls.Shapes.Line.Y2Property, new PropertyValue<double>(y2Func, componentWithState));
        return line;
    }
}

public static partial class LineStyles
{
    public static Action<ILine>? Default { get; set; }
    public static Dictionary<string, Action<ILine>> Themes { get; } = [];
}