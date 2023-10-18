namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response Curve User Defined</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierResponseCurveUser : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>ResponseX</summary>
	public UCurveFloat ResponseX;
	///<summary>ResponseY</summary>
	public UCurveFloat ResponseY;
	///<summary>ResponseZ</summary>
	public UCurveFloat ResponseZ;
}
