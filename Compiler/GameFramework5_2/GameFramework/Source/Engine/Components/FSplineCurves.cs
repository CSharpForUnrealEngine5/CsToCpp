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
