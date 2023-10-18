namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Zero-centered 3D Fractal noise in 1, 2, 3 or 4 channels, created by summing several</summary>
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionFractal3D.h")]
public partial class UMaterialExpressionMaterialXFractal3D : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The name of a vector3-type node specifying the 3D position at which the noise is evaluated. By default the vector is in local space</summary>
	public FExpressionInput Position;
	///<summary>Defaults to &#39;ConstAmplitude&#39; if not specified</summary>
	public FExpressionInput Amplitude;
	///<summary>only used if Amplitude is not hooked up</summary>
	public float ConstAmplitude;
	///<summary>Defaults to &#39;ConstOctaves&#39; if not specified</summary>
	public FExpressionInput Octaves;
	///<summary>only used if Octaves is not hooked up</summary>
	public int ConstOctaves;
	///<summary>Defaults to &#39;ConstLacunarity&#39; if not specified</summary>
	public FExpressionInput Lacunarity;
	///<summary>only used if Lacunarity is not hooked up</summary>
	public float ConstLacunarity;
	///<summary>Defaults to &#39;ConstDiminish&#39; if not specified</summary>
	public FExpressionInput Diminish;
	///<summary>only used if Diminish is not hooked up</summary>
	public float ConstDiminish;
	///<summary>can also be done with a multiply on the Position</summary>
	public float Scale;
	///<summary>How multiple frequencies are getting combined</summary>
	public bool bTurbulence;
	///<summary>1 = fast but little detail, .. larger numbers cost more performance</summary>
	public int Levels;
	///<summary>OutputMin</summary>
	public float OutputMin;
	///<summary>OutputMax</summary>
	public float OutputMax;
}
