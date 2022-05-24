using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class BaseBot
    {
        MainForm _mainForm;
        public BaseBot(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public virtual void Reset()
        {
        }
        public virtual void Step()
        {
        }
    }
}
