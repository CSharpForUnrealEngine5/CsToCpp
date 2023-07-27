#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTerrainComponent.h")]
///<summary>The terrain visualization component for an associated spline component.</summary>
public partial class UPaperTerrainComponent : UPrimitiveComponent {
// PaperTerrainComponent
	public UPaperTerrainMaterial TerrainMaterial;
	public bool bClosedSpline;
	public bool bFilledSpline;
	public UPaperTerrainSplineComponent AssociatedSpline;
	public int RandomSeed;
	public float SegmentOverlapAmount;
	public FLinearColor TerrainColor;
	public int ReparamStepsPerSegment;
	public byte SpriteCollisionDomain;
	public float CollisionThickness;
	public  void SetTerrainColor(FLinearColor NewColor) {}
	public UBodySetup CachedBodySetup;
}
