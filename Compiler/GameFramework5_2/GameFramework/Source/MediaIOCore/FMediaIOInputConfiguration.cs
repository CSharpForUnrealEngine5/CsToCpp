namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a device input.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOInputConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOInputType InputType;
	public int KeyPortIdentifier;
}
