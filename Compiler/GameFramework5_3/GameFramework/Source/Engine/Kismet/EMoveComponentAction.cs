namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetSystemLibrary.h")]
///<summary>Enum used to indicate desired behavior for MoveComponentTo latent function.</summary>
[CppEnumInNamespace]
public enum EMoveComponentAction {
	Move=0,
	Stop=1,
	Return=2,
}
