namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the standard transformation of a widget</summary>
[CppInclude("Slate/WidgetTransform.h")]
public partial struct FWidgetTransform {
	public FVector2D Translation;
	public FVector2D Scale;
	public FVector2D Shear;
	public float Angle;
}
