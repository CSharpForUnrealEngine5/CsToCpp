namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common data for all widgets that use shaped text.</summary>
[CppInclude("Components/TextWidgetTypes.h")]
public partial struct FShapedTextOptions {
	public bool bOverride_TextShapingMethod;
	public bool bOverride_TextFlowDirection;
	public ETextShapingMethod TextShapingMethod;
	public ETextFlowDirection TextFlowDirection;
}
