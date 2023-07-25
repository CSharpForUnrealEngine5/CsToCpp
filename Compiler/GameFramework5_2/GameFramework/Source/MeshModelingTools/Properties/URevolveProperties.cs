#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RevolveProperties.h")]
///<summary>Common properties for revolving a PolyPath to create a mesh.</summary>
public partial class URevolveProperties : UInteractiveToolPropertySet {
// RevolveProperties
	public double RevolveDegreesClamped;
	public double RevolveDegrees;
	public double RevolveDegreesOffset;
	public double StepsMaxDegrees;
	public bool bExplicitSteps;
	public int NumExplicitSteps;
	public double HeightOffsetPerDegree;
	public bool bReverseRevolutionDirection;
	public bool bFlipMesh;
	public bool bSharpNormals;
	public double SharpNormalsDegreeThreshold;
	public bool bPathAtMidpointOfStep;
	public ERevolvePropertiesPolygroupMode PolygroupMode;
	public ERevolvePropertiesQuadSplit QuadSplitMode;
}
