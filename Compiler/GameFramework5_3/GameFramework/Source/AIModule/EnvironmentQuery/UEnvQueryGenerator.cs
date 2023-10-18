namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryGenerator.h")]
public partial class UEnvQueryGenerator : UEnvQueryNode {
	public static UClass StaticClass() {return default;}
	///<summary>OptionName</summary>
	public string OptionName;
	///<summary>type of generated items</summary>
	public UClass ItemType;
	///<summary>if set, tests will be automatically sorted for best performance before running query</summary>
	public bool bAutoSortTests;
}
