namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Every actor is hashed when it is saved so we can quickly check whether an actor has changed.</summary>
[CppInclude("Data/Hashing/ActorSnapshotHash.h")]
public partial struct FActorSnapshotHash {
	public double MicroSecondsForCrc;
	public double MicroSecondsForMD5;
	public int Crc32DataLength;
	public int MD5DataLength;
	public uint Crc32;
}
