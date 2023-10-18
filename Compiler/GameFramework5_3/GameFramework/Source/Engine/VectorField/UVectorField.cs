namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VectorField/VectorField.h")]
public partial class UVectorField : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bounds of the volume in local space.</summary>
	public FBox Bounds;
	///<summary>The intensity with which to multiplie vectors in this field.</summary>
	public float Intensity;
}
