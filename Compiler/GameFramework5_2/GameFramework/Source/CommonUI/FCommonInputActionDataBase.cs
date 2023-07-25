#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
public partial struct FCommonInputActionDataBase {
// CommonInputActionDataBase
	public string DisplayName;
	public string HoldDisplayName;
	public int NavBarPriority;
	public FCommonInputTypeInfo KeyboardInputTypeInfo;
	public FCommonInputTypeInfo DefaultGamepadInputTypeInfo;
	public TMap<string,FCommonInputTypeInfo> GamepadInputOverrides;
	public FCommonInputTypeInfo TouchInputTypeInfo;
}
