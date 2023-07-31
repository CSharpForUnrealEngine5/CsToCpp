#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPathTracingRayTypeSwitch.h")]
public partial class UMaterialExpressionPathTracingRayTypeSwitch : UMaterialExpression {
	///<summary>Used for camera rays (or for non-path traced shading)</summary>
	public FExpressionInput Main;
	///<summary>Used by the path tracer on shadow rays (this only applies for non-opaque blend modes)</summary>
	public FExpressionInput Shadow;
	///<summary>Used by the path tracer on indirect diffuse rays</summary>
	public FExpressionInput IndirectDiffuse;
	///<summary>Used by the path tracer on indirect specular rays</summary>
	public FExpressionInput IndirectSpecular;
	///<summary>Used by the path tracer on indirect volume rays</summary>
	public FExpressionInput IndirectVolume;
}
