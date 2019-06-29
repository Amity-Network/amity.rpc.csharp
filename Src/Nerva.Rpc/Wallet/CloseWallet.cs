using System;

namespace Nerva.Rpc.Wallet
{
    public class CloseWallet : Request<object, string>
    {
        public CloseWallet(Action<string> completeAction, Action<RequestError> failedAction,
            string host = Config.DEFAULT_HOST, uint port = Config.DEFAULT_PORT, Log log = null)
            : base (null, completeAction, failedAction, host, port, log) { }

        protected override bool DoRequest(out string result) => JsonRpcRequest("close_wallet", null, out result);
    }
}