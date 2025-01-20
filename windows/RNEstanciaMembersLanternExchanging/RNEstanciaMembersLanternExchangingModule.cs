using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Estancia.Members.Lantern.Exchanging.RNEstanciaMembersLanternExchanging
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNEstanciaMembersLanternExchangingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNEstanciaMembersLanternExchangingModule"/>.
        /// </summary>
        internal RNEstanciaMembersLanternExchangingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNEstanciaMembersLanternExchanging";
            }
        }
    }
}
