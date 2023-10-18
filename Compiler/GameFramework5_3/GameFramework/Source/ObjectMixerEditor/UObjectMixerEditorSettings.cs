namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectMixerEditorSettings.h")]
public partial class UObjectMixerEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, clicking an item in the mixer list will also select the item in the Scene Outliner.</summary>
	public bool bSyncSelection;
	///<summary>If false, a new object will be created every time the filter object is accessed.</summary>
	public bool bExpandTreeViewItemsByDefault;
}
