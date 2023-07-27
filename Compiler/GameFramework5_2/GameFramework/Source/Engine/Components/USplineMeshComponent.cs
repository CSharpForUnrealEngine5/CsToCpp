#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineMeshComponent.h")]
///<summary>A Spline Mesh Component is a derivation of a Static Mesh Component which can be deformed using a spline. Only a start and end position (and tangent) can be specified.</summary>
public partial class USplineMeshComponent : UStaticMeshComponent {
// SplineMeshComponent
	public FSplineMeshParams SplineParams;
	public FVector SplineUpDir;
	public float SplineBoundaryMin;
	public FGuid CachedMeshBodySetupGuid;
	public UBodySetup BodySetup;
	public float SplineBoundaryMax;
	public bool bAllowSplineEditingPerInstance;
	public bool bSmoothInterpRollScale;
	public bool bMeshDirty;
	public byte ForwardAxis;
	public float VirtualTextureMainPassMaxDrawDistance;
	public bool bSelected;
	public bool bNeverNeedsCookedCollisionData;
	public  void UpdateMesh() {}
	public  FVector GetStartPosition() { return default; }
	public  void SetStartPosition(FVector StartPos,bool bUpdateMesh/*=true*/) {}
	public  FVector GetStartTangent() { return default; }
	public  void SetStartTangent(FVector StartTangent,bool bUpdateMesh/*=true*/) {}
	public  FVector GetEndPosition() { return default; }
	public  void SetEndPosition(FVector EndPos,bool bUpdateMesh/*=true*/) {}
	public  FVector GetEndTangent() { return default; }
	public  void SetEndTangent(FVector EndTangent,bool bUpdateMesh/*=true*/) {}
	public  void SetStartAndEnd(FVector StartPos,FVector StartTangent,FVector EndPos,FVector EndTangent,bool bUpdateMesh/*=true*/) {}
	public  FVector2D GetStartScale() { return default; }
	public  void SetStartScale(FVector2D StartScale/*=new FVector2D(1,1)*/,bool bUpdateMesh/*=true*/) {}
	public  float GetStartRoll() { return default; }
	public  void SetStartRoll(float StartRoll,bool bUpdateMesh/*=true*/) {}
	public  FVector2D GetStartOffset() { return default; }
	public  void SetStartOffset(FVector2D StartOffset,bool bUpdateMesh/*=true*/) {}
	public  FVector2D GetEndScale() { return default; }
	public  void SetEndScale(FVector2D EndScale/*=new FVector2D(1,1)*/,bool bUpdateMesh/*=true*/) {}
	public  float GetEndRoll() { return default; }
	public  void SetEndRoll(float EndRoll,bool bUpdateMesh/*=true*/) {}
	public  FVector2D GetEndOffset() { return default; }
	public  void SetEndOffset(FVector2D EndOffset,bool bUpdateMesh/*=true*/) {}
	public  ESplineMeshAxis GetForwardAxis() { return default; }
	public  void SetForwardAxis(ESplineMeshAxis InForwardAxis,bool bUpdateMesh/*=true*/) {}
	public  FVector GetSplineUpDir() { return default; }
	public  void SetSplineUpDir(FVector InSplineUpDir,bool bUpdateMesh/*=true*/) {}
	public  float GetBoundaryMin() { return default; }
	public  void SetBoundaryMin(float InBoundaryMin,bool bUpdateMesh/*=true*/) {}
	public  float GetBoundaryMax() { return default; }
	public  void SetBoundaryMax(float InBoundaryMax,bool bUpdateMesh/*=true*/) {}
}
