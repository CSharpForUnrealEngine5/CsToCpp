#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGGraph.h")]
///<summary>Extended version of FInstancedPropertyBag, to support overrides and have a custom UI for it</summary>
public partial struct FPCGOverrideInstancedPropertyBag {
// PCGOverrideInstancedPropertyBag
	public FInstancedPropertyBag Parameters;
	public TSet<FGuid> PropertiesIDsOverridden;
}
