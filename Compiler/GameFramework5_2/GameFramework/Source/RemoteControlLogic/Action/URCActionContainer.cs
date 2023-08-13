namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for created actions</summary>
[CppInclude("Action/RCActionContainer.h")]
public partial class URCActionContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Set of child action container</summary>
	public TSet<URCActionContainer> ActionContainers;
	///<summary>Reference to Preset</summary>
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
	///<summary>The list of Actions present in this container</summary>
	public TSet<URCAction> Actions;
}
