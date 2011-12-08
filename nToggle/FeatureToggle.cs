﻿using System;

namespace nToggle
{
    public class FeatureToggle : IFeatureToggle
    {
        private readonly bool isOn;

        public FeatureToggle(bool isOn)
        {
            this.isOn = isOn;
        }

        #region IFeatureToggle Members

        public void RunActionIfOff(Action offAction)
        {
            if (!IsOn)
                offAction();
        }

        public void RunActionIfOn(Action onAction)
        {
            if (IsOn)
                onAction();
        }

        public bool IsOn
        {
            get { return isOn; }
        }

        #endregion
    }
}