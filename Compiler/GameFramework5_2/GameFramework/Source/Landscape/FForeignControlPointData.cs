#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeSplinesComponent.h")]
///<summary>structs for ForeignWorldSplineDataMap</summary>
public partial struct FForeignControlPointData {
// ForeignControlPointData
	public FGuid ModificationKey;
	public UControlPointMeshComponent MeshComponent;
	public TLazyObjectPtr<ULandscapeSplineControlPoint> Identifier;
}
