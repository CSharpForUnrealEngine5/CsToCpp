#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies which component of the scene rendering should be output to the final render target.</summary>
public enum ESceneCaptureSource {
	SCS_SceneColorHDR=0,
	SCS_SceneColorHDRNoAlpha=1,
	SCS_FinalColorLDR=2,
	SCS_SceneColorSceneDepth=3,
	SCS_SceneDepth=4,
	SCS_DeviceDepth=5,
	SCS_Normal=6,
	SCS_BaseColor=7,
	SCS_FinalColorHDR=8,
	SCS_FinalToneCurveHDR=9,
	SCS_MAX=10,
}
