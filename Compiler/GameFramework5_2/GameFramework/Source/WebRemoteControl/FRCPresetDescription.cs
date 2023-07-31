#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
