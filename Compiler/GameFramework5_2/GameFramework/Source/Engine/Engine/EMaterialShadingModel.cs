#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies the overal rendering/shading model for a material</summary>
public enum EMaterialShadingModel {
	MSM_Unlit=0,
	MSM_DefaultLit=1,
	MSM_Subsurface=2,
	MSM_PreintegratedSkin=3,
	MSM_ClearCoat=4,
	MSM_SubsurfaceProfile=5,
	MSM_TwoSidedFoliage=6,
	MSM_Hair=7,
	MSM_Cloth=8,
	MSM_Eye=9,
	MSM_SingleLayerWater=10,
	MSM_ThinTranslucent=11,
	MSM_Strata=12,
	MSM_NUM=13,
	MSM_FromMaterialExpression=14,
	MSM_MAX=15,
}
