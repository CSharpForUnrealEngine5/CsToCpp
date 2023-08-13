namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A bounding box.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBox {
	public FVector Min;
	public FVector Max;
	public bool IsValid;
}
