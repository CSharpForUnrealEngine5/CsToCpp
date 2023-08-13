namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for safely replicating  script struct references (constrained to a specified parent struct)</summary>
[CppInclude("AbilitySystemGlobals.h")]
public partial struct FNetSerializeScriptStructCache {
	public TArray<UScriptStruct> ScriptStructs;
}
