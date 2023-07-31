#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A registry that can answer questions about all available dialogue assets</summary>
[CppInclude("ConversationRegistry.h")]
public partial class UConversationRegistry : UWorldSubsystem {
	///<summary>ConversationChoiceDataStructCache</summary>
	public FNetSerializeScriptStructCache_ConvVersion ConversationChoiceDataStructCache;
}
