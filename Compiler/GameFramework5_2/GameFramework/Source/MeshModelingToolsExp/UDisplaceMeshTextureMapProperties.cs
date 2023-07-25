#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplaceMeshTool.h")]
///<summary>PropertySet for properties affecting the Image Map displacement type.</summary>
public partial class UDisplaceMeshTextureMapProperties : UInteractiveToolPropertySet {
// DisplaceMeshTextureMapProperties
	public UTexture2D DisplacementMap;
	public EDisplaceMeshToolChannelType Channel;
	public float DisplacementMapBaseValue;
	public FVector2D UVScale;
	public FVector2D UVOffset;
	public bool bApplyAdjustmentCurve;
	public UCurveFloat AdjustmentCurve;
	public bool bRecalcNormals;
}
