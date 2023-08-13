namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all actor action-related utilities</summary>
[CppInclude("ActorActionUtility.h")]
public partial class UActorActionUtility : UEditorUtilityObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetSupportedClass</summary>
	public UClass GetSupportedClass() { return default; }
	///<summary>Gets the statically determined supported classes, these classes are used as a first pass filter when determining</summary>
	public TArray<TSoftObjectPtr<UClass>> GetSupportedClasses() { return default; }
	///<summary>For simple Asset Action&#39;s you should fill out the supported class here.</summary>
	public TArray<TSoftObjectPtr<UClass>> SupportedClasses;
}
