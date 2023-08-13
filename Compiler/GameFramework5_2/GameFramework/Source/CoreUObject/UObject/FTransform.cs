namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transform composed of Quat/Translation/Scale.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FTransform {
	public FQuat Rotation;
	public FVector Translation;
	public FVector Scale3D;
}
