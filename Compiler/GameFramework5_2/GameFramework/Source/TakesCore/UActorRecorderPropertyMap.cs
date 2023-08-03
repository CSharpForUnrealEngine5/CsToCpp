#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This represents a list of all possible properties and components on an actor</summary>
[CppInclude("TakeRecorderSourceProperty.h")]
public partial class UActorRecorderPropertyMap : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RecordedObject</summary>
	public TSoftObjectPtr<UObject> RecordedObject;
	///<summary>Represents properties exposed to Cinematics that can possibly be recorded.</summary>
	public TArray<FActorRecordedProperty> Properties;
	///<summary>Children</summary>
	public TArray<UActorRecorderPropertyMap> Children;
}
