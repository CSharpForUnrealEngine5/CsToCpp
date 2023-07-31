#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A point or direction FVector in 3d space.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBox3f {
	public FVector3f Min;
	public FVector3f Max;
	public bool IsValid;
}
