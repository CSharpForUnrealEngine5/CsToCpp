namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_FunctionEntry.h")]
public partial class UK2Node_FunctionEntry : UK2Node_FunctionTerminator {
	public static UClass StaticClass() {return default;}
	///<summary>If specified, the function that is created for this entry point will have this name.  Otherwise, it will have the function signature&#39;s name</summary>
	public string CustomGeneratedFunctionName;
	///<summary>Function metadata</summary>
	public FKismetUserDeclaredFunctionMetadata MetaData;
	///<summary>Array of local variables to be added to generated function</summary>
	public TArray<FBPVariableDescription> LocalVariables;
	///<summary>Whether or not to enforce const-correctness for const function overrides</summary>
	public bool bEnforceConstCorrectness;
	///<summary>Any extra flags that the function may need</summary>
	public int ExtraFlags;
}
