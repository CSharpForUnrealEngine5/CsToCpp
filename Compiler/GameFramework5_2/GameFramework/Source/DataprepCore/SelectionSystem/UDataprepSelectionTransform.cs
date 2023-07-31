#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepSelectionTransform.h")]
public partial class UDataprepSelectionTransform : UDataprepParameterizableObject {
	///<summary>Execute the transform</summary>
	public  void Execute(TArray<UObject> InObjects,TArray<UObject> OutObjects) {}
	///<summary>This function is called when the transform is executed.</summary>
	public  void OnExecution(TArray<UObject> InObjects,TArray<UObject> OutObjects) {}
	///<summary>Allows to change the name of the transform for the ui if needed.</summary>
	public  string GetDisplayTransformName() { return default; }
	///<summary>Allows to change the tooltip of the transform for the ui if needed.</summary>
	public  string GetTooltip() { return default; }
	///<summary>Allows to change the category of the transform for the ui if needed.</summary>
	public  string GetCategory() { return default; }
	///<summary>Allows to add more keywords for when a user is searching for the fetcher in the ui.</summary>
	public  string GetAdditionalKeyword() { return default; }
	///<summary>Specifies if input objects that have matching type can be added to the result</summary>
	public bool bOutputCanIncludeInput;
}
