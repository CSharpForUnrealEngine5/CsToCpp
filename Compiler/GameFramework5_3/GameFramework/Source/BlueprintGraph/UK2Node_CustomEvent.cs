namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_CustomEvent.h")]
public partial class UK2Node_CustomEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>Optional message to display when the event is deprecated</summary>
	public string DeprecationMessage;
	///<summary>Specifies that usage of this event has been deprecated</summary>
	public bool bIsDeprecated;
	///<summary>Specifies that the event can be triggered in Editor</summary>
	public bool bCallInEditor;
	///<summary>Custom event metadata that can be used for adding custom keywords</summary>
	public FKismetUserDeclaredFunctionMetadata MetaData;
}
