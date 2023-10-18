namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterfaces/OptimusDataInterfaceRawBuffer.h")]
///<summary>Write to buffer operation types.</summary>
public enum EOptimusBufferWriteType {
	Write=0,
	WriteAtomicAdd=1,
	WriteAtomicMin=2,
	WriteAtomicMax=3,
	Count=4,
}
