namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A rectangular 2D Box.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FBox2f {
	public FVector2f Min;
	public FVector2f Max;
	public bool bIsValid;
}
