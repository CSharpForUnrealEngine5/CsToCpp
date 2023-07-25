#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepActionAsset.h")]
public partial class UDataprepActionAsset : UObject {
// DataprepActionAsset
	public void Execute(TArray<UObject> InObjects) {}
	public bool bExecutionInterrupted;
	public bool bIsEnabled;
	public TArray<UDataprepActionStep> Steps;
	public UDataprepActionAppearance Appearance;
	public string Label;
}
