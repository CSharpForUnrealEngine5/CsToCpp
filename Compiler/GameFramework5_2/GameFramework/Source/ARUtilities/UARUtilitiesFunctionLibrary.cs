#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARUtilitiesFunctionLibrary.h")]
public partial class UARUtilitiesFunctionLibrary : UBlueprintFunctionLibrary {
// ARUtilitiesFunctionLibrary
	public static void UpdateCameraTextureParam(UMaterialInstanceDynamic MaterialInstance,UTexture CameraTexture,float ColorScale/*=1.0f*/) {}
	public static void UpdateSceneDepthTexture(UMaterialInstanceDynamic MaterialInstance,UTexture SceneDepthTexture,float DepthToMeterScale/*=1.0f*/) {}
	public static void UpdateWorldToMeterScale(UMaterialInstanceDynamic MaterialInstance,float WorldToMeterScale/*=100.0f*/) {}
}
