namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Layout that holds groups of fields.</summary>
[CppInclude("RemoteControlPreset.h")]
public partial struct FRemoteControlPresetLayout {
	public TArray<FRemoteControlPresetGroup> Groups;
	public TWeakObjectPtr<URemoteControlPreset> Owner;
}
