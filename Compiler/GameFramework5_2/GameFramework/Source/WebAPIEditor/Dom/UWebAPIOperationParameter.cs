#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperationParameter : UWebAPIProperty {
	///<summary>Where this parameter is stored/encoded in the request.</summary>
	public EWebAPIParameterStorage Storage;
	///<summary>The optional media-type, ie. &quot;application/json&quot;.</summary>
	public string MediaType;
	///<summary>Optional model definition.</summary>
	public UWebAPIModel Model;
}
