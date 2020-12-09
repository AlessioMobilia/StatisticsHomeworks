using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace RandomWalk
{
    public class Charts
    {

        public double minX { set; get; }
        public double maxX { set; get; }
        public double minY { set; get; }
        public double maxY { set; get; }
        public Rectangle viewPort { set; get; }
        public Pen viewPortPen { set; get; } = new Pen(Brushes.DeepSkyBlue);
        public Font drawFont { set; get; } = new Font("Arial", 8, FontStyle.Regular);
        public Font tableFont { set; get; } = new Font("Arial", 8, FontStyle.Regular);
        public Pen axisPen { set; get; } = new Pen(Brushes.Black, 2.0f);


        public Pen tablePen { set; get; } = new Pen(Brushes.Black, 1.0f);
        public Pen linePen { set; get; } = new Pen(Brushes.DarkBlue, 1.8f);
        public Brush pointBrush { set; get; } = Brushes.Blue;
        public SolidBrush histrogramBrush = new SolidBrush(Color.FromArgb(50, Color.DarkRed));
        public SolidBrush histrogramYBrush = new SolidBrush(Color.FromArgb(50, Color.LightSeaGreen));
        public Pen histrogramPen { set; get; } = new Pen(Brushes.Black, 1.0f);
        public Pen trueMeanPen { set; get; } = new Pen(Brushes.LightBlue, 0.5f);
        public SolidBrush fontBrush { set; get; } = new SolidBrush(Color.DarkBlue);
        public Pen RugPen { set; get; } = new Pen(Brushes.DarkGray, 1.0f);
        public Pen functionPen { set; get; } = new Pen(Brushes.DarkBlue, 2.0f);


        //for motion
        private Rectangle viewport_mouse_down;
        private Point MouseLocation_at_mouse_down;
        private bool draggingStarted = false;
        private bool resizingStarted = false;
        private double RangeX_mouse_down;
        private double RangeY_mouse_down;
        private double maxX_mouse_down;
        private double maxY_mouse_down;
        private double minX_mouse_down;
        private double minY_mouse_down;


        public void DrawViewport(Graphics g)
        {
            viewPortPen.Width = 3.0f;
            g.DrawRectangle(viewPortPen, viewPort);
        }

        public void drawHorizzontalLine(double y, string label, Graphics g)
        {

            g.DrawLine(axisPen, XRefactor(minX), YRefactor(y), XRefactor(maxX), YRefactor(y));
            SizeF size = g.MeasureString(label, drawFont);
            g.DrawString(label, drawFont, fontBrush, XRefactor(minX) - size.Width - 5, YRefactor(y) - size.Height / 2);


        }


        public void drawLabelWOffset(double x, double y, string label, Graphics g)
        {

            SizeF size = g.MeasureString(label, drawFont);
            g.DrawString(label, drawFont, fontBrush, XRefactor(x) - size.Width - 5, YRefactor(y));

        }

        public void drawLabel(double x, double y, string label, Graphics g)
        {

            SizeF size = g.MeasureString(label, drawFont);
            g.DrawString(label, drawFont, fontBrush, XRefactor(x), YRefactor(y));

        }

        public void drawVerticalLine(double x, Graphics g)
        {

            g.DrawLine(axisPen, XRefactor(x), YRefactor(minY), XRefactor(x), XRefactor(maxY));

        }


        public void DrawTable(List<int[]> table, List<Interval> distX, List<Interval> distY, Graphics g)
        {
            int width = viewPort.Width / (table[0].Length + 1);
            int height = viewPort.Height / (table.Count + 1);

            //draw vertical lines
            for (int i = 0; i <= viewPort.Width; i += width)
            {
                float endy = viewPort.Height + viewPort.Y - (viewPort.Height % (table.Count + 1));
                g.DrawLine(tablePen, i + viewPort.X, 0 + viewPort.Y, i + viewPort.X, endy);
            }

            //draw horizontal lines
            for (int i = 0; i <= viewPort.Height; i += height)
            {
                float endx = (viewPort.Width + viewPort.X) - (viewPort.Width % (table[0].Length + 1));
                g.DrawLine(tablePen, 0 + viewPort.X, i + viewPort.Y, endx, i + viewPort.Y);
            }

            SizeF stringSize = new SizeF();
            stringSize = g.MeasureString("G", tableFont);


            //draw ranges
            int y = viewPort.Y - (int)stringSize.Height + height;
            int x = viewPort.X + (width / 2) - (int)stringSize.Width;

            g.DrawString("range", tableFont, fontBrush, x, y);
            x += width;
            //ranges on the first row
            for (int i = 0; i < distY.Count; i++)
            {

                g.DrawString("R" + i.ToString(), tableFont, fontBrush, x, y);
                x += width;
            }
            //ranges on the first column
            y = viewPort.Y - (int)stringSize.Height + height + height;
            x = viewPort.X + (width / 2) - (int)stringSize.Width;
            for (int i = 0; i < distX.Count; i++)
            {
                g.DrawString("R" + i.ToString(), tableFont, fontBrush, x, y);
                y += height;
            }



            //print values
            y = viewPort.Y - (int)stringSize.Height + height + height;
            x = viewPort.X + (width / 2) - (int)stringSize.Width;
            foreach (int[] row in table)
            {

                x = viewPort.X + (width / 2) - (int)stringSize.Width + width;
                foreach (int element in row)
                {
                    g.DrawString(element.ToString(), tableFont, fontBrush, x, y);
                    x += width;
                }

                y += height;
            }


        }

        public void DrawHistogram(List<Interval> intervals, Graphics g)
        {

            int i = 0;
            foreach (Interval inter in intervals)
            {
                double range = Math.Abs(inter.end - inter.start);
                int height = (int)(inter.freq*this.viewPort.Height);
                int x;
                if (inter.start > minX)
                    x = XRefactor(inter.start);
                else
                    x = XRefactor(minX);

                int y = YRefactor(minY) - height;

                int width;
                if (inter.end > maxX)
                    width = XRefactor(maxX) - x;
                else
                    width = XRefactor(inter.end) - x;
                Rectangle rect = new Rectangle(x, y, width, height);
                g.FillRectangle(histrogramBrush, rect);
                g.FillRectangle(histrogramBrush, rect);
                g.DrawRectangle(histrogramPen, rect);

                i++;

            }
        }

        public void DrawHorizzontalRectangles(List<Interval> intervals, int X, Graphics g)
        {

            Rectangle[] rectangles = new Rectangle[intervals.Count];
            int i = 0;
            foreach (Interval inter in intervals)
            {
                if (inter.start < maxY && inter.end > minY)
                {
                    double range = Math.Abs(inter.end - inter.start);

                    int width = (int)(inter.freq * viewPort.Width / 5);
                    //int width = YRefactor(inter.value);
                    int y;
                    if (inter.end < maxY)
                        y = YRefactor(inter.end);
                    else
                        y = YRefactor(maxY);
                    int x = XRefactor(X);

                    int height;
                    if (inter.start < minY)
                        height = Math.Abs(YRefactor(inter.end) - YRefactor(minY));
                    else
                        height = Math.Abs(YRefactor(inter.end) - YRefactor(inter.start));

                    if (inter.end > maxY)
                        height = Math.Abs(YRefactor(maxY) - YRefactor(inter.start));

                    Rectangle rect = new Rectangle(x, y, width, height);
                    g.FillRectangle(histrogramYBrush, rect);
                    g.DrawRectangle(histrogramPen, rect);

                }
                i++;

            }
        }





        public void DrawRugPlot(List<DataPoint> points, Graphics g)
        {
            foreach (DataPoint point in points)
            {
                if (point.X > minX && point.X < maxX && point.Y > minY && point.Y < maxY)
                {
                    g.DrawLine(RugPen, XRefactor(point.X), YRefactor(minY), XRefactor(point.X), YRefactor(minY) - 10);
                    g.DrawLine(RugPen, XRefactor(minX), YRefactor(point.Y), XRefactor(minX) + 10, YRefactor(point.Y));
                }

            }
        }

        public void DrawYHistogram(List<Interval> intervals, int countTotal, Graphics g)
        {

            Rectangle[] rectangles = new Rectangle[intervals.Count];
            int i = 0;
            foreach (Interval inter in intervals)
            {
                if (inter.start < maxY && inter.end > minY)
                {
                    double range = Math.Abs(inter.end - inter.start);

                    int width = inter.value;
                    //int width = YRefactor(inter.value);
                    int y;
                    if (inter.end < maxY)
                        y = YRefactor(inter.end);
                    else
                        y = YRefactor(maxY);
                    int x = XRefactor(minX);

                    int height;
                    if (inter.start < minY)
                        height = Math.Abs(YRefactor(inter.end) - YRefactor(minY));
                    else
                        height = Math.Abs(YRefactor(inter.end) - YRefactor(inter.start));

                    if (inter.end > maxY)
                        height = Math.Abs(YRefactor(maxY) - YRefactor(inter.start));

                    Rectangle rect = new Rectangle(x, y, width, height);
                    g.FillRectangle(histrogramYBrush, rect);
                    g.DrawRectangle(histrogramPen, rect);

                }
                i++;

            }

        }

        public void DrawTrueMeanY(List<Interval> intervals, Graphics g)
        {
            foreach (Interval inter in intervals)
            {
                if (inter.trueMean > minY && inter.trueMean < maxY)
                    g.DrawLine(trueMeanPen, XRefactor(minX), YRefactor(inter.trueMean), XRefactor(maxX), YRefactor(inter.trueMean));
            }
        }

        public void DrawRangeLabel(List<Interval> intervalsX, List<Interval> intervalsY, Graphics g)
        {
            foreach (Interval inter in intervalsY)
            {
                if (inter.end > minY && inter.end < maxY)
                    g.DrawString(inter.end.ToString(), drawFont, fontBrush, XRefactor(minX) - g.MeasureString(inter.end.ToString(), drawFont).Width, YRefactor(inter.end));

            }
            foreach (Interval inter in intervalsX)
            {
                if (inter.start > minX && inter.start < maxX)
                {
                    if (inter.start > minX)
                        g.DrawString(inter.end.ToString(), drawFont, fontBrush, XRefactor(inter.start), YRefactor(minY));
                }


            }
        }

        public void DrawTrueMeanX(List<Interval> intervals, Graphics g)
        {
            foreach (Interval inter in intervals)
            {
                if (inter.trueMean > minX && inter.trueMean < maxX)
                    g.DrawLine(trueMeanPen, XRefactor(inter.trueMean), YRefactor(minY), XRefactor(inter.trueMean), YRefactor(maxY));
            }
        }

        public void DrawPoints(List<DataPoint> Points, Graphics g, bool label = false)
        {


            foreach (DataPoint RealPoint in Points)
            {

                if (RealPoint.X > minX && RealPoint.X < maxX && RealPoint.Y > minY && RealPoint.Y < maxY)
                {
                    Point p = pointRefactor(RealPoint);
                    g.FillEllipse(pointBrush, p.X - 2, p.Y - 2, 4, 4);
                    if (label)
                        g.DrawString(RealPoint.X.ToString() + "," + RealPoint.Y.ToString(), drawFont, fontBrush, p);
                }

            }
        }

        public void DrawAxis(Graphics g)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            axisPen.CustomEndCap = bigArrow;

            //draw Y
            if (minX <= 0)
            {


                Point yStart = pointRefactor(new DataPoint(0, minY));
                Point yEnd = pointRefactor(new DataPoint(0, maxY));
                g.DrawLine(axisPen, yStart, yEnd);
            }

            //draw X
            if (minY <= 0)
            {
                Point xStart = pointRefactor(new DataPoint(minX, 0.00));
                Point xEnd = pointRefactor(new DataPoint(maxX, 0.00));
                g.DrawLine(axisPen, xStart, xEnd);
            }

        }


        public void DrawFunction(Func<double, double> f, double minX, double maxX, double step, Graphics g)
        {
            double x = minX;
            List<Point> points = new List<Point>();
            double y;
            do
            {
                y = (f(x));
                points.Add(new Point(XRefactor(x), YRefactor(y)));
                x += step;

            } while (x <= maxX);

            g.DrawLines(functionPen, points.ToArray());
        }


        public void DrawLine(List<DataPoint> realPoints, Graphics g)
        {
            List<Point> points = new List<Point>();

            foreach (DataPoint p in realPoints)
            {

                points.Add(new Point(XRefactor(p.X), YRefactor(p.Y)));

            }

            g.DrawLines(linePen, points.ToArray());
        }



        //adapt the real point to the viewport
        public Point pointRefactor(DataPoint p)
        {
            Point point = new Point();
            point.X = XRefactor(p.X);
            point.Y = YRefactor(p.Y);

            return point;

        }

        //adapt the X to the viewport
        public int XRefactor(double X)
        {
            double rangeX = maxX - minX;
            return (int)(viewPort.X + viewPort.Width * (X - minX) / rangeX);

        }

        //adapt the Y to the viewport
        public int YRefactor(double Y)
        {
            double rangeY = maxY - minY;
            return (int)(viewPort.Y + viewPort.Height - viewPort.Height * (Y - minY) / rangeY);

        }


        public void MouseDown(MouseEventArgs e)
        {
            if (viewPort.Contains(e.X, e.Y))
            {
                RangeX_mouse_down = maxX - minX;
                RangeY_mouse_down = maxY - minY;
                maxX_mouse_down = maxX;
                maxY_mouse_down = maxY;
                minX_mouse_down = minX;
                minY_mouse_down = minY;

                viewport_mouse_down = viewPort;
                this.MouseLocation_at_mouse_down = new Point(e.X, e.Y);

                if (e.Button == MouseButtons.Left)
                    draggingStarted = true;
                else
                    resizingStarted = true;

            }

        }

        public void MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draggingStarted && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                double deltaX = this.RangeX_mouse_down * (e.X - this.MouseLocation_at_mouse_down.X) / this.viewPort.Width;
                double deltaY = this.RangeY_mouse_down * (e.Y - this.MouseLocation_at_mouse_down.Y) / this.viewPort.Width;

                maxX = maxX_mouse_down - deltaX;
                minX = minX_mouse_down - deltaX;

                maxY = maxY_mouse_down + deltaY;
                minY = minY_mouse_down + deltaY;



            }
            else if (e.Button == MouseButtons.Right && resizingStarted && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {

                double deltaX = RangeX_mouse_down * (e.X - this.MouseLocation_at_mouse_down.X) / this.viewPort.Width;
                double deltaY = RangeY_mouse_down * (e.Y - this.MouseLocation_at_mouse_down.Y) / this.viewPort.Height;

                maxX = maxX_mouse_down - deltaX;
                minY = minY_mouse_down + deltaY;




            }
            else if (e.Button == MouseButtons.Left && draggingStarted)
            {
                int deltaX = e.X - this.MouseLocation_at_mouse_down.X;
                int deltaY = e.Y - this.MouseLocation_at_mouse_down.Y;

                Rectangle viewPort = new Rectangle(viewport_mouse_down.Location, viewport_mouse_down.Size);
                viewPort.X += deltaX;
                viewPort.Y += deltaY;

                this.viewPort = viewPort;
            }
            else if (e.Button == MouseButtons.Right && resizingStarted)
            {

                int deltaX = e.X - this.MouseLocation_at_mouse_down.X;
                int deltaY = e.Y - this.MouseLocation_at_mouse_down.Y;

                Rectangle viewPort = new Rectangle(viewport_mouse_down.Location, viewport_mouse_down.Size);
                viewPort.Width += deltaX;
                viewPort.Height += deltaY;

                if (viewPort.Width > 30 && viewPort.Height > 30)
                    this.viewPort = viewPort;

            }


        }

        public void MouseUp(MouseEventArgs e)
        {
            draggingStarted = false;
            resizingStarted = false;
        }

        public void MouseWheel(MouseEventArgs e)
        {
            if (viewPort.Contains(e.X, e.Y))
            {
                RangeX_mouse_down = maxX - minX;
                RangeY_mouse_down = maxY - minY;
                maxX_mouse_down = maxX;
                maxY_mouse_down = maxY;
                minX_mouse_down = minX;
                minY_mouse_down = minY;

                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {

                    double ChangeX = this.RangeX_mouse_down * 40 / this.viewPort.Width;
                    double ChangeY = this.RangeY_mouse_down * ChangeX / (maxX - minX);

                    Rectangle viewport = new Rectangle(this.viewPort.Location, this.viewPort.Size);
                    if (e.Delta > 0)
                    {

                        this.minX -= ChangeX;
                        this.minY -= ChangeY;

                        //RangeX += 2 * ChangeX;
                        //RangeY += 2 * ChangeY;


                    }
                    else if (e.Delta < 0)
                    {

                        this.minX += ChangeX;
                        this.minY += ChangeY;

                        //RangeX -= 2 * ChangeX;
                        //RangeY -= 2 * ChangeY;


                    }


                }
                else
                {
                    int ChangeX = 40;
                    int ChangeY = (viewPort.Height * ChangeX) / viewPort.Width;

                    Rectangle viewport = new Rectangle(this.viewPort.Location, this.viewPort.Size);
                    if (e.Delta > 0)
                    {
                        viewport.X -= ChangeX;
                        viewport.Width += 2 * ChangeX;

                        viewport.Y -= ChangeY;
                        viewport.Height += 2 * ChangeY;

                        //if (viewport.X > 0 && viewport.Y > 0)
                        this.viewPort = viewport;

                    }
                    else if (e.Delta < 0)
                    {

                        viewport.X += ChangeX;
                        viewport.Width -= 2 * ChangeX;

                        viewport.Y += ChangeY;
                        viewport.Height -= 2 * ChangeY;

                        if (viewport.Height > 30 && viewport.Width > 30)
                            this.viewPort = viewport;

                    }
                }

            }

        }

    }



    public class DataPoint
    {
        public DataPoint(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double X;
        public double Y;
        public Point ToPoint()
        {
            return new Point((int)this.X, (int)this.Y);
        }
    }

}
