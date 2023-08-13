namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all of the VR widgets</summary>
[CppInclude("UI/VREditorBaseUserWidget.h")]
public partial class UVREditorBaseUserWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The UI system that owns this widget</summary>
	public TWeakObjectPtr<AVREditorFloatingUI> Owner;
}
