#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial class UPCGPin : UObject {
// PCGPin
	public UPCGNode Node;
	public string Label_DEPRECATED;
	public TArray<UPCGEdge> Edges;
	public FPCGPinProperties Properties;
	public string GetTooltip() { return default; }
	public void SetTooltip(string InTooltip) {}
}
