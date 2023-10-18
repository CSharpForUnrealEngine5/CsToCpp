namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Spline Mesh Component is a derivation of a Static Mesh Component which can be deformed using a spline. Only a start and end position (and tangent) can be specified.</summary>
[CppInclude("Components/SplineMeshComponent.h")]
public partial class USplineMeshComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Spline that is used to deform mesh</summary>
	public FSplineMeshParams SplineParams;
	///<summary>Axis (in component space) that is used to determine X axis for co-ordinates along spline</summary>
	public FVector SplineUpDir;
	///<summary>Minimum coordinate along the spline forward axis which corresponds to start of spline. If set to 0.0, will use bounding box to determine bounds</summary>
	public float SplineBoundaryMin;
	///<summary>Used to automatically trigger rebuild of collision data</summary>
	public FGuid CachedMeshBodySetupGuid;
	///<summary>Physics data.</summary>
	public UBodySetup BodySetup;
	///<summary>Maximum coordinate along the spline forward axis which corresponds to end of spline. If set to 0.0, will use bounding box to determine bounds</summary>
	public float SplineBoundaryMax;
	///<summary>If true, spline mesh properties - StartPos, EndPos, StartTangent and EndTangent- may be edited per instance in the level viewport. Otherwise, the spline mesh should be initialized in the construction script.</summary>
	public bool bAllowSplineEditingPerInstance;
	///<summary>If true, will use smooth interpolation (ease in/out) for Scale, Roll, and Offset along this section of spline. If false, uses linear</summary>
	public bool bSmoothInterpRollScale;
	///<summary>Indicates that the mesh needs updating</summary>
	public bool bMeshDirty;
	///<summary>Chooses the forward axis for the spline mesh orientation</summary>
	public ESplineMeshAxis ForwardAxis;
	///<summary>The max draw distance to use in the main pass when also rendering to a runtime virtual texture.</summary>
	public float VirtualTextureMainPassMaxDrawDistance;
	///<summary>bSelected</summary>
	public bool bSelected;
	///<summary>TODO Chaos this is to opt out of CreatePhysicsMeshes for certain meshes</summary>
	public bool bNeverNeedsCookedCollisionData;
	///<summary>Update the collision and render state on the spline mesh following changes to its geometry</summary>
	public void UpdateMesh() {}
	///<summary>Get the start position of spline in local space</summary>
	public FVector GetStartPosition() { return default; }
	///<summary>Set the start position of spline in local space</summary>
	public void SetStartPosition(FVector StartPos,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the start tangent vector of spline in local space</summary>
	public FVector GetStartTangent() { return default; }
	///<summary>Set the start tangent vector of spline in local space</summary>
	public void SetStartTangent(FVector StartTangent,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the end position of spline in local space</summary>
	public FVector GetEndPosition() { return default; }
	///<summary>Set the end position of spline in local space</summary>
	public void SetEndPosition(FVector EndPos,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the end tangent vector of spline in local space</summary>
	public FVector GetEndTangent() { return default; }
	///<summary>Set the end tangent vector of spline in local space</summary>
	public void SetEndTangent(FVector EndTangent,bool bUpdateMesh/*=true*/) {}
	///<summary>Set the start and end, position and tangent, all in local space</summary>
	public void SetStartAndEnd(FVector StartPos,FVector StartTangent,FVector EndPos,FVector EndTangent,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the start scaling</summary>
	public FVector2D GetStartScale() { return default; }
	///<summary>Set the start scaling</summary>
	public void SetStartScale(FVector2D StartScale/*=new FVector2D(1,1)*/,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the start roll, in radians</summary>
	public float GetStartRoll() { return default; }
	///<summary>Set the start roll, in radians</summary>
	public void SetStartRoll(float StartRoll,bool bUpdateMesh/*=true*/) {}
	///<summary>Set the start roll in degrees</summary>
	public void SetStartRollDegrees(float StartRollDegrees,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the start offset</summary>
	public FVector2D GetStartOffset() { return default; }
	///<summary>Set the start offset</summary>
	public void SetStartOffset(FVector2D StartOffset,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the end scaling</summary>
	public FVector2D GetEndScale() { return default; }
	///<summary>Set the end scaling</summary>
	public void SetEndScale(FVector2D EndScale/*=new FVector2D(1,1)*/,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the end roll, in radians</summary>
	public float GetEndRoll() { return default; }
	///<summary>Set the end roll, in radians</summary>
	public void SetEndRoll(float EndRoll,bool bUpdateMesh/*=true*/) {}
	///<summary>Set the end roll in degrees</summary>
	public void SetEndRollDegrees(float EndRollDegrees,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the end offset</summary>
	public FVector2D GetEndOffset() { return default; }
	///<summary>Set the end offset</summary>
	public void SetEndOffset(FVector2D EndOffset,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the forward axis</summary>
	public ESplineMeshAxis GetForwardAxis() { return default; }
	///<summary>Set the forward axis</summary>
	public void SetForwardAxis(ESplineMeshAxis InForwardAxis,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the spline up direction</summary>
	public FVector GetSplineUpDir() { return default; }
	///<summary>Set the spline up direction</summary>
	public void SetSplineUpDir(FVector InSplineUpDir,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the boundary min</summary>
	public float GetBoundaryMin() { return default; }
	///<summary>Set the boundary min</summary>
	public void SetBoundaryMin(float InBoundaryMin,bool bUpdateMesh/*=true*/) {}
	///<summary>Get the boundary max</summary>
	public float GetBoundaryMax() { return default; }
	///<summary>Set the boundary max</summary>
	public void SetBoundaryMax(float InBoundaryMax,bool bUpdateMesh/*=true*/) {}
}
