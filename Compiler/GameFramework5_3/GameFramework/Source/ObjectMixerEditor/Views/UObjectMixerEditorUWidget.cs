namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A UMG widget wrapper for the Object Mixer widget. Uses the same data as the Generic Object Mixer Instance.</summary>
[CppInclude("Views/Widgets/ObjectMixerEditorUWidget.h")]
public partial class UObjectMixerEditorUWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>End of UWidget</summary>
	public FObjectMixerWidgetUserConfig ObjectMixerWidgetUserConfig;
}
