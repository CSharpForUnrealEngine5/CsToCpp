namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A registry that can answer questions about all available dialogue assets</summary>
[CppInclude("ConversationRegistry.h")]
public partial class UConversationRegistry : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>ConversationChoiceDataStructCache</summary>
	public FNetSerializeScriptStructCache_ConvVersion ConversationChoiceDataStructCache;
}
