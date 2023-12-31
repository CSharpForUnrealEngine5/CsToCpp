namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a single input mapping context and the priority that it should be applied with</summary>
[CppInclude("EnhancedInputDeveloperSettings.h")]
public partial struct FDefaultContextSetting {
	public TSoftObjectPtr<UInputMappingContext> InputMappingContext;
	public int Priority;
}
