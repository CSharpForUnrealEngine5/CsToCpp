#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorActionUtility.h")]
///<summary>Base class for all actor action-related utilities</summary>
public partial class UActorActionUtility : UEditorUtilityObject {
// ActorActionUtility
	public  UClass GetSupportedClass() { return default; }
	public  TArray<TSoftObjectPtr<UClass>> GetSupportedClasses() { return default; }
	public TArray<TSoftObjectPtr<UClass>> SupportedClasses;
}
