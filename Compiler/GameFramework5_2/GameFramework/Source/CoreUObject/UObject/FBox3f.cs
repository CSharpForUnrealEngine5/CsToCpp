#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A point or direction FVector in 3d space.</summary>
public partial struct FBox3f {
// Box3f
	public FVector3f Min;
	public FVector3f Max;
	public bool IsValid;
}
