#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConversationRegistry.h")]
///<summary>Container for safely replicating  script struct references (constrained to a specified parent struct)</summary>
public partial struct FNetSerializeScriptStructCache_ConvVersion {
// NetSerializeScriptStructCache_ConvVersion
	public TMap<UScriptStruct,int> ScriptStructsToIndex;
	public TArray<UScriptStruct> IndexToScriptStructs;
}
