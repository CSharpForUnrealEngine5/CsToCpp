namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/ConeBuilder.h")]
public partial class UConeBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>Distance from base to tip of cone</summary>
	public float Z;
	///<summary>Distance from base to the tip of inner cone (when hollow)</summary>
	public float CapZ;
	///<summary>Radius of cone</summary>
	public float OuterRadius;
	///<summary>Radius of inner cone (when hollow)</summary>
	public float InnerRadius;
	///<summary>How many sides this cone should have</summary>
	public int Sides;
	///<summary>GroupName</summary>
	public string GroupName;
	///<summary>Whether to align the brush to a face</summary>
	public bool AlignToSide;
	///<summary>Whether this is a hollow or solid cone</summary>
	public bool Hollow;
}
