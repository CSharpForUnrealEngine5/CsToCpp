#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteSessionTypes.h")]
///<summary>Settings for the Asset Management framework, which can be used to discover, load, and audit game-specific asset types</summary>
public partial class URemoteSessionSettings : UObject {
// RemoteSessionSettings
	public int HostPort;
	public int ConnectionTimeout;
	public int ConnectionTimeoutWhenDebugging;
	public int PingTime;
	public bool bAllowInShipping;
	public bool bAutoHostWithPIE;
	public bool bAutoHostWithGame;
	public int ImageQuality;
	public int FrameRate;
	public TArray<string> AllowedChannels;
	public TArray<string> DeniedChannels;
}
