namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepActionAsset.h")]
public partial class UDataprepActionStep : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>End UObject Interface</summary>
	public bool bIsEnabled;
	///<summary>The actual object of the step</summary>
	public UDataprepParameterizableObject StepObject;
	///<summary>Will be used for future error message if the step object can&#39;t be loaded</summary>
	public TSoftObjectPtr<UClass> PathOfStepObjectClass;
	///<summary>The operation will only be not null if the step is a operation</summary>
	public UDataprepOperation Operation_DEPRECATED;
	///<summary>The Filter will only be not null if the step is a Filter/Selector</summary>
	public UDataprepFilter Filter_DEPRECATED;
}
