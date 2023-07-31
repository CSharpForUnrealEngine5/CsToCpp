#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Outputs a float value between 0-1 based off of the driver item&#39;s rotation in a specified region.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SphericalPoseReader.h")]
public partial struct FRigUnit_SphericalPoseReader {
	public float OutputParam;
	public FRigElementKey DriverItem;
	public FVector DriverAxis;
	public FVector RotationOffset;
	public float ActiveRegionSize;
	public FRegionScaleFactors ActiveRegionScaleFactors;
	public float FalloffSize;
	public FRegionScaleFactors FalloffRegionScaleFactors;
	public bool FlipWidthScaling;
	public bool FlipHeightScaling;
	public FRigElementKey OptionalParentItem;
	public FSphericalPoseReaderDebugSettings Debug;
	public FSphericalRegion InnerRegion;
	public FSphericalRegion OuterRegion;
	public FVector DriverNormal;
	public FVector Driver2D;
	public FCachedRigElement DriverCache;
	public FCachedRigElement OptionalParentCache;
	public FTransform LocalDriverTransformInit;
	public FVector CachedRotationOffset;
	public bool bCachedInitTransforms;
}
