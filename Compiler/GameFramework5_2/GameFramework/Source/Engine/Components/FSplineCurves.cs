#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
public partial struct FSplineCurves {
	public FInterpCurveVector Position;
	public FInterpCurveQuat Rotation;
	public FInterpCurveVector Scale;
	public FInterpCurveFloat ReparamTable;
	public USplineMetadata Metadata_DEPRECATED;
	public uint Version;
}
