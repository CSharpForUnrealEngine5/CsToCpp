#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A point or direction FVector in 3d space.</summary>
public partial struct FBox3d {
// Box3d
	public FVector3d Min;
	public FVector3d Max;
	public bool IsValid;
}
