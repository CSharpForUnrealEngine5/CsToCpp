#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InheritableComponentHandler.h")]
public partial struct FComponentOverrideRecord {
	public UClass ComponentClass;
	public UActorComponent ComponentTemplate;
	public FComponentKey ComponentKey;
	public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
}
