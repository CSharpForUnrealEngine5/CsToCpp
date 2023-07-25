#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Action/RCActionContainer.h")]
///<summary>Container for created actions</summary>
public partial class URCActionContainer : UObject {
// RCActionContainer
	public TSet<URCActionContainer> ActionContainers;
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
	public TSet<URCAction> Actions;
}
