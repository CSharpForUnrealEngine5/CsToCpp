using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class USoundSubmixBase : UObject {
    }

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class USoundSubmixWithParentBase : USoundSubmixBase {
    }

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class USoundSubmix : USoundSubmixWithParentBase {
    }

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class USoundfieldSubmix : USoundSubmixWithParentBase {
    }

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class UEndpointSubmix : USoundSubmixBase {
    }

    [CppInclude("Sound/SoundSubmix.h")]
    public partial class USoundfieldEndpointSubmix : USoundSubmixBase {
    }

}