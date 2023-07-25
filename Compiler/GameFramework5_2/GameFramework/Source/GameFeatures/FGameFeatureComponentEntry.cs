#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeatureAction_AddComponents.h")]
///<summary>Description of a component to add to a type of actor when this game feature is enabled</summary>
public partial struct FGameFeatureComponentEntry {
// GameFeatureComponentEntry
	public TSoftObjectPtr<UClass> ActorClass;
	public TSoftObjectPtr<UClass> ComponentClass;
	public bool bClientComponent;
	public bool bServerComponent;
}
