#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TextWidgetTypes.h")]
///<summary>Common data for all widgets that use shaped text.</summary>
public partial struct FShapedTextOptions {
// ShapedTextOptions
	public bool bOverride_TextShapingMethod;
	public bool bOverride_TextFlowDirection;
	public ETextShapingMethod TextShapingMethod;
	public ETextFlowDirection TextFlowDirection;
}
