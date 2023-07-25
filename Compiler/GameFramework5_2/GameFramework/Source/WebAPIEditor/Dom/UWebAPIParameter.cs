#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dom/WebAPIParameter.h")]
///<summary>A re-usable Parameter.</summary>
public partial class UWebAPIParameter : UWebAPIModel {
// WebAPIParameter
	public EWebAPIParameterStorage Storage;
	public string MediaType;
	public UWebAPIModel Model;
	public bool bIsArray;
	public UWebAPIProperty Property;
}
