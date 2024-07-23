using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;

namespace FlexLayoutDemo.CustomLayout;

public class DashboardLayout : Layout<View>
{
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        foreach (var child in Children)
        {
            if (!(child is View view))
                continue;

            // Positionner chaque enfant selon ses coordonnées spécifiques
            Microsoft.Maui.Controls.AbsoluteLayout.SetLayoutBounds(view, new Rect(x, y, width, height));
        }
    }

    protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
    {
        // Mesurer le layout en fonction des contraintes spécifiées
        double totalWidth = 0;
        double totalHeight = 0;

        foreach (var child in Children)
        {
            var childSize = child.Measure(widthConstraint, heightConstraint);
            totalWidth = Math.Max(totalWidth, childSize.Request.Width);
            totalHeight = Math.Max(totalHeight, childSize.Request.Height);
        }

        return new SizeRequest(new Size(totalWidth, totalHeight));
    }
}