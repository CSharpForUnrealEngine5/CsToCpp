#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial struct FDisplayClusterConfigurationNetworkSettings {
	public int ConnectRetriesAmount;
	public int ConnectRetryDelay;
	public int GameStartBarrierTimeout;
	public int FrameStartBarrierTimeout;
	public int FrameEndBarrierTimeout;
	public int RenderSyncBarrierTimeout;
}
