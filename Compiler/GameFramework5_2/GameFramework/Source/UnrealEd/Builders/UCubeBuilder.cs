namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/CubeBuilder.h")]
public partial class UCubeBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>The size of the cube in the X dimension</summary>
	public float X;
	///<summary>The size of the cube in the Y dimension</summary>
	public float Y;
	///<summary>The size of the cube in the Z dimension</summary>
	public float Z;
	///<summary>The thickness of the cube wall when hollow</summary>
	public float WallThickness;
	///<summary>GroupName</summary>
	public FName GroupName;
	///<summary>Whether this is a hollow or solid cube</summary>
	public bool Hollow;
	///<summary>Whether extra internal faces should be generated for each cube face</summary>
	public bool Tessellated;
}
