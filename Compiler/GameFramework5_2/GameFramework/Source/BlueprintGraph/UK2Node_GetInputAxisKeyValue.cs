namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_GetInputAxisKeyValue.h")]
public partial class UK2Node_GetInputAxisKeyValue : UK2Node_CallFunction {
	public static UClass StaticClass() {return default;}
	///<summary>InputAxisKey</summary>
	public FKey InputAxisKey;
	///<summary>Prevents actors with lower priority from handling this input</summary>
	public bool bConsumeInput;
	///<summary>Should the binding gather input even when the game is paused</summary>
	public bool bExecuteWhenPaused;
}
