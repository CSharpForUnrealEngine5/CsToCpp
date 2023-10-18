namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
public partial struct FCommonInputActionDataBase {
	public FText DisplayName;
	public FText HoldDisplayName;
	public int NavBarPriority;
	public FCommonInputTypeInfo KeyboardInputTypeInfo;
	public FCommonInputTypeInfo DefaultGamepadInputTypeInfo;
	public TMap<FName,FCommonInputTypeInfo> GamepadInputOverrides;
	public FCommonInputTypeInfo TouchInputTypeInfo;
}
