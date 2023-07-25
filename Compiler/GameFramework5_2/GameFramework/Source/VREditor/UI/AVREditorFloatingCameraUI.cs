#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorFloatingCameraUI.h")]
///<summary>Represents an interactive floating UI camera preview panel in the VR Editor</summary>
public partial class AVREditorFloatingCameraUI : AVREditorFloatingUI {
// VREditorFloatingCameraUI
	public FVector OffsetFromCamera;
	public TWeakObjectPtr<AActor> LinkedActor;
}
