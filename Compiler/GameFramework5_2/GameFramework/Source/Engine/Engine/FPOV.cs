#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Point Of View structure used in Camera calculations</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FPOV {
	public FVector Location;
	public FRotator Rotation;
	public float FOV;
}
