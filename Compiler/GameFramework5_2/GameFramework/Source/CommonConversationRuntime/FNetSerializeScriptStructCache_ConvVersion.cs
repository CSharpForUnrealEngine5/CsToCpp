namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for safely replicating  script struct references (constrained to a specified parent struct)</summary>
[CppInclude("ConversationRegistry.h")]
public partial struct FNetSerializeScriptStructCache_ConvVersion {
	public TMap<UScriptStruct,int> ScriptStructsToIndex;
	public TArray<UScriptStruct> IndexToScriptStructs;
}
