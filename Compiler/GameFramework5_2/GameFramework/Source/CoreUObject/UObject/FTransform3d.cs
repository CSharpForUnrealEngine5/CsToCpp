#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Transform composed of Quat/Translation/Scale.</summary>
public partial struct FTransform3d {
// Transform3d
	public FQuat4d Rotation;
	public FVector3d Translation;
	public FVector3d Scale3D;
}
