#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>AR camera intrinsics</summary>
public partial struct FARCameraIntrinsics {
// ARCameraIntrinsics
	public FIntPoint ImageResolution;
	public FVector2D FocalLength;
	public FVector2D PrincipalPoint;
}
