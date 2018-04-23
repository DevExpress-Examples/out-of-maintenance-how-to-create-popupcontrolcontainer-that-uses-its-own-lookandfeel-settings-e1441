using DevExpress.XtraBars;
using System.ComponentModel;
using DevExpress.XtraBars.Controls;
using DevExpress.LookAndFeel;
using System;
using System.Reflection;

namespace DXSample {
    public class MyPopupControlContainer : PopupControlContainer {
        public MyPopupControlContainer() : base() { }
        public MyPopupControlContainer(IContainer container) : base(container) { }
        private UserLookAndFeel temp;
        protected override PopupContainerBarControl CreateSubControl(BarManager manager) {
            if (temp == null) temp = new UserLookAndFeel(this);
            temp.Assign(LookAndFeel);
            return base.CreateSubControl(manager);
        }
        protected override PopupContainerBarControl CreatePopupContainerBarControl(BarManager manager) {
            LookAndFeel.Assign(temp);
            return base.CreatePopupContainerBarControl(manager);
        }
    }
}