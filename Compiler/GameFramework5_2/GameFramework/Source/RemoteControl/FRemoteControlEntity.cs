#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for exposed objects, properties, functions etc...</summary>
[CppInclude("RemoteControlEntity.h")]
public partial struct FRemoteControlEntity {
	public TMap<string,string> UserMetadata;
	public TArray<TWeakObjectPtr<URemoteControlBinding>> Bindings;
	public TWeakObjectPtr<URemoteControlPreset> Owner;
	public string Label;
	public FGuid Id;
}
