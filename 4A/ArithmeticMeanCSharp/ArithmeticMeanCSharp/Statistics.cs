using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace ArithmeticMeanCSharp
{
    class Statistics
    {
        public double avg { get; private set; } = 0.0;
        public int count { get; private set; } = 0;

        public Dictionary<string, int> distribution { get; private set; } = new Dictionary<string, int>();

        public void OnlineArithmeticMean(double number)
        {
            this.count++;
            this.avg = (this.avg * (count - 1) + number) / count;
        }

        public void OnlineDistribution(string key, int value)
        {
            if (distribution.ContainsKey(key))
            {
                distribution[key] += value;
            }
            else
            {
                distribution.Add(key, value);
            }
        }

    }


}
