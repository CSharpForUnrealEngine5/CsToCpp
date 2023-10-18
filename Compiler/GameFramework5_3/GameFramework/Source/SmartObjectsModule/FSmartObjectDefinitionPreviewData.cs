namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data used for previewing in the Smart Object editor.</summary>
[CppInclude("SmartObjectDefinition.h")]
public partial struct FSmartObjectDefinitionPreviewData {
	public TSoftObjectPtr<UClass> ObjectActorClass;
	public FSoftObjectPath ObjectMeshPath;
	public TSoftObjectPtr<UClass> UserActorClass;
	public TSoftObjectPtr<UClass> UserValidationFilterClass;
}
