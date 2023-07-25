#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputDeveloperSettings.h")]
///<summary>Represents a single input mapping context and the priority that it should be applied with</summary>
public partial struct FDefaultContextSetting {
// DefaultContextSetting
	public TSoftObjectPtr<UInputMappingContext> InputMappingContext;
	public int Priority;
}
