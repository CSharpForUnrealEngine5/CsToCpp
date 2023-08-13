namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implement settings for the Interchange Import Test</summary>
[CppInclude("InterchangeImportTestSettings.h")]
public partial class UInterchangeImportTestSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ImportTestsPath</summary>
	public string ImportTestsPath;
	///<summary>ImportFiles</summary>
	public TArray<string> ImportFiles;
}
