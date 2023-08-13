namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCPresetDescription {
	public string Name;
	public string Path;
	public string ID;
	public TArray<FRCPresetLayoutGroupDescription> Groups;
	public TArray<FRCControllerDescription> Controllers;
}
