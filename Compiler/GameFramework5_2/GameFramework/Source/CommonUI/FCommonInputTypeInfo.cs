#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
