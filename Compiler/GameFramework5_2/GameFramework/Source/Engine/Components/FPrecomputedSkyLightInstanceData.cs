namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to store lightmap data during RerunConstructionScripts</summary>
[CppInclude("Components/SkyLightComponent.h")]
public partial struct FPrecomputedSkyLightInstanceData {
	public FGuid LightGuid;
	public float AverageBrightness;
}
