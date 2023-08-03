#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UE specific: The base class for all Children in a Child List Node, whereas the standard refers to them as &#39;Parametric Objects&#39;.</summary>
[CppInclude("MVR/Types/DMXMVRParametricObjectNodeBase.h")]
public partial class UDMXMVRParametricObjectNodeBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The unique identifier of the object.</summary>
	public FGuid UUID;
	///<summary>The location of the object inside the parent coordinate system.</summary>
	public FDMXOptionalTransform Matrix;
}
