namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an interactive floating UI camera preview panel in the VR Editor</summary>
[CppInclude("UI/VREditorFloatingCameraUI.h")]
public partial class AVREditorFloatingCameraUI : AVREditorFloatingUI {
	public static UClass StaticClass() {return default;}
	///<summary>The offset of this UI from its camera</summary>
	public FVector OffsetFromCamera;
	///<summary>LinkedActor</summary>
	public TWeakObjectPtr<AActor> LinkedActor;
}
