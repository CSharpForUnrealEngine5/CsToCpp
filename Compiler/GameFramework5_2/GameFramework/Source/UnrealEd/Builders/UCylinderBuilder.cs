#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/CylinderBuilder.h")]
public partial class UCylinderBuilder : UEditorBrushBuilder {
	///<summary>Distance from base to tip of cylinder</summary>
	public float Z;
	///<summary>Radius of cylinder</summary>
	public float OuterRadius;
	///<summary>Radius of inner cylinder (when hollow)</summary>
	public float InnerRadius;
	///<summary>How many sides this cylinder should have</summary>
	public int Sides;
	///<summary>GroupName</summary>
	public string GroupName;
	///<summary>Whether to align the brush to a face</summary>
	public bool AlignToSide;
	///<summary>Whether this is a hollow or solid cylinder</summary>
	public bool Hollow;
}
