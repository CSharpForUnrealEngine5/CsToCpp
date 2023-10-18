namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Describes how to handle lighting of translucent objets</summary>
public enum ETranslucencyLightingMode {
	TLM_VolumetricNonDirectional=0,
	TLM_VolumetricDirectional=1,
	TLM_VolumetricPerVertexNonDirectional=2,
	TLM_VolumetricPerVertexDirectional=3,
	TLM_Surface=4,
	TLM_SurfacePerPixelLighting=5,
	TLM_MAX=6,
}
