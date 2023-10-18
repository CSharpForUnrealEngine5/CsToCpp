namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AR camera intrinsics</summary>
[CppInclude("ARTypes.h")]
public partial struct FARCameraIntrinsics {
	public FIntPoint ImageResolution;
	public FVector2D FocalLength;
	public FVector2D PrincipalPoint;
}
