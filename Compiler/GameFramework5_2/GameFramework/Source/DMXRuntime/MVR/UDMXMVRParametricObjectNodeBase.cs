#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVR/Types/DMXMVRParametricObjectNodeBase.h")]
///<summary>UE specific: The base class for all Children in a Child List Node, whereas the standard refers to them as 'Parametric Objects'.</summary>
public partial class UDMXMVRParametricObjectNodeBase : UObject {
// DMXMVRParametricObjectNodeBase
	public FGuid UUID;
	public FDMXOptionalTransform Matrix;
}
