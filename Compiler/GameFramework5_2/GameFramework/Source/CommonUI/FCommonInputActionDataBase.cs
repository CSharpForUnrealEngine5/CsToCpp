#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
public partial struct FCommonInputActionDataBase {
	public string DisplayName;
	public string HoldDisplayName;
	public int NavBarPriority;
	public FCommonInputTypeInfo KeyboardInputTypeInfo;
	public FCommonInputTypeInfo DefaultGamepadInputTypeInfo;
	public TMap<string,FCommonInputTypeInfo> GamepadInputOverrides;
	public FCommonInputTypeInfo TouchInputTypeInfo;
}
