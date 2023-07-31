#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Global settings for Epic Stage App integration.</summary>
[CppInclude("StageAppSettings.h")]
public partial class UStageAppSettings : UDeveloperSettings {
	///<summary>The IP endpoint to listen to for app discovery messages.</summary>
	public string DiscoveryEndpoint;
	///<summary>The port to listen to for app discovery messages.</summary>
	public int DiscoveryPort;
	///<summary>How many seconds to wait for app discovery messages.</summary>
	public float DiscoverySocketWaitTime;
}
