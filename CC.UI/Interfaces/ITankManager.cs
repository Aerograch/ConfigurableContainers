using System.Collections.Generic;

namespace CC.UI
{
    public interface ITankManager
    {
        string Title { get; }
        IList<string> SupportedTypes { get; }
        IList<string> SupportedTankConfigs { get; }
        float Volume { get; }
        float AvailableVolume { get; }
        float AvailableVolumePercent { get; }
        IReadOnlyCollection<ITankInfo> Tanks { get; }

        string GetTypeInfo(string tankType);

        bool AddTank(string tankType, float volume);
        bool RemoveTank(ITankInfo tank);

        bool AddTankConfig(string configName);
        bool RemoveTankConfig(string configName);
    }
}
