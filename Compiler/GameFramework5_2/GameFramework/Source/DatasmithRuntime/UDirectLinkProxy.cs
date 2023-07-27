#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithRuntimeBlueprintLibrary.h")]
///<summary>Class to interface with the DirectLink end point</summary>
public partial class UDirectLinkProxy : UObject {
// DirectLinkProxy
	public  string GetEndPointName() { return default; }
	public  TArray<FDatasmithRuntimeSourceInfo> GetListOfSources() { return default; }
	public FDatasmithRuntimeChangeEvent OnDirectLinkChange;
}
