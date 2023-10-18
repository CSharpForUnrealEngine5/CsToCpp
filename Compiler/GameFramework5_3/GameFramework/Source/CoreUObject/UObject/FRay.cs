namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>3D Ray represented by Origin and (normalized) Direction.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FRay {
	public FVector Origin;
	public FVector Direction;
}
