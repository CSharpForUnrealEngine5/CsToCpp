#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwitchActor.h")]
///<summary>Switch Actor allows quickly toggling the visibility of its child actors so that</summary>
public partial class ASwitchActor : AActor {
// SwitchActor
	public TArray<UObject> GetOptions() { return default; }
	public int GetSelectedOption() { return default; }
	public void SelectOption(int OptionIndex) {}
	public USceneComponent SceneComponent;
	public int LastSelectedOption;
}
