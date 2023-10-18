namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Virtual Texture with locally configurable build settings.</summary>
[CppInclude("VT/VirtualTexture.h")]
public partial class UVirtualTexture2D : UTexture2D {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FVirtualTextureBuildSettings Settings;
	///<summary>bContinuousUpdate</summary>
	public bool bContinuousUpdate;
	///<summary>bSinglePhysicalSpace</summary>
	public bool bSinglePhysicalSpace;
}
