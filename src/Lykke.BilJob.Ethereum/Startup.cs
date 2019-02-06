using JetBrains.Annotations;
using Lykke.BilJob.Ethereum.Modules;
using Lykke.BilJob.Ethereum.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilJob.Ethereum
{
    [UsedImplicitly]
    public class Startup : JobStartupBase<EthereumJobSettings>
    {
        protected override string IntegrationName
            => "Ethereum";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumJobModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}