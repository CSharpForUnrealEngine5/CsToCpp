#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingDelegates.h")]
public partial class UPixelStreamingDelegates : UObject {
// PixelStreamingDelegates
	public void FConnectedToSignallingServer() {}
	public FConnectedToSignallingServer OnConnectedToSignallingServer;
	public void FDisconnectedFromSignallingServer() {}
	public FDisconnectedFromSignallingServer OnDisconnectedFromSignallingServer;
	public void FNewConnection(string StreamerId,string PlayerId,bool QualityController) {}
	public FNewConnection OnNewConnection;
	public void FClosedConnection(string StreamerId,string PlayerId,bool WasQualityController) {}
	public FClosedConnection OnClosedConnection;
	public void FAllConnectionsClosed(string StreamerId) {}
	public FAllConnectionsClosed OnAllConnectionsClosed;
	public void FStatsChanged(string PlayerId,string StatName,float StatValue) {}
	public FStatsChanged OnStatChanged;
	public void FFallbackToSoftwareEncodering() {}
	public FFallbackToSoftwareEncodering OnFallbackToSoftwareEncodering;
}
