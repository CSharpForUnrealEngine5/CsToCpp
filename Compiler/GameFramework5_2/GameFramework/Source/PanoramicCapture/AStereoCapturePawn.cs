namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StereoCapturePawn.h")]
public partial class AStereoCapturePawn : ADefaultPawn {
	public static UClass StaticClass() {return default;}
	///<summary>UpdateStereoAtlas</summary>
	public void UpdateStereoAtlas(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	///<summary>LeftEyeAtlas</summary>
	public UTexture2D LeftEyeAtlas;
	///<summary>RightEyeAtlas</summary>
	public UTexture2D RightEyeAtlas;
}
