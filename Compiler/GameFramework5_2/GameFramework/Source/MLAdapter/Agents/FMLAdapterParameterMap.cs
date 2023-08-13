namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides a serializable mapping from parameter name to value that is used to configure sensors &amp; actuators.</summary>
[CppInclude("Agents/MLAdapterAgent.h")]
public partial struct FMLAdapterParameterMap {
	public TMap<string,string> Params;
}
