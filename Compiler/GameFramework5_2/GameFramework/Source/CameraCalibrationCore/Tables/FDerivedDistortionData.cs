#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derived data computed from parameters or stmap</summary>
[CppInclude("Tables/STMapTable.h")]
public partial struct FDerivedDistortionData {
	public FDistortionData DistortionData;
	public UTextureRenderTarget2D UndistortionDisplacementMap;
	public UTextureRenderTarget2D DistortionDisplacementMap;
}
