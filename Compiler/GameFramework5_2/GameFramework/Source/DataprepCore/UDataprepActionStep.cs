#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepActionAsset.h")]
public partial class UDataprepActionStep : UObject {
// DataprepActionStep
	public bool bIsEnabled;
	public UDataprepParameterizableObject StepObject;
	public TSoftObjectPtr<UClass> PathOfStepObjectClass;
	public UDataprepOperation Operation_DEPRECATED;
	public UDataprepFilter Filter_DEPRECATED;
}
