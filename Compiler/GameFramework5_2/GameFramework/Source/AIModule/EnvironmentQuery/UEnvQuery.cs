#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQuery.h")]
public partial class UEnvQuery : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Graph for query</summary>
	public UEdGraph EdGraph;
	///<summary>QueryName</summary>
	public string QueryName;
	///<summary>Options</summary>
	public TArray<UEnvQueryOption> Options;
}
