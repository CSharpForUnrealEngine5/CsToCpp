namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options when adding a new subobject</summary>
[CppInclude("SubobjectDataSubsystem.h")]
public partial struct FAddNewSubobjectParams {
	public FSubobjectDataHandle ParentHandle;
	public UClass NewClass;
	public UBlueprint BlueprintContext;
	public bool bSkipMarkBlueprintModified;
	public bool bConformTransformToParent;
}
