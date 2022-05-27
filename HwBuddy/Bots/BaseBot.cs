using HwBuddy.Actions;
using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class BaseBot
    {
        protected List<AbstractStep> _steps = StepsFactory.GetDungeonSteps();

        public BaseBot(List<AbstractStep> steps)
        {
            _steps = steps;
        }

        public virtual void Reset()
        {
        }


        public virtual void Step()
        {
            foreach (var step in _steps)
            {
                if (step.IsFound())
                {
                    ImageService.DoMouseClick();
                    return;
                }
            }
        }
    }
}
