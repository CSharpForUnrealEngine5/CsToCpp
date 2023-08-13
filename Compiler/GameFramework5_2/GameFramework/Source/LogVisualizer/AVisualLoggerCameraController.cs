namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VisualLoggerCameraController.h")]
public partial class AVisualLoggerCameraController : ADebugCameraController {
	public static UClass StaticClass() {return default;}
	///<summary>PickedActor</summary>
	public TWeakObjectPtr<AActor> PickedActor;
}
