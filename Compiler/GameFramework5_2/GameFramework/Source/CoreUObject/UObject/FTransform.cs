#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Transform composed of Quat/Translation/Scale.</summary>
public partial struct FTransform {
// Transform
	public FQuat Rotation;
	public FVector Translation;
	public FVector Scale3D;
}
