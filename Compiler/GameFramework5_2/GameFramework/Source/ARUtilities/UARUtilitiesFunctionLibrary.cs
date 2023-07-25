#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARUtilitiesFunctionLibrary.h")]
public partial class UARUtilitiesFunctionLibrary : UBlueprintFunctionLibrary {
// ARUtilitiesFunctionLibrary
	public void UpdateCameraTextureParam(UObject MaterialInstance,UObject CameraTexture,float ColorScale/*=1.0f*/) {}
	public void UpdateSceneDepthTexture(UObject MaterialInstance,UObject SceneDepthTexture,float DepthToMeterScale/*=1.0f*/) {}
	public void UpdateWorldToMeterScale(UObject MaterialInstance,float WorldToMeterScale/*=100.0f*/) {}
}
