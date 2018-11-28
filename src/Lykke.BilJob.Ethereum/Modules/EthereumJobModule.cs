using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.Ethereum.Settings;
using Lykke.Quintessence.Settings;

namespace Lykke.BilJob.Ethereum.Modules
{
    [UsedImplicitly]
    public class EthereumJobModule : Module
    {
        private readonly AppSettings<EthereumJobSettings> _appSettings;

        public EthereumJobModule(
            AppSettings<EthereumJobSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}