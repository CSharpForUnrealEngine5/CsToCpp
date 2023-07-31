#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Description of a component to add to a type of actor when this game feature is enabled</summary>
[CppInclude("GameFeatureAction_AddComponents.h")]
public partial struct FGameFeatureComponentEntry {
	public TSoftObjectPtr<UClass> ActorClass;
	public TSoftObjectPtr<UClass> ComponentClass;
	public bool bClientComponent;
	public bool bServerComponent;
}
