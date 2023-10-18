namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/TetrahedronBuilder.h")]
public partial class UTetrahedronBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>The radius of this sphere</summary>
	public float Radius;
	///<summary>How many iterations this sphere uses to tessellate its geometry</summary>
	public int SphereExtrapolation;
	///<summary>GroupName</summary>
	public FName GroupName;
}
