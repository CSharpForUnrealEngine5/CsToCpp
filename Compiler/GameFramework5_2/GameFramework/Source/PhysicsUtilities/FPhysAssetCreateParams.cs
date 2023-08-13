namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for PhysicsAsset creation</summary>
[CppInclude("PhysicsAssetUtils.h")]
public partial struct FPhysAssetCreateParams {
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
