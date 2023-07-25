#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Profile/MediaProfileSettings.h")]
///<summary>Settings for the media profile.</summary>
public partial class UMediaProfileSettings : UObject {
// MediaProfileSettings
	public bool bApplyInCommandlet;
	public TArray<TSoftObjectPtr<UProxyMediaSource>> MediaSourceProxy;
	public TArray<TSoftObjectPtr<UProxyMediaOutput>> MediaOutputProxy;
	public TSoftObjectPtr<UMediaProfile> StartupMediaProfile;
}
