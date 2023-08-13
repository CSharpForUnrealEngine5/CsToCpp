namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CloudStorageBase.h")]
///<summary>All the types of delegate callbacks that a CloudStorage subclass may receive from C++</summary>
public enum ECloudStorageDelegate {
	CSD_KeyValueReadComplete=0,
	CSD_KeyValueWriteComplete=1,
	CSD_ValueChanged=2,
	CSD_DocumentQueryComplete=3,
	CSD_DocumentReadComplete=4,
	CSD_DocumentWriteComplete=5,
	CSD_DocumentConflictDetected=6,
	CSD_MAX=7,
}
