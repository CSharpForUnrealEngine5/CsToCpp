#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies the Substrate runtime shading model summarized from the material graph</summary>
public enum EStrataShadingModel {
	SSM_Unlit=0,
	SSM_DefaultLit=1,
	SSM_SubsurfaceLit=2,
	SSM_VolumetricFogCloud=3,
	SSM_Hair=4,
	SSM_Eye=5,
	SSM_SingleLayerWater=6,
	SSM_LightFunction=7,
	SSM_PostProcess=8,
	SSM_Decal=9,
	SSM_UI=10,
	SSM_NUM=11,
}
