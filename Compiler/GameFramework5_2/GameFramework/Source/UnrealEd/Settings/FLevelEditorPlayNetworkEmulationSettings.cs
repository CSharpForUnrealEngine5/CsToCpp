namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlayNetworkEmulationSettings.h")]
public partial struct FLevelEditorPlayNetworkEmulationSettings {
	public bool bIsNetworkEmulationEnabled;
	public NetworkEmulationTarget EmulationTarget;
	public string CurrentProfile;
	public FNetworkEmulationPacketSettings OutPackets;
	public FNetworkEmulationPacketSettings InPackets;
}
