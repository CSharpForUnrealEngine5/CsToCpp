#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlEntity.h")]
///<summary>Base class for exposed objects, properties, functions etc...</summary>
public partial struct FRemoteControlEntity {
// RemoteControlEntity
	public TMap<string,string> UserMetadata;
	public TArray<TWeakObjectPtr<URemoteControlBinding>> Bindings;
	public TWeakObjectPtr<URemoteControlPreset> Owner;
	public string Label;
	public FGuid Id;
}
