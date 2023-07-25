#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlPreset.h")]
///<summary>Represents a group of field and offers operations to operate on the fields inside of that group.</summary>
public partial struct FRemoteControlPresetGroup {
// RemoteControlPresetGroup
	public string Name;
	public FGuid Id;
	public FLinearColor TagColor;
	public TArray<FGuid> Fields;
}
