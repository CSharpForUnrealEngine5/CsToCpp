#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderSourceProperty.h")]
///<summary>This represents a list of all possible properties and components on an actor</summary>
public partial class UActorRecorderPropertyMap : UObject {
// ActorRecorderPropertyMap
	public TSoftObjectPtr<UObject> RecordedObject;
	public TArray<FActorRecordedProperty> Properties;
	public TArray<UActorRecorderPropertyMap> Children;
}
