#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Controls how occlusion from Distance Field Ambient Occlusion is combined with Screen Space Ambient Occlusion.</summary>
public enum EOcclusionCombineMode {
	OCM_Minimum=0,
	OCM_Multiply=1,
	OCM_MAX=2,
}
