namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the video input tab.</summary>
[CppInclude("MediaFrameworkVideoInputSettings.h")]
public partial class UMediaFrameworkVideoInputSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MediaBundles</summary>
	public TArray<TSoftObjectPtr<UMediaBundle>> MediaBundles;
	///<summary>MediaSources</summary>
	public TArray<FMediaFrameworkVideoInputSourceSettings> MediaSources;
	///<summary>bReopenMediaBundles</summary>
	public bool bReopenMediaBundles;
	///<summary>bReopenMediaSources</summary>
	public bool bReopenMediaSources;
	///<summary>ReopenDelay</summary>
	public float ReopenDelay;
	///<summary>bIsVerticalSplitterOrientation</summary>
	public bool bIsVerticalSplitterOrientation;
}
