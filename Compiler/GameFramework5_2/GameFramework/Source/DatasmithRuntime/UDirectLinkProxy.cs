#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to interface with the DirectLink end point</summary>
[CppInclude("DatasmithRuntimeBlueprintLibrary.h")]
public partial class UDirectLinkProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetEndPointName</summary>
	public  string GetEndPointName() { return default; }
	///<summary>GetListOfSources</summary>
	public  TArray<FDatasmithRuntimeSourceInfo> GetListOfSources() { return default; }
	///<summary>Dynamic delegate used to trigger an event in the Game when there is</summary>
	public FDatasmithRuntimeChangeEvent OnDirectLinkChange;
}
