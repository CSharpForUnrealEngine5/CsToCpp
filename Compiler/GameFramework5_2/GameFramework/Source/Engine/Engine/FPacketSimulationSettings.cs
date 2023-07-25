#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/NetDriver.h")]
///<summary>Holds the packet simulation settings in one place</summary>
public partial struct FPacketSimulationSettings {
// PacketSimulationSettings
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
