namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store lightmap data during RerunConstructionScripts</summary>
[CppInclude("Components/LightComponent.h")]
public partial struct FPrecomputedLightInstanceData {
	public FTransform Transform;
	public FGuid LightGuid;
	public int PreviewShadowMapChannel;
}
