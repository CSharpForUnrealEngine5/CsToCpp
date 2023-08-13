namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FRCPresetControllersAddedEvent {
	public string Type;
	public string PresetName;
	public string PresetId;
	public FRCPresetDescription Description;
}
