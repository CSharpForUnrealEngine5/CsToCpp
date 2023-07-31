#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepActionAsset.h")]
public partial class UDataprepActionAsset : UObject {
	///<summary>Execute the action on a specific set of objects</summary>
	public  void Execute(TArray<UObject> InObjects) {}
	///<summary>bExecutionInterrupted</summary>
	public bool bExecutionInterrupted;
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
	///<summary>Array of operations and/or filters constituting this action</summary>
	public TArray<UDataprepActionStep> Steps;
	///<summary>Appearance</summary>
	public UDataprepActionAppearance Appearance;
	///<summary>UI label of the action</summary>
	public string Label;
}
