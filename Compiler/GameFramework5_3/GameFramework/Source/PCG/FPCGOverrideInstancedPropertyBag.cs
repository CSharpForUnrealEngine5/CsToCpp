namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extended version of FInstancedPropertyBag, to support overrides and have a custom UI for it</summary>
[CppInclude("PCGGraph.h")]
public partial struct FPCGOverrideInstancedPropertyBag {
	public FInstancedPropertyBag Parameters;
	public TSet<FGuid> PropertiesIDsOverridden;
}
