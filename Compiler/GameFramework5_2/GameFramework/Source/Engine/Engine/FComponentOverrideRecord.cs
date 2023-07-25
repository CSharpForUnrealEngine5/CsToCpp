#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InheritableComponentHandler.h")]
public partial struct FComponentOverrideRecord {
// ComponentOverrideRecord
	public UClass ComponentClass;
	public UActorComponent ComponentTemplate;
	public FComponentKey ComponentKey;
	public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
}
