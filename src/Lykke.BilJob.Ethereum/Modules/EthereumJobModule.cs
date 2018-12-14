using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.Ethereum.Settings;
using Lykke.Quintessence.Core.DependencyInjection;
using Lykke.Quintessence.Core.Telemetry.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilJob.Ethereum.Modules
{
    [UsedImplicitly]
    public class EthereumJobModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumJobSettings>> _appSettings;

        public EthereumJobModule(
            IReloadingManager<AppSettings<EthereumJobSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            var chainId = _appSettings.CurrentValue.Job.IsMainNet ? 1 : 3;
            
            builder
                .UseAITelemetryConsumer()
                .UseChainId(chainId);
        }
    }
}