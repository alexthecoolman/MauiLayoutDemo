using Microsoft.Maui.Layouts;

namespace FlexLayoutDemo.CustomLayout
{
    [Serializable]
    public class CascadeLayoutManager : ILayoutManager
    {
        private readonly CascadeLayout _cascade;

        public CascadeLayoutManager(CascadeLayout cascade)
        {
            _cascade = cascade;
        }

        public Size Measure(double widthConstraint, double heightConstraint)
        {
            var padding = _cascade.Padding;
            var spacing = _cascade.Spacing;

            widthConstraint -= padding.HorizontalThickness;
            heightConstraint -= padding.VerticalThickness;

            double x = padding.Left;
            double y = padding.Top;
            double totalWidth = 0;
            double totalHeight = 0;

            foreach (var child in _cascade)
            {
                var current = child.Measure(widthConstraint, heightConstraint);

                totalWidth = Math.Max(totalWidth, x + current.Width);
                totalHeight = Math.Max(totalHeight, y + current.Height);

                x += spacing;
                y += spacing;

                widthConstraint -= spacing;
                heightConstraint -= spacing;
            }

            return new Size(totalWidth + padding.HorizontalThickness,
                totalHeight + padding.VerticalThickness);
        }

        public Size ArrangeChildren(Rect bounds)
        {
            var padding = _cascade.Padding;
            var spacing = _cascade.Spacing;

            double x = padding.Left;
            double y = padding.Top;

            double totalWidth = 0;
            double totalHeight = 0;

            foreach (var child in _cascade)
            {
                var width = child.DesiredSize.Width;
                var height = child.DesiredSize.Height;
                child.Arrange(new Rect(x, y, width, height));

                totalWidth = Math.Max(totalWidth, x + width);
                totalHeight = Math.Max(totalHeight, y + height);

                x += spacing;
                y += spacing;
            }

            return new Size(totalWidth + padding.HorizontalThickness,
                totalHeight + padding.VerticalThickness);
        }




    }
}