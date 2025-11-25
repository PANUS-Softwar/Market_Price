using Syncfusion.Maui.Toolkit.Charts;

namespace CNT_MauiLearning.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
