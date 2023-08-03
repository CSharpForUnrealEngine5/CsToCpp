#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial class UPCGPin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>~End UObject interface</summary>
	public UPCGNode Node;
	///<summary>Label_DEPRECATED</summary>
	public string Label_DEPRECATED;
	///<summary>Edges</summary>
	public TArray<UPCGEdge> Edges;
	///<summary>Properties</summary>
	public FPCGPinProperties Properties;
	///<summary>GetTooltip</summary>
	public  string GetTooltip() { return default; }
	///<summary>SetTooltip</summary>
	public  void SetTooltip(string InTooltip) {}
}
