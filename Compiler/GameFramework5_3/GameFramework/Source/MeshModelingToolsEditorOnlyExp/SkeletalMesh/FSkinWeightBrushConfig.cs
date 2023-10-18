namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>for saveing/restoring the brush settings separately for each brush mode (Add, Replace, etc...)</summary>
[CppInclude("SkeletalMesh/SkinWeightsPaintTool.h")]
public partial struct FSkinWeightBrushConfig {
	public float Strength;
	public float Radius;
	public float Falloff;
	public EWeightBrushFalloffMode FalloffMode;
}
