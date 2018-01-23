using LiveCharts.Core.Dimensions;
using LiveCharts.Core.Drawing;

namespace LiveCharts.Core.Abstractions
{
    /// <summary>
    /// Defines a separator view.
    /// </summary>
    public interface ISeparator : IResource
    {
        /// <summary>
        /// Moves the specified point1.
        /// </summary>
        /// <param name="point1">The point1.</param>
        /// <param name="point2">The point2.</param>
        /// <param name="disposeWhenFinished">if set to <c>true</c> [dispose when finished].</param>
        /// <param name="plane">the sender plane.</param>
        /// <param name="chart">The chart.</param>
        void Move(Point point1, Point point2, bool disposeWhenFinished, Plane plane, IChartView chart);
    }
}