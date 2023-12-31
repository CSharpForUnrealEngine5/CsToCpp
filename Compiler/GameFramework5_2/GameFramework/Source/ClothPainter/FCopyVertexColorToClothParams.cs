namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct used for specifying options when copying vertex colors</summary>
[CppInclude("CopyVertexColorToClothParams.h")]
public partial struct FCopyVertexColorToClothParams {
	public ESourceColorChannel ColorChannel;
	public float ScalingFactor;
}
