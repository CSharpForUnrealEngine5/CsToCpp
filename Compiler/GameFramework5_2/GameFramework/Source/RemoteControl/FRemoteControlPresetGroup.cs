namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a group of field and offers operations to operate on the fields inside of that group.</summary>
[CppInclude("RemoteControlPreset.h")]
public partial struct FRemoteControlPresetGroup {
	public string Name;
	public FGuid Id;
	public FLinearColor TagColor;
	public TArray<FGuid> Fields;
}
