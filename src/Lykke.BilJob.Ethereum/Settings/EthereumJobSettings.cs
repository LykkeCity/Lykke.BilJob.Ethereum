using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilJob.Ethereum.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumJobSettings : JobSettings
    {
        public bool IsMainNet { get; set; }
    }
}