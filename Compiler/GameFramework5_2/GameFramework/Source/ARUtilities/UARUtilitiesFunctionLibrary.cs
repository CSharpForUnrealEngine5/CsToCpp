namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARUtilitiesFunctionLibrary.h")]
public partial class UARUtilitiesFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Update material texture parameter using pre-defined names:</summary>
	public static void UpdateCameraTextureParam(UMaterialInstanceDynamic MaterialInstance,UTexture CameraTexture,float ColorScale/*=1.0f*/) {}
	///<summary>Update material texture parameter using pre-defined names:</summary>
	public static void UpdateSceneDepthTexture(UMaterialInstanceDynamic MaterialInstance,UTexture SceneDepthTexture,float DepthToMeterScale/*=1.0f*/) {}
	///<summary>Update material texture parameter using pre-defined names:</summary>
	public static void UpdateWorldToMeterScale(UMaterialInstanceDynamic MaterialInstance,float WorldToMeterScale/*=100.0f*/) {}
}
