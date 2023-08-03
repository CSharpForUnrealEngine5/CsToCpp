#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scalar</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierScalar : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Detail customization to only show modifiable axes for the relevant binding? This thing has no idea what it&#39;s bound to...</summary>
	public FVector Scalar;
}
