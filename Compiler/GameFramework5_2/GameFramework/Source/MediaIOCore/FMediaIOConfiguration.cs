namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a device input / output.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOConfiguration {
	public bool bIsInput;
	public FMediaIOConnection MediaConnection;
	public FMediaIOMode MediaMode;
}
