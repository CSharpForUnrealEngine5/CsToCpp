#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SphericalPoseReader.h")]
///<summary>* Outputs a float value between 0-1 based off of the driver item's rotation in a specified region.</summary>
public partial struct FRigUnit_SphericalPoseReader {
// RigUnit_SphericalPoseReader
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
