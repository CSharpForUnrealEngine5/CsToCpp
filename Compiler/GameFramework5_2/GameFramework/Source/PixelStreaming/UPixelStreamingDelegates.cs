#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingDelegates.h")]
public partial class UPixelStreamingDelegates : UObject {
	///<summary>A connection to the signalling server was made.</summary>
	public  void FConnectedToSignallingServer() {}
	///<summary>OnConnectedToSignallingServer</summary>
	public FConnectedToSignallingServer OnConnectedToSignallingServer;
	///<summary>A connection to the signalling server was lost.</summary>
	public  void FDisconnectedFromSignallingServer() {}
	///<summary>OnDisconnectedFromSignallingServer</summary>
	public FDisconnectedFromSignallingServer OnDisconnectedFromSignallingServer;
	///<summary>A new connection has been made to the session.</summary>
	public  void FNewConnection(string StreamerId,string PlayerId,bool QualityController) {}
	///<summary>OnNewConnection</summary>
	public FNewConnection OnNewConnection;
	///<summary>A connection to a player was lost.</summary>
	public  void FClosedConnection(string StreamerId,string PlayerId,bool WasQualityController) {}
	///<summary>OnClosedConnection</summary>
	public FClosedConnection OnClosedConnection;
	///<summary>All connections have closed and nobody is viewing or interacting with</summary>
	public  void FAllConnectionsClosed(string StreamerId) {}
	///<summary>OnAllConnectionsClosed</summary>
	public FAllConnectionsClosed OnAllConnectionsClosed;
	///<summary>A pixel streaming stat has changed</summary>
	public  void FStatsChanged(string PlayerId,string StatName,float StatValue) {}
	///<summary>OnStatChanged</summary>
	public FStatsChanged OnStatChanged;
	///<summary>The GPU ran out of available HW encoders and fell back to software encoders</summary>
	public  void FFallbackToSoftwareEncodering() {}
	///<summary>OnFallbackToSoftwareEncodering</summary>
	public FFallbackToSoftwareEncodering OnFallbackToSoftwareEncodering;
}
