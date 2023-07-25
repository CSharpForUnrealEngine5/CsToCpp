#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Action/RCAction.h")]
///<summary>Base class for remote control action</summary>
public partial class URCAction : UObject {
// RCAction
	public FGuid ExposedFieldId;
	public FGuid Id;
	public TWeakObjectPtr<URemoteControlPreset> PresetWeakPtr;
}
