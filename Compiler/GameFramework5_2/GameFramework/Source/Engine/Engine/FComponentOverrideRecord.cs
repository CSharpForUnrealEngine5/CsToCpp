namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InheritableComponentHandler.h")]
public partial struct FComponentOverrideRecord {
	public UClass ComponentClass;
	public UActorComponent ComponentTemplate;
	public FComponentKey ComponentKey;
	public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
}
