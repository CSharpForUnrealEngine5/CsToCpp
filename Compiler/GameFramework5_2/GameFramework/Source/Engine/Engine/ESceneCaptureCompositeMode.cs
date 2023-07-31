#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies how scene captures are composited into render buffers</summary>
public enum ESceneCaptureCompositeMode {
	SCCM_Overwrite=0,
	SCCM_Additive=1,
	SCCM_Composite=2,
}
