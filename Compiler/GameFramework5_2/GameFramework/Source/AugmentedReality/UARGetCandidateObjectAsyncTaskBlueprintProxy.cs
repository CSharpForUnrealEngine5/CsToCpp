#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintProxy.h")]
public partial class UARGetCandidateObjectAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy {
	///<summary>OnSuccess</summary>
	public FARGetCandidateObjectPin OnSuccess;
	///<summary>OnFailed</summary>
	public FARGetCandidateObjectPin OnFailed;
	///<summary>Saves the point cloud centered at the specified location capturing all of the features within the specified extent as an object that can be detected later</summary>
	public static UARGetCandidateObjectAsyncTaskBlueprintProxy ARGetCandidateObject(UObject WorldContextObject,FVector Location,FVector Extent) { return default; }
}
