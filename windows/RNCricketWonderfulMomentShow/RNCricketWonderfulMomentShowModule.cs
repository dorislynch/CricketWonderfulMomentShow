using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Cricket.Wonderful.Moment.Show.RNCricketWonderfulMomentShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCricketWonderfulMomentShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCricketWonderfulMomentShowModule"/>.
        /// </summary>
        internal RNCricketWonderfulMomentShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCricketWonderfulMomentShow";
            }
        }
    }
}
