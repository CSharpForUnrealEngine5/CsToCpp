#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LightComponent.h")]
///<summary>Used to store lightmap data during RerunConstructionScripts</summary>
public partial struct FPrecomputedLightInstanceData {
// PrecomputedLightInstanceData
	public FTransform Transform;
	public FGuid LightGuid;
	public int PreviewShadowMapChannel;
}
