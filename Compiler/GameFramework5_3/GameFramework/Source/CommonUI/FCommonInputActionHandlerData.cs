namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@FIXME: This struct is related to legacy CommonUI and should be removed in 5.3 - UE-164871</summary>
[CppInclude("CommonActionHandlerInterface.h")]
public partial struct FCommonInputActionHandlerData {
	public FDataTableRowHandle InputActionRow;
	public EInputActionState State;
}
