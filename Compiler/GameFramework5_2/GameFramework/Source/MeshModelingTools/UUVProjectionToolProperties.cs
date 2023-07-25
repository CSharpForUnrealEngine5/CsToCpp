#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVProjectionTool.h")]
///<summary>Standard properties</summary>
public partial class UUVProjectionToolProperties : UInteractiveToolPropertySet {
// UVProjectionToolProperties
	public EUVProjectionMethod ProjectionType;
	public FVector Dimensions;
	public bool bProportionalDimensions;
	public EUVProjectionToolInitializationMode Initialization;
	public float CylinderSplitAngle;
	public float ExpMapNormalBlending;
	public int ExpMapSmoothingSteps;
	public float ExpMapSmoothingAlpha;
	public float Rotation;
	public FVector2D Scale;
	public FVector2D Translation;
	public FVector SavedDimensions;
	public bool bSavedProportionalDimensions;
	public FTransform SavedTransform;
}
