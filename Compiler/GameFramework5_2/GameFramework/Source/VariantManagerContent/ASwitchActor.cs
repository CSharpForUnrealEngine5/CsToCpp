namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Switch Actor allows quickly toggling the visibility of its child actors so that</summary>
[CppInclude("SwitchActor.h")]
public partial class ASwitchActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the child actors that are available options, in a fixed order that may differ from the one displayed in the world outliner</summary>
	public TArray<AActor> GetOptions() { return default; }
	///<summary>If we have exactly one child actor visible, it will return a pointer to it. Returns nullptr otherwise</summary>
	public int GetSelectedOption() { return default; }
	///<summary>Select one of the available options by index</summary>
	public void SelectOption(int OptionIndex) {}
	///<summary>Exposing our root component like this allows manual Mobility control on the details panel</summary>
	public USceneComponent SceneComponent;
	///<summary>LastSelectedOption</summary>
	public int LastSelectedOption;
}
