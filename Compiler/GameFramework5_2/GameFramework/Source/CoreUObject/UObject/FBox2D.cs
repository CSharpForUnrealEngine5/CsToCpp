namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rectangular 2D Box.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBox2D {
	public FVector2D Min;
	public FVector2D Max;
	public bool bIsValid;
}
