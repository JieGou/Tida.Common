﻿using CDO.Common.Application.Contracts.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDO.Common.Application.Common {
    [Export(typeof(IUIObjectProviderFactory))]
    class UIObjectProviderFactoryImpl: IUIObjectProviderFactory {
        public IUIObjectProvider CreateNew(object uiObject) => new UIObjectProvider(uiObject);
    }

    class UIObjectProvider : IUIObjectProvider {
        public UIObjectProvider(object uiObject) {
            this.UIObject = uiObject;
        }

        public object UIObject { get; }
    }
}
