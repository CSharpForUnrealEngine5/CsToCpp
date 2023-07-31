#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a device input / output.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOConfiguration {
	public bool bIsInput;
	public FMediaIOConnection MediaConnection;
	public FMediaIOMode MediaMode;
}
