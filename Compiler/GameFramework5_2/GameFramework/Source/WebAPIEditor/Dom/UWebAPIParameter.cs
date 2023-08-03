#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A re-usable Parameter.</summary>
[CppInclude("Dom/WebAPIParameter.h")]
public partial class UWebAPIParameter : UWebAPIModel {
	public static UClass StaticClass() {return default;}
	///<summary>Where this parameter is stored/encoded in the request.</summary>
	public EWebAPIParameterStorage Storage;
	///<summary>The optional media-type, ie. &quot;application/json&quot;.</summary>
	public string MediaType;
	///<summary>Optional model definition.</summary>
	public UWebAPIModel Model;
	///<summary>If the property is an array of Type.</summary>
	public bool bIsArray;
	///<summary>Single value property that this Parameter wraps.</summary>
	public UWebAPIProperty Property;
}
