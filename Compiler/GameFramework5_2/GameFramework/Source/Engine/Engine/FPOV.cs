#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Point Of View structure used in Camera calculations</summary>
public partial struct FPOV {
// POV
	public FVector Location;
	public FRotator Rotation;
	public float FOV;
}
