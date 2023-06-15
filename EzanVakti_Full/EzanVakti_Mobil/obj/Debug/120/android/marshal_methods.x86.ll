; ModuleID = 'obj\Debug\120\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\120\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [188 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 52
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 73
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 5
	i32 52239042, ; 3: HtmlAgilityPack => 0x31d1ac2 => 1
	i32 108920425, ; 4: Xamarin.AndroidX.AppCompat.Resources.dll => 0x67dfe69 => 28
	i32 134690465, ; 5: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 77
	i32 165246403, ; 6: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 33
	i32 209399409, ; 7: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 31
	i32 230216969, ; 8: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 48
	i32 232815796, ; 9: System.Web.Services => 0xde07cb4 => 91
	i32 261689757, ; 10: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 36
	i32 278686392, ; 11: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 51
	i32 280482487, ; 12: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 47
	i32 318968648, ; 13: Xamarin.AndroidX.Activity.dll => 0x13031348 => 23
	i32 321597661, ; 14: System.Numerics => 0x132b30dd => 18
	i32 342366114, ; 15: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 49
	i32 347068432, ; 16: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 9
	i32 385762202, ; 17: System.Memory.dll => 0x16fe439a => 15
	i32 441335492, ; 18: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 35
	i32 442521989, ; 19: Xamarin.Essentials => 0x1a605985 => 70
	i32 450948140, ; 20: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 46
	i32 465846621, ; 21: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 22: System.dll => 0x1bff388e => 13
	i32 476646585, ; 23: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 47
	i32 486930444, ; 24: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 56
	i32 526420162, ; 25: System.Transactions.dll => 0x1f6088c2 => 83
	i32 527452488, ; 26: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 77
	i32 605376203, ; 27: System.IO.Compression.FileSystem => 0x24154ecb => 87
	i32 627609679, ; 28: Xamarin.AndroidX.CustomView => 0x2568904f => 41
	i32 643868501, ; 29: System.Net => 0x2660a755 => 16
	i32 663517072, ; 30: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 67
	i32 666292255, ; 31: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 29
	i32 690569205, ; 32: System.Xml.Linq.dll => 0x29293ff5 => 92
	i32 691348768, ; 33: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 79
	i32 700284507, ; 34: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 74
	i32 720511267, ; 35: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 78
	i32 748832960, ; 36: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 7
	i32 775507847, ; 37: System.IO.Compression => 0x2e394f87 => 86
	i32 790371945, ; 38: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 42
	i32 809851609, ; 39: System.Drawing.Common.dll => 0x30455ad9 => 85
	i32 843511501, ; 40: Xamarin.AndroidX.Print => 0x3246f6cd => 58
	i32 928116545, ; 41: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 73
	i32 955402788, ; 42: Newtonsoft.Json => 0x38f24a24 => 5
	i32 956575887, ; 43: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 78
	i32 963428712, ; 44: Xamarin.AndroidX.AppCompat.Resources => 0x396cc168 => 28
	i32 967690846, ; 45: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 49
	i32 1012816738, ; 46: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 61
	i32 1031528504, ; 47: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 72
	i32 1035644815, ; 48: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 27
	i32 1052210849, ; 49: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 53
	i32 1084122840, ; 50: Xamarin.Kotlin.StdLib => 0x409e66d8 => 76
	i32 1098259244, ; 51: System => 0x41761b2c => 13
	i32 1175144683, ; 52: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 65
	i32 1204270330, ; 53: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 29
	i32 1264511973, ; 54: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 62
	i32 1267360935, ; 55: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 66
	i32 1275534314, ; 56: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 79
	i32 1292207520, ; 57: SQLitePCLRaw.core.dll => 0x4d0585a0 => 8
	i32 1293217323, ; 58: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 44
	i32 1365406463, ; 59: System.ServiceModel.Internals.dll => 0x516272ff => 90
	i32 1376866003, ; 60: Xamarin.AndroidX.SavedState => 0x52114ed3 => 61
	i32 1406073936, ; 61: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 37
	i32 1411638395, ; 62: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 20
	i32 1462112819, ; 63: System.IO.Compression.dll => 0x57261233 => 86
	i32 1469204771, ; 64: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 26
	i32 1582372066, ; 65: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 43
	i32 1592978981, ; 66: System.Runtime.Serialization.dll => 0x5ef2ee25 => 89
	i32 1597949149, ; 67: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 72
	i32 1622152042, ; 68: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 55
	i32 1624863272, ; 69: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 69
	i32 1636350590, ; 70: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 40
	i32 1639515021, ; 71: System.Net.Http.dll => 0x61b9038d => 17
	i32 1657153582, ; 72: System.Runtime => 0x62c6282e => 21
	i32 1658241508, ; 73: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 63
	i32 1658251792, ; 74: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 71
	i32 1670060433, ; 75: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 36
	i32 1698840827, ; 76: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 75
	i32 1711441057, ; 77: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 9
	i32 1729485958, ; 78: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 32
	i32 1776026572, ; 79: System.Core.dll => 0x69dc03cc => 12
	i32 1788241197, ; 80: Xamarin.AndroidX.Fragment => 0x6a96652d => 46
	i32 1808609942, ; 81: Xamarin.AndroidX.Loader => 0x6bcd3296 => 55
	i32 1813058853, ; 82: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 76
	i32 1813201214, ; 83: Xamarin.Google.Android.Material => 0x6c13413e => 71
	i32 1867746548, ; 84: Xamarin.Essentials.dll => 0x6f538cf4 => 70
	i32 1885316902, ; 85: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 30
	i32 1919157823, ; 86: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 57
	i32 1983156543, ; 87: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 75
	i32 2011961780, ; 88: System.Buffers.dll => 0x77ec19b4 => 11
	i32 2019465201, ; 89: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 53
	i32 2055257422, ; 90: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 50
	i32 2079903147, ; 91: System.Runtime.dll => 0x7bf8cdab => 21
	i32 2090596640, ; 92: System.Numerics.Vectors => 0x7c9bf920 => 19
	i32 2103459038, ; 93: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 10
	i32 2162456754, ; 94: EzanVakti_Mobil.dll => 0x80e478b2 => 0
	i32 2188064486, ; 95: System.Json.dll => 0x826b36e6 => 14
	i32 2201107256, ; 96: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 80
	i32 2201231467, ; 97: System.Net.Http => 0x8334206b => 17
	i32 2217644978, ; 98: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 65
	i32 2244775296, ; 99: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 56
	i32 2256548716, ; 100: Xamarin.AndroidX.MultiDex => 0x8680336c => 57
	i32 2279755925, ; 101: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 60
	i32 2315684594, ; 102: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 24
	i32 2465273461, ; 103: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 7
	i32 2465532216, ; 104: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 35
	i32 2471841756, ; 105: netstandard.dll => 0x93554fdc => 81
	i32 2475788418, ; 106: Java.Interop.dll => 0x93918882 => 2
	i32 2501346920, ; 107: System.Data.DataSetExtensions => 0x95178668 => 84
	i32 2505896520, ; 108: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 52
	i32 2581819634, ; 109: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 66
	i32 2605712449, ; 110: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 80
	i32 2620871830, ; 111: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 40
	i32 2624644809, ; 112: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 45
	i32 2633051222, ; 113: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 51
	i32 2701096212, ; 114: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 63
	i32 2732626843, ; 115: Xamarin.AndroidX.Activity => 0xa2e0939b => 23
	i32 2737747696, ; 116: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 26
	i32 2770495804, ; 117: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 74
	i32 2778768386, ; 118: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 68
	i32 2810250172, ; 119: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 37
	i32 2819470561, ; 120: System.Xml.dll => 0xa80db4e1 => 22
	i32 2853208004, ; 121: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 68
	i32 2855708567, ; 122: Xamarin.AndroidX.Transition => 0xaa36a797 => 64
	i32 2887636118, ; 123: System.Net.dll => 0xac1dd496 => 16
	i32 2903344695, ; 124: System.ComponentModel.Composition => 0xad0d8637 => 88
	i32 2905242038, ; 125: mscorlib.dll => 0xad2a79b6 => 4
	i32 2916838712, ; 126: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 69
	i32 2919462931, ; 127: System.Numerics.Vectors.dll => 0xae037813 => 19
	i32 2921128767, ; 128: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 25
	i32 2978675010, ; 129: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 44
	i32 3016983068, ; 130: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 62
	i32 3024354802, ; 131: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 48
	i32 3111772706, ; 132: System.Runtime.Serialization => 0xb979e222 => 89
	i32 3201217166, ; 133: System.Json => 0xbeceb28e => 14
	i32 3204380047, ; 134: System.Data.dll => 0xbefef58f => 82
	i32 3211777861, ; 135: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 43
	i32 3247949154, ; 136: Mono.Security => 0xc197c562 => 93
	i32 3258312781, ; 137: Xamarin.AndroidX.CardView => 0xc235e84d => 32
	i32 3286872994, ; 138: SQLite-net.dll => 0xc3e9b3a2 => 6
	i32 3317135071, ; 139: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 41
	i32 3317144872, ; 140: System.Data => 0xc5b79d28 => 82
	i32 3340431453, ; 141: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 30
	i32 3345895724, ; 142: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 59
	i32 3360279109, ; 143: SQLitePCLRaw.core => 0xc849ca45 => 8
	i32 3362522851, ; 144: Xamarin.AndroidX.Core => 0xc86c06e3 => 39
	i32 3366347497, ; 145: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 146: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 60
	i32 3395150330, ; 147: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 20
	i32 3404865022, ; 148: System.ServiceModel.Internals => 0xcaf21dfe => 90
	i32 3405233483, ; 149: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 42
	i32 3429136800, ; 150: System.Xml => 0xcc6479a0 => 22
	i32 3430777524, ; 151: netstandard => 0xcc7d82b4 => 81
	i32 3441283291, ; 152: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 45
	i32 3476120550, ; 153: Mono.Android => 0xcf3163e6 => 3
	i32 3486566296, ; 154: System.Transactions => 0xcfd0c798 => 83
	i32 3493954962, ; 155: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 34
	i32 3509114376, ; 156: System.Xml.Linq => 0xd128d608 => 92
	i32 3567349600, ; 157: System.ComponentModel.Composition.dll => 0xd4a16f60 => 88
	i32 3627220390, ; 158: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 58
	i32 3633644679, ; 159: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 25
	i32 3641597786, ; 160: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 50
	i32 3672681054, ; 161: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3676310014, ; 162: System.Web.Services.dll => 0xdb2009fe => 91
	i32 3682565725, ; 163: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 31
	i32 3684561358, ; 164: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 34
	i32 3689375977, ; 165: System.Drawing.Common => 0xdbe768e9 => 85
	i32 3706696989, ; 166: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 38
	i32 3718780102, ; 167: Xamarin.AndroidX.Annotation => 0xdda814c6 => 24
	i32 3754567612, ; 168: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 10
	i32 3786282454, ; 169: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 33
	i32 3810220126, ; 170: HtmlAgilityPack.dll => 0xe31b585e => 1
	i32 3829621856, ; 171: System.Numerics.dll => 0xe4436460 => 18
	i32 3876362041, ; 172: SQLite-net => 0xe70c9739 => 6
	i32 3885922214, ; 173: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 64
	i32 3888767677, ; 174: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 59
	i32 3896760992, ; 175: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 39
	i32 3920810846, ; 176: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 87
	i32 3921031405, ; 177: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 67
	i32 3945713374, ; 178: System.Data.DataSetExtensions.dll => 0xeb2ecede => 84
	i32 3955647286, ; 179: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 27
	i32 3977364195, ; 180: EzanVakti_Mobil => 0xed11c2e3 => 0
	i32 4025784931, ; 181: System.Memory => 0xeff49a63 => 15
	i32 4105002889, ; 182: Mono.Security.dll => 0xf4ad5f89 => 93
	i32 4151237749, ; 183: System.Core => 0xf76edc75 => 12
	i32 4182413190, ; 184: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 54
	i32 4256097574, ; 185: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 38
	i32 4260525087, ; 186: System.Buffers => 0xfdf2741f => 11
	i32 4292120959 ; 187: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 54
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [188 x i32] [
	i32 52, i32 73, i32 5, i32 1, i32 28, i32 77, i32 33, i32 31, ; 0..7
	i32 48, i32 91, i32 36, i32 51, i32 47, i32 23, i32 18, i32 49, ; 8..15
	i32 9, i32 15, i32 35, i32 70, i32 46, i32 4, i32 13, i32 47, ; 16..23
	i32 56, i32 83, i32 77, i32 87, i32 41, i32 16, i32 67, i32 29, ; 24..31
	i32 92, i32 79, i32 74, i32 78, i32 7, i32 86, i32 42, i32 85, ; 32..39
	i32 58, i32 73, i32 5, i32 78, i32 28, i32 49, i32 61, i32 72, ; 40..47
	i32 27, i32 53, i32 76, i32 13, i32 65, i32 29, i32 62, i32 66, ; 48..55
	i32 79, i32 8, i32 44, i32 90, i32 61, i32 37, i32 20, i32 86, ; 56..63
	i32 26, i32 43, i32 89, i32 72, i32 55, i32 69, i32 40, i32 17, ; 64..71
	i32 21, i32 63, i32 71, i32 36, i32 75, i32 9, i32 32, i32 12, ; 72..79
	i32 46, i32 55, i32 76, i32 71, i32 70, i32 30, i32 57, i32 75, ; 80..87
	i32 11, i32 53, i32 50, i32 21, i32 19, i32 10, i32 0, i32 14, ; 88..95
	i32 80, i32 17, i32 65, i32 56, i32 57, i32 60, i32 24, i32 7, ; 96..103
	i32 35, i32 81, i32 2, i32 84, i32 52, i32 66, i32 80, i32 40, ; 104..111
	i32 45, i32 51, i32 63, i32 23, i32 26, i32 74, i32 68, i32 37, ; 112..119
	i32 22, i32 68, i32 64, i32 16, i32 88, i32 4, i32 69, i32 19, ; 120..127
	i32 25, i32 44, i32 62, i32 48, i32 89, i32 14, i32 82, i32 43, ; 128..135
	i32 93, i32 32, i32 6, i32 41, i32 82, i32 30, i32 59, i32 8, ; 136..143
	i32 39, i32 2, i32 60, i32 20, i32 90, i32 42, i32 22, i32 81, ; 144..151
	i32 45, i32 3, i32 83, i32 34, i32 92, i32 88, i32 58, i32 25, ; 152..159
	i32 50, i32 3, i32 91, i32 31, i32 34, i32 85, i32 38, i32 24, ; 160..167
	i32 10, i32 33, i32 1, i32 18, i32 6, i32 64, i32 59, i32 39, ; 168..175
	i32 87, i32 67, i32 84, i32 27, i32 0, i32 15, i32 93, i32 12, ; 176..183
	i32 54, i32 38, i32 11, i32 54 ; 184..187
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
