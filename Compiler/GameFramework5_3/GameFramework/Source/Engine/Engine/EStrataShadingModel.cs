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
	SSM_Cloth=6,
	SSM_ClearCoat=7,
	SSM_SingleLayerWater=8,
	SSM_LightFunction=9,
	SSM_PostProcess=10,
	SSM_Decal=11,
	SSM_UI=12,
	SSM_NUM=13,
}
