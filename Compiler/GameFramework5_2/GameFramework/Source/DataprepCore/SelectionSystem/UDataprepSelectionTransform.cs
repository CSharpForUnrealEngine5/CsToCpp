#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepSelectionTransform.h")]
public partial class UDataprepSelectionTransform : UDataprepParameterizableObject {
// DataprepSelectionTransform
	public  void Execute(TArray<UObject> InObjects,TArray<UObject> OutObjects) {}
	public  void OnExecution(TArray<UObject> InObjects,TArray<UObject> OutObjects) {}
	public  string GetDisplayTransformName() { return default; }
	public  string GetTooltip() { return default; }
	public  string GetCategory() { return default; }
	public  string GetAdditionalKeyword() { return default; }
	public bool bOutputCanIncludeInput;
}
