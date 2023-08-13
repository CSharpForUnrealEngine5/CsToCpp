namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Point Of View structure used in Camera calculations</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FPOV {
	public FVector Location;
	public FRotator Rotation;
	public float FOV;
}
