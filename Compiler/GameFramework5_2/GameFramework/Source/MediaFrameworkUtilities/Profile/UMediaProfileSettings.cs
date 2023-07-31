#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the media profile.</summary>
[CppInclude("Profile/MediaProfileSettings.h")]
public partial class UMediaProfileSettings : UObject {
	///<summary>Apply the startup media profile even when we are running a commandlet.</summary>
	public bool bApplyInCommandlet;
	///<summary>MediaSourceProxy</summary>
	public TArray<TSoftObjectPtr<UProxyMediaSource>> MediaSourceProxy;
	///<summary>MediaOutputProxy</summary>
	public TArray<TSoftObjectPtr<UProxyMediaOutput>> MediaOutputProxy;
	///<summary>The media profile to use at startup.</summary>
	public TSoftObjectPtr<UMediaProfile> StartupMediaProfile;
}
