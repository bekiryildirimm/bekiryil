using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
namespace EzanVakti
{


    public class OzelYapimSekil : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get { return GenerateCustomShape(); }
        }
        private Geometry GenerateCustomShape()
        {
            StreamGeometry stream = new StreamGeometry();
            using (StreamGeometryContext gc = stream.Open())
            {
                gc.BeginFigure(new Point(40.0, 40.0), false, true);
                gc.ArcTo(new Point(75.0, 75.0), new Size(10.0, 20.0), 0.0, false, SweepDirection.Clockwise, true, true);
                gc.ArcTo(new Point(80.0, 80.0), new Size(10.0, 20.0), 0.0, false, SweepDirection.Clockwise, true, true);
                gc.LineTo(new Point(120.0,120.0), true, true);
            }
            return stream;
        }
    }
}