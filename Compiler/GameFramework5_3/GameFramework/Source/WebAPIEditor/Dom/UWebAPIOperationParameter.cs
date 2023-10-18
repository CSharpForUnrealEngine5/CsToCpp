namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIOperation.h")]
public partial class UWebAPIOperationParameter : UWebAPIProperty {
	public static UClass StaticClass() {return default;}
	///<summary>Where this parameter is stored/encoded in the request.</summary>
	public EWebAPIParameterStorage Storage;
	///<summary>The optional media-type, ie. &quot;application/json&quot;.</summary>
	public string MediaType;
	///<summary>Optional model definition.</summary>
	public UWebAPIModel Model;
}
