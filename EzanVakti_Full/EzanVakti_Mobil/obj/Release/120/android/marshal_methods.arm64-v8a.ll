; ModuleID = 'obj\Release\120\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Release\120\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [94 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 3
	i64 232391251801502327, ; 1: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 31
	i64 870603111519317375, ; 2: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 9
	i64 872800313462103108, ; 3: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 24
	i64 964003131647442271, ; 4: HtmlAgilityPack => 0xd60d3bda035bd5f => 1
	i64 1000557547492888992, ; 5: Mono.Security.dll => 0xde2b1c9cba651a0 => 46
	i64 1120440138749646132, ; 6: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 33
	i64 1301485588176585670, ; 7: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 8
	i64 1425944114962822056, ; 8: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 44
	i64 1518315023656898250, ; 9: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 10
	i64 1731380447121279447, ; 10: Newtonsoft.Json => 0x18071957e9b889d7 => 5
	i64 1734003362181972388, ; 11: EzanVakti_Mobil => 0x18106adeea3081a4 => 0
	i64 1795316252682057001, ; 12: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 19
	i64 1836611346387731153, ; 13: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 31
	i64 1981742497975770890, ; 14: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 28
	i64 2064708342624596306, ; 15: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 39
	i64 2133195048986300728, ; 16: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 5
	i64 2262844636196693701, ; 17: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 24
	i64 2329709569556905518, ; 18: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 27
	i64 2337758774805907496, ; 19: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 16
	i64 2547086958574651984, ; 20: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 18
	i64 2592350477072141967, ; 21: System.Xml.dll => 0x23f9e10627330e8f => 17
	i64 2624866290265602282, ; 22: mscorlib.dll => 0x246d65fbde2db8ea => 4
	i64 2783046991838674048, ; 23: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 16
	i64 3017704767998173186, ; 24: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 33
	i64 3178037552697925432, ; 25: EzanVakti_Mobil.dll => 0x2c1aa850f3695f38 => 0
	i64 3289520064315143713, ; 26: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 26
	i64 3344514922410554693, ; 27: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 42
	i64 3397747728761535915, ; 28: HtmlAgilityPack.dll => 0x2f27398ea938bdab => 1
	i64 3531994851595924923, ; 29: System.Numerics => 0x31042a9aade235bb => 15
	i64 3727469159507183293, ; 30: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 30
	i64 4337444564132831293, ; 31: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 7
	i64 4794310189461587505, ; 32: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 18
	i64 5203618020066742981, ; 33: Xamarin.Essentials => 0x4836f704f0e652c5 => 32
	i64 5451019430259338467, ; 34: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 21
	i64 5507995362134886206, ; 35: System.Core.dll => 0x4c705499688c873e => 12
	i64 6183170893902868313, ; 36: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 7
	i64 6401687960814735282, ; 37: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 27
	i64 6548213210057960872, ; 38: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 23
	i64 6589202984700901502, ; 39: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 34
	i64 6876862101832370452, ; 40: System.Xml.Linq => 0x5f6f85a57d108914 => 45
	i64 7488575175965059935, ; 41: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 45
	i64 7637365915383206639, ; 42: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 32
	i64 7654504624184590948, ; 43: System.Net.Http => 0x6a3a4366801b8264 => 14
	i64 7735352534559001595, ; 44: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 38
	i64 7820441508502274321, ; 45: System.Data => 0x6c87ca1e14ff8111 => 43
	i64 8083354569033831015, ; 46: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 26
	i64 8167236081217502503, ; 47: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8187640529827139739, ; 48: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 41
	i64 8398329775253868912, ; 49: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 20
	i64 8626175481042262068, ; 50: Java.Interop => 0x77b654e585b55834 => 2
	i64 8853378295825400934, ; 51: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 37
	i64 9324707631942237306, ; 52: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 19
	i64 9662334977499516867, ; 53: System.Numerics.dll => 0x8617827802b0cfc3 => 15
	i64 9808709177481450983, ; 54: Mono.Android.dll => 0x881f890734e555e7 => 3
	i64 9998632235833408227, ; 55: Mono.Security => 0x8ac2470b209ebae3 => 46
	i64 10038780035334861115, ; 56: System.Net.Http.dll => 0x8b50e941206af13b => 14
	i64 10226222362177979215, ; 57: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 39
	i64 10229024438826829339, ; 58: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 23
	i64 10321854143672141184, ; 59: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 36
	i64 10406448008575299332, ; 60: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 42
	i64 10430153318873392755, ; 61: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 22
	i64 11023048688141570732, ; 62: System.Core => 0x98f9bc61168392ac => 12
	i64 11037814507248023548, ; 63: System.Xml => 0x992e31d0412bf7fc => 17
	i64 11071824625609515081, ; 64: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 34
	i64 11739066727115742305, ; 65: SQLite-net.dll => 0xa2e98afdf8575c61 => 6
	i64 11806260347154423189, ; 66: SQLite-net => 0xa3d8433bc5eb5d95 => 6
	i64 12102847907131387746, ; 67: System.Buffers => 0xa7f5f40c43256f62 => 11
	i64 12279246230491828964, ; 68: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 10
	i64 12451044538927396471, ; 69: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 25
	i64 12466513435562512481, ; 70: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 29
	i64 12828192437253469131, ; 71: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 40
	i64 13370592475155966277, ; 72: System.Runtime.Serialization => 0xb98de304062ea945 => 44
	i64 13404347523447273790, ; 73: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 20
	i64 13454009404024712428, ; 74: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 35
	i64 13465488254036897740, ; 75: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 38
	i64 13572454107664307259, ; 76: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 30
	i64 13647894001087880694, ; 77: System.Data.dll => 0xbd670f48cb071df6 => 43
	i64 13828521679616088467, ; 78: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 37
	i64 13959074834287824816, ; 79: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 25
	i64 14792063746108907174, ; 80: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 35
	i64 15279429628684179188, ; 81: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 41
	i64 15370334346939861994, ; 82: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 22
	i64 15609085926864131306, ; 83: System.dll => 0xd89e9cf3334914ea => 13
	i64 16154507427712707110, ; 84: System => 0xe03056ea4e39aa26 => 13
	i64 16423015068819898779, ; 85: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 40
	i64 16621146507174665210, ; 86: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 21
	i64 16755018182064898362, ; 87: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 8
	i64 16833383113903931215, ; 88: mscorlib => 0xe99c30c1484d7f4f => 4
	i64 17704177640604968747, ; 89: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 29
	i64 17710060891934109755, ; 90: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 28
	i64 17838668724098252521, ; 91: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 11
	i64 17891337867145587222, ; 92: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 36
	i64 18370042311372477656 ; 93: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 9
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [94 x i32] [
	i32 3, i32 31, i32 9, i32 24, i32 1, i32 46, i32 33, i32 8, ; 0..7
	i32 44, i32 10, i32 5, i32 0, i32 19, i32 31, i32 28, i32 39, ; 8..15
	i32 5, i32 24, i32 27, i32 16, i32 18, i32 17, i32 4, i32 16, ; 16..23
	i32 33, i32 0, i32 26, i32 42, i32 1, i32 15, i32 30, i32 7, ; 24..31
	i32 18, i32 32, i32 21, i32 12, i32 7, i32 27, i32 23, i32 34, ; 32..39
	i32 45, i32 45, i32 32, i32 14, i32 38, i32 43, i32 26, i32 2, ; 40..47
	i32 41, i32 20, i32 2, i32 37, i32 19, i32 15, i32 3, i32 46, ; 48..55
	i32 14, i32 39, i32 23, i32 36, i32 42, i32 22, i32 12, i32 17, ; 56..63
	i32 34, i32 6, i32 6, i32 11, i32 10, i32 25, i32 29, i32 40, ; 64..71
	i32 44, i32 20, i32 35, i32 38, i32 30, i32 43, i32 37, i32 25, ; 72..79
	i32 35, i32 41, i32 22, i32 13, i32 13, i32 40, i32 21, i32 8, ; 80..87
	i32 4, i32 29, i32 28, i32 11, i32 36, i32 9 ; 88..93
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
