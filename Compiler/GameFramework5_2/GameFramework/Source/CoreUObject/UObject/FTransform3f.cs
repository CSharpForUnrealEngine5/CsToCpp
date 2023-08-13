namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transform composed of Quat/Translation/Scale.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FTransform3f {
	public FQuat4f Rotation;
	public FVector3f Translation;
	public FVector3f Scale3D;
}
