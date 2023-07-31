#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryGenerator.h")]
public partial class UEnvQueryGenerator : UEnvQueryNode {
	///<summary>OptionName</summary>
	public string OptionName;
	///<summary>type of generated items</summary>
	public UClass ItemType;
	///<summary>if set, tests will be automatically sorted for best performance before running query</summary>
	public bool bAutoSortTests;
}
