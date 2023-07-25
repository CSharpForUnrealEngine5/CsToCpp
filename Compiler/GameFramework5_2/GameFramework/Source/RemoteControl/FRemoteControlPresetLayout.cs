#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlPreset.h")]
///<summary>Layout that holds groups of fields.</summary>
public partial struct FRemoteControlPresetLayout {
// RemoteControlPresetLayout
	public TArray<FRemoteControlPresetGroup> Groups;
	public TWeakObjectPtr<URemoteControlPreset> Owner;
}
