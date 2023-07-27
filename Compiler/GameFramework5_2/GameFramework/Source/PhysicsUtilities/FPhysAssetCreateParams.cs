#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsAssetUtils.h")]
///<summary>Parameters for PhysicsAsset creation</summary>
public partial struct FPhysAssetCreateParams {
// PhysAssetCreateParams
	public float MinBoneSize;
	public float MinWeldSize;
	public EPhysAssetFitGeomType GeomType;
	public EPhysAssetFitVertWeight VertWeight;
	public bool bAutoOrientToBone;
	public bool bCreateConstraints;
	public bool bWalkPastSmall;
	public bool bBodyForAll;
	public bool bDisableCollisionsByDefault;
	public EAngularConstraintMotion AngularConstraintMode;
	public int HullCount;
	public int MaxHullVerts;
	public int LevelSetResolution;
}
