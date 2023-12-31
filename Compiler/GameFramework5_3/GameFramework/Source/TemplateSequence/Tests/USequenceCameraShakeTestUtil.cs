namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/SequenceCameraShakeTestUtil.h")]
public partial class USequenceCameraShakeTestUtil : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetCameraCachePOV</summary>
	public static FMinimalViewInfo GetCameraCachePOV(APlayerController PlayerController) { return default; }
	///<summary>GetLastFrameCameraCachePOV</summary>
	public static FMinimalViewInfo GetLastFrameCameraCachePOV(APlayerController PlayerController) { return default; }
	///<summary>GetPostProcessBlendCache</summary>
	public static bool GetPostProcessBlendCache(APlayerController PlayerController,int PPIndex,FPostProcessSettings OutPPSettings,float OutPPBlendWeight) { return default; }
}
