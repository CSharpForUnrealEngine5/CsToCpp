#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for &#39;parameterized&#39; Lightmass settings</summary>
[CppInclude("Editor/UnrealEdTypes.h")]
public partial struct FLightmassParameterizedMaterialSettings {
	public FLightmassBooleanParameterValue CastShadowAsMasked;
	public FLightmassScalarParameterValue EmissiveBoost;
	public FLightmassScalarParameterValue DiffuseBoost;
	public FLightmassScalarParameterValue ExportResolutionScale;
}
