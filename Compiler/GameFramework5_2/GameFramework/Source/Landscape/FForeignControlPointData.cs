#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>structs for ForeignWorldSplineDataMap</summary>
[CppInclude("LandscapeSplinesComponent.h")]
public partial struct FForeignControlPointData {
	public FGuid ModificationKey;
	public UControlPointMeshComponent MeshComponent;
	public TLazyObjectPtr<ULandscapeSplineControlPoint> Identifier;
}
