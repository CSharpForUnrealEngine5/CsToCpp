namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SceneCapture2D.h")]
public partial class ASceneCapture2D : ASceneCapture {
	public static UClass StaticClass() {return default;}
	///<summary>Scene capture component.</summary>
	public USceneCaptureComponent2D CaptureComponent2D;
	///<summary>OnInterpToggle</summary>
	public void OnInterpToggle(bool bEnable) {}
}
