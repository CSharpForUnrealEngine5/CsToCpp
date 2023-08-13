namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
public partial struct FCommonInputTypeInfo {
	public FKey Key;
	public EInputActionState OverrrideState;
	public bool bActionRequiresHold;
	public float HoldTime;
	public FSlateBrush OverrideBrush;
}
