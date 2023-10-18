namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Asset Management framework, which can be used to discover, load, and audit game-specific asset types</summary>
[CppInclude("RemoteSessionTypes.h")]
public partial class URemoteSessionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Port that the host will listen on</summary>
	public int HostPort;
	///<summary>Time until a connection will timeout</summary>
	public int ConnectionTimeout;
	///<summary>Time until a connection will timeout when a debugger is attached</summary>
	public int ConnectionTimeoutWhenDebugging;
	///<summary>Time between pings</summary>
	public int PingTime;
	///<summary>Whether RemoteSession is functional in a shipping build</summary>
	public bool bAllowInShipping;
	///<summary>Does PIE automatically start hosting a session?</summary>
	public bool bAutoHostWithPIE;
	///<summary>Does launching a game automatically host a session?</summary>
	public bool bAutoHostWithGame;
	///<summary>Image quality (1-100)</summary>
	public int ImageQuality;
	///<summary>Framerate of images from the host (will be min of this value and the actual framerate of the game</summary>
	public int FrameRate;
	///<summary>Restrict remote session to these channels. If empty all registered channels are available</summary>
	public TArray<string> AllowedChannels;
	///<summary>Don&#39;t allow these channels to be used</summary>
	public TArray<string> DeniedChannels;
}
