#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SceneUtils.h")]
///<summary>Used by rendering project settings.</summary>
public enum EAntiAliasingMethod {
	AAM_None=0,
	AAM_FXAA=1,
	AAM_TemporalAA=2,
	AAM_MSAA=3,
	AAM_TSR=4,
	AAM_MAX=5,
}
