#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties</summary>
[CppInclude("UVProjectionTool.h")]
public partial class UUVProjectionToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Shape and/or algorithm to use for UV projection</summary>
	public EUVProjectionMethod ProjectionType;
	///<summary>Width, length, and height of the projection shape before rotation</summary>
	public FVector Dimensions;
	///<summary>If true, changes to Dimensions result in all components be changed proportionally</summary>
	public bool bProportionalDimensions;
	///<summary>Determines how projection settings will be initialized; this only takes effect if the projection shape dimensions or position are unchanged</summary>
	public EUVProjectionToolInitializationMode Initialization;
	///<summary>Angle in degrees to determine whether faces should be assigned to the cylinder or the flat end caps</summary>
	public float CylinderSplitAngle;
	///<summary>Blend between surface normals and projection normal; ExpMap projection becomes Plane projection when this value is 1</summary>
	public float ExpMapNormalBlending;
	///<summary>Number of smoothing steps to apply; this slightly increases distortion but produces more stable results.</summary>
	public int ExpMapSmoothingSteps;
	///<summary>Smoothing parameter; larger values result in faster smoothing in each step.</summary>
	public float ExpMapSmoothingAlpha;
	///<summary>Rotation in degrees applied after computing projection</summary>
	public float Rotation;
	///<summary>Scaling applied after computing projection</summary>
	public FVector2D Scale;
	///<summary>Translation applied after computing projection</summary>
	public FVector2D Translation;
	///<summary>Saved State. These are used internally to support UsePrevious initialization mode</summary>
	public FVector SavedDimensions;
	///<summary>bSavedProportionalDimensions</summary>
	public bool bSavedProportionalDimensions;
	///<summary>SavedTransform</summary>
	public FTransform SavedTransform;
}
