namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/CylinderBuilder.h")]
public partial class UCylinderBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>Distance from base to tip of cylinder</summary>
	public float Z;
	///<summary>Radius of cylinder</summary>
	public float OuterRadius;
	///<summary>Radius of inner cylinder (when hollow)</summary>
	public float InnerRadius;
	///<summary>How many sides this cylinder should have</summary>
	public int Sides;
	///<summary>GroupName</summary>
	public FName GroupName;
	///<summary>Whether to align the brush to a face</summary>
	public bool AlignToSide;
	///<summary>Whether this is a hollow or solid cylinder</summary>
	public bool Hollow;
}
