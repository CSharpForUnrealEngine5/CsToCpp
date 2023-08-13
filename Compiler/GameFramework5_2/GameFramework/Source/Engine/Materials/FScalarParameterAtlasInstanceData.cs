namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable scalar parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FScalarParameterAtlasInstanceData {
	public bool bIsUsedAsAtlasPosition;
	public TSoftObjectPtr<UCurveLinearColor> Curve;
	public TSoftObjectPtr<UCurveLinearColorAtlas> Atlas;
}
