#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataSubsystem.h")]
///<summary>Options when adding a new subobject</summary>
public partial struct FAddNewSubobjectParams {
// AddNewSubobjectParams
	public FSubobjectDataHandle ParentHandle;
	public UClass NewClass;
	public UBlueprint BlueprintContext;
	public bool bSkipMarkBlueprintModified;
	public bool bConformTransformToParent;
}
