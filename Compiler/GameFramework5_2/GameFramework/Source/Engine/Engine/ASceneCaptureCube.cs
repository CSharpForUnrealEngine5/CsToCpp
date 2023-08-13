namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SceneCaptureCube.h")]
public partial class ASceneCaptureCube : ASceneCapture {
	public static UClass StaticClass() {return default;}
	///<summary>Scene capture component.</summary>
	public USceneCaptureComponentCube CaptureComponentCube;
	///<summary>OnInterpToggle</summary>
	public void OnInterpToggle(bool bEnable) {}
}
