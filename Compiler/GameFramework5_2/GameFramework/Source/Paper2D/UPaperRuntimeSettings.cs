namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Paper2D plugin.</summary>
[CppInclude("PaperRuntimeSettings.h")]
public partial class UPaperRuntimeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enables experimental *incomplete and unsupported* texture atlas groups that sprites can be assigned to</summary>
	public bool bEnableSpriteAtlasGroups;
	///<summary>Enables experimental *incomplete and unsupported* 2D terrain spline editing. Note: You need to restart the editor when enabling this setting for the change to fully take effect.</summary>
	public bool bEnableTerrainSplineEditing;
	///<summary>Enables automatic resizing of various sprite data that is authored in texture space if the source texture gets resized (sockets, the pivot, render and collision geometry, etc...)</summary>
	public bool bResizeSpriteDataToMatchTextures;
}
