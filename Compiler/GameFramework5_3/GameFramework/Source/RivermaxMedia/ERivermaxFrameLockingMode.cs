namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RivermaxMediaOutput.h")]
///<summary>Controls how rivermax capture behaves when there are no buffers available to capture into</summary>
public enum ERivermaxFrameLockingMode {
	FreeRun=0,
	BlockOnReservation=1,
}
