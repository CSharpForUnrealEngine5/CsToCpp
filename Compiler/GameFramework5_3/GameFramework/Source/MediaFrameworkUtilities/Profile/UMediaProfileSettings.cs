namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the media profile.</summary>
[CppInclude("Profile/MediaProfileSettings.h")]
public partial class UMediaProfileSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Apply the startup media profile even when we are running a commandlet.</summary>
	public bool bApplyInCommandlet;
	///<summary>MediaSourceProxy</summary>
	public TArray<TSoftObjectPtr<UProxyMediaSource>> MediaSourceProxy;
	///<summary>MediaOutputProxy</summary>
	public TArray<TSoftObjectPtr<UProxyMediaOutput>> MediaOutputProxy;
	///<summary>The media profile to use at startup.</summary>
	public TSoftObjectPtr<UMediaProfile> StartupMediaProfile;
}
