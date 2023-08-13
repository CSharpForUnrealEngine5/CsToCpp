namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AbilityAsync is a base class for ability-specific BlueprintAsyncActions.</summary>
[CppInclude("Abilities/Async/AbilityAsync.h")]
public partial class UAbilityAsync : UCancellableAsyncAction {
	public static UClass StaticClass() {return default;}
	///<summary>Explicitly end the action, will disable any callbacks and allow action to be destroyed</summary>
	public virtual void EndAction() {}
}
