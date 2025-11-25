using Syncfusion.Maui.Toolkit.Charts;

namespace BCN_MauiLearning.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
