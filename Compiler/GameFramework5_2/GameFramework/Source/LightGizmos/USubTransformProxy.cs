#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* A sub-class of UTransformProxy that adds support for sub-proxies that can be attached</summary>
[CppInclude("SubTransformProxy.h")]
public partial class USubTransformProxy : UTransformProxy {
	public static UClass StaticClass() {return default;}
	///<summary>The relative transform of this SubTransformProxy if it is attached to a parent SubTransformProxy</summary>
	public FTransform RelativeTransform;
}
