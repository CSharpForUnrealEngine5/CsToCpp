#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusResourceDescription.h")]
public partial class UOptimusResourceDescription : UObject {
	///<summary>ResourceName</summary>
	public string ResourceName;
	///<summary>The the data type of each element of the resource</summary>
	public FOptimusDataTypeRef DataType;
	///<summary>The component binding that this resource description is bound to</summary>
	public TWeakObjectPtr<UOptimusComponentSourceBinding> ComponentBinding;
	///<summary>The data domain for this resource.</summary>
	public FOptimusDataDomain DataDomain;
	///<summary>DataInterface</summary>
	public UOptimusPersistentBufferDataInterface DataInterface;
}
