#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a node sampling from the ARCore Passthrough external texture.</summary>
[CppInclude("MaterialExpressionGoogleARCorePassthroughCamera.h")]
public partial class UDEPRECATED_MaterialExpressionGoogleARCorePassthroughCamera : UMaterialExpression {
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>only used if Coordinates are not hooked up.</summary>
	public uint ConstCoordinate;
}
