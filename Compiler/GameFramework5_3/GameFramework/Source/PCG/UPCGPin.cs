namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial class UPCGPin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>~End UObject interface</summary>
	public UPCGNode Node;
	///<summary>Label_DEPRECATED</summary>
	public FName Label_DEPRECATED;
	///<summary>Edges</summary>
	public TArray<UPCGEdge> Edges;
	///<summary>Properties</summary>
	public FPCGPinProperties Properties;
	///<summary>GetTooltip</summary>
	public FText GetTooltip() { return default; }
	///<summary>SetTooltip</summary>
	public void SetTooltip(FText InTooltip) {}
}
