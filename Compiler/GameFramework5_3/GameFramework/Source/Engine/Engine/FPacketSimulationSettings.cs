namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds the packet simulation settings in one place</summary>
[CppInclude("Engine/NetDriver.h")]
public partial struct FPacketSimulationSettings {
	public int PktLoss;
	public int PktLossMaxSize;
	public int PktLossMinSize;
	public int PktOrder;
	public int PktDup;
	public int PktLag;
	public int PktLagVariance;
	public int PktLagMin;
	public int PktLagMax;
	public int PktIncomingLagMin;
	public int PktIncomingLagMax;
	public int PktIncomingLoss;
	public int PktJitter;
}
