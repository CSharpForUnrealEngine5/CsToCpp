#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Values needed to convert a patch stored in some source encoding into the native (two byte int) encoding and back</summary>
[CppInclude("LandscapeTexturePatchPS.h")]
public partial struct FLandscapeHeightPatchConvertToNativeParams {
	public float ZeroInEncoding;
	public float HeightScale;
	public float HeightOffset;
}
