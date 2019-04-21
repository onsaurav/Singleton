using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Singleton.Classes
{
    public class WorkingFramWork : ICloneable 
    {
        private static WorkingFramWork _Self;
        private string _Name;
        private SolidColorBrush _Color;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public SolidColorBrush Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        private WorkingFramWork()
        {

        }

        public static WorkingFramWork Instance()
        {
            if (_Self == null)
                _Self = new WorkingFramWork();

            return _Self;
        }

        public object Clone()
        {
           return this.MemberwiseClone();
        }
    }
}
