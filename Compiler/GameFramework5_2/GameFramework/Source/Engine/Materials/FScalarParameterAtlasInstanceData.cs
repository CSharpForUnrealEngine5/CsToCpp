#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
///<summary>Editable scalar parameter.</summary>
public partial struct FScalarParameterAtlasInstanceData {
// ScalarParameterAtlasInstanceData
	public bool bIsUsedAsAtlasPosition;
	public TSoftObjectPtr<UCurveLinearColor> Curve;
	public TSoftObjectPtr<UCurveLinearColorAtlas> Atlas;
}
