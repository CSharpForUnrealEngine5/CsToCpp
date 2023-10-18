namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for exposed objects, properties, functions etc...</summary>
[CppInclude("RemoteControlEntity.h")]
public partial struct FRemoteControlEntity {
	public TMap<FName,string> UserMetadata;
	public TArray<TWeakObjectPtr<URemoteControlBinding>> Bindings;
	public TWeakObjectPtr<URemoteControlPreset> Owner;
	public FName Label;
	public FGuid Id;
}
