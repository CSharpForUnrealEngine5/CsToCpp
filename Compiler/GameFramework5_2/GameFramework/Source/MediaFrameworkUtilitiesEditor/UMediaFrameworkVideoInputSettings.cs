#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaFrameworkVideoInputSettings.h")]
///<summary>Settings for the video input tab.</summary>
public partial class UMediaFrameworkVideoInputSettings : UObject {
// MediaFrameworkVideoInputSettings
	public TArray<TSoftObjectPtr<UMediaBundle>> MediaBundles;
	public TArray<FMediaFrameworkVideoInputSourceSettings> MediaSources;
	public bool bReopenMediaBundles;
	public bool bReopenMediaSources;
	public float ReopenDelay;
	public bool bIsVerticalSplitterOrientation;
}
