#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all of the VR widgets</summary>
[CppInclude("UI/VREditorBaseUserWidget.h")]
public partial class UVREditorBaseUserWidget : UUserWidget {
	///<summary>The UI system that owns this widget</summary>
	public TWeakObjectPtr<AVREditorFloatingUI> Owner;
}
