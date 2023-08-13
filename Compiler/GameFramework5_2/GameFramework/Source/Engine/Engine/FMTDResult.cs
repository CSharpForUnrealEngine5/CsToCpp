namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing information about minimum translation direction (MTD)</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FMTDResult {
	public FVector Direction;
	public float Distance;
}
