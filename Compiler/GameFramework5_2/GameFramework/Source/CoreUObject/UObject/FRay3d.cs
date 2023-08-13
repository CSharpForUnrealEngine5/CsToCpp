namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>3D Ray represented by Origin and (normalized) Direction.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FRay3d {
	public FVector3d Origin;
	public FVector3d Direction;
}
