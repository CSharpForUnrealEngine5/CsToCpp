namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A point or direction FVector in 3d space.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBox3d {
	public FVector3d Min;
	public FVector3d Max;
	public bool IsValid;
}
