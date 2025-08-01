using System;
using System.Collections.Generic;

namespace BTCPayServer.Plugins.Monero.Configuration
{
    public class MoneroLikeConfiguration
    {
        public Dictionary<string, MoneroLikeConfigurationItem> MoneroLikeConfigurationItems { get; set; } = [];
    }

    public class MoneroLikeConfigurationItem
    {
        public Uri DaemonRpcUri { get; set; }
        public Uri InternalWalletRpcUri { get; set; }
        public string WalletDirectory { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Uri CashCowWalletRpcUri { get; set; }
    }
}