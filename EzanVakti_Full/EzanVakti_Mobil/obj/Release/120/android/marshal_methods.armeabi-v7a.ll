; ModuleID = 'obj\Release\120\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\120\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [94 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 35
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 5
	i32 52239042, ; 2: HtmlAgilityPack => 0x31d1ac2 => 1
	i32 134690465, ; 3: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 39
	i32 261689757, ; 4: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 21
	i32 318968648, ; 5: Xamarin.AndroidX.Activity.dll => 0x13031348 => 18
	i32 321597661, ; 6: System.Numerics => 0x132b30dd => 15
	i32 342366114, ; 7: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 26
	i32 347068432, ; 8: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 9
	i32 441335492, ; 9: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 20
	i32 442521989, ; 10: Xamarin.Essentials => 0x1a605985 => 32
	i32 450948140, ; 11: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 25
	i32 465846621, ; 12: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 13: System.dll => 0x1bff388e => 13
	i32 527452488, ; 14: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 39
	i32 627609679, ; 15: Xamarin.AndroidX.CustomView => 0x2568904f => 23
	i32 690569205, ; 16: System.Xml.Linq.dll => 0x29293ff5 => 45
	i32 691348768, ; 17: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 41
	i32 700284507, ; 18: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 36
	i32 720511267, ; 19: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 40
	i32 748832960, ; 20: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 7
	i32 928116545, ; 21: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 35
	i32 955402788, ; 22: Newtonsoft.Json => 0x38f24a24 => 5
	i32 956575887, ; 23: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 40
	i32 967690846, ; 24: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 26
	i32 1012816738, ; 25: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 31
	i32 1031528504, ; 26: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 34
	i32 1035644815, ; 27: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 19
	i32 1052210849, ; 28: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 28
	i32 1084122840, ; 29: Xamarin.Kotlin.StdLib => 0x409e66d8 => 38
	i32 1098259244, ; 30: System => 0x41761b2c => 13
	i32 1275534314, ; 31: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 41
	i32 1292207520, ; 32: SQLitePCLRaw.core.dll => 0x4d0585a0 => 8
	i32 1293217323, ; 33: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 24
	i32 1376866003, ; 34: Xamarin.AndroidX.SavedState => 0x52114ed3 => 31
	i32 1411638395, ; 35: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 16
	i32 1592978981, ; 36: System.Runtime.Serialization.dll => 0x5ef2ee25 => 44
	i32 1597949149, ; 37: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 34
	i32 1622152042, ; 38: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 29
	i32 1639515021, ; 39: System.Net.Http.dll => 0x61b9038d => 14
	i32 1658251792, ; 40: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 33
	i32 1670060433, ; 41: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 21
	i32 1698840827, ; 42: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 37
	i32 1711441057, ; 43: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 9
	i32 1776026572, ; 44: System.Core.dll => 0x69dc03cc => 12
	i32 1788241197, ; 45: Xamarin.AndroidX.Fragment => 0x6a96652d => 25
	i32 1808609942, ; 46: Xamarin.AndroidX.Loader => 0x6bcd3296 => 29
	i32 1813058853, ; 47: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 38
	i32 1813201214, ; 48: Xamarin.Google.Android.Material => 0x6c13413e => 33
	i32 1867746548, ; 49: Xamarin.Essentials.dll => 0x6f538cf4 => 32
	i32 1983156543, ; 50: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 37
	i32 2011961780, ; 51: System.Buffers.dll => 0x77ec19b4 => 11
	i32 2019465201, ; 52: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 28
	i32 2055257422, ; 53: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 27
	i32 2103459038, ; 54: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 10
	i32 2162456754, ; 55: EzanVakti_Mobil.dll => 0x80e478b2 => 0
	i32 2201107256, ; 56: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 42
	i32 2201231467, ; 57: System.Net.Http => 0x8334206b => 14
	i32 2279755925, ; 58: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 30
	i32 2465273461, ; 59: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 7
	i32 2465532216, ; 60: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 20
	i32 2475788418, ; 61: Java.Interop.dll => 0x93918882 => 2
	i32 2605712449, ; 62: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 42
	i32 2732626843, ; 63: Xamarin.AndroidX.Activity => 0xa2e0939b => 18
	i32 2770495804, ; 64: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 36
	i32 2819470561, ; 65: System.Xml.dll => 0xa80db4e1 => 17
	i32 2905242038, ; 66: mscorlib.dll => 0xad2a79b6 => 4
	i32 2978675010, ; 67: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 24
	i32 3111772706, ; 68: System.Runtime.Serialization => 0xb979e222 => 44
	i32 3204380047, ; 69: System.Data.dll => 0xbefef58f => 43
	i32 3247949154, ; 70: Mono.Security => 0xc197c562 => 46
	i32 3286872994, ; 71: SQLite-net.dll => 0xc3e9b3a2 => 6
	i32 3317135071, ; 72: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 23
	i32 3317144872, ; 73: System.Data => 0xc5b79d28 => 43
	i32 3360279109, ; 74: SQLitePCLRaw.core => 0xc849ca45 => 8
	i32 3362522851, ; 75: Xamarin.AndroidX.Core => 0xc86c06e3 => 22
	i32 3366347497, ; 76: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 77: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 30
	i32 3395150330, ; 78: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 16
	i32 3429136800, ; 79: System.Xml => 0xcc6479a0 => 17
	i32 3476120550, ; 80: Mono.Android => 0xcf3163e6 => 3
	i32 3509114376, ; 81: System.Xml.Linq => 0xd128d608 => 45
	i32 3641597786, ; 82: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 27
	i32 3672681054, ; 83: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3754567612, ; 84: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 10
	i32 3810220126, ; 85: HtmlAgilityPack.dll => 0xe31b585e => 1
	i32 3829621856, ; 86: System.Numerics.dll => 0xe4436460 => 15
	i32 3876362041, ; 87: SQLite-net => 0xe70c9739 => 6
	i32 3896760992, ; 88: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 22
	i32 3955647286, ; 89: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 19
	i32 3977364195, ; 90: EzanVakti_Mobil => 0xed11c2e3 => 0
	i32 4105002889, ; 91: Mono.Security.dll => 0xf4ad5f89 => 46
	i32 4151237749, ; 92: System.Core => 0xf76edc75 => 12
	i32 4260525087 ; 93: System.Buffers => 0xfdf2741f => 11
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [94 x i32] [
	i32 35, i32 5, i32 1, i32 39, i32 21, i32 18, i32 15, i32 26, ; 0..7
	i32 9, i32 20, i32 32, i32 25, i32 4, i32 13, i32 39, i32 23, ; 8..15
	i32 45, i32 41, i32 36, i32 40, i32 7, i32 35, i32 5, i32 40, ; 16..23
	i32 26, i32 31, i32 34, i32 19, i32 28, i32 38, i32 13, i32 41, ; 24..31
	i32 8, i32 24, i32 31, i32 16, i32 44, i32 34, i32 29, i32 14, ; 32..39
	i32 33, i32 21, i32 37, i32 9, i32 12, i32 25, i32 29, i32 38, ; 40..47
	i32 33, i32 32, i32 37, i32 11, i32 28, i32 27, i32 10, i32 0, ; 48..55
	i32 42, i32 14, i32 30, i32 7, i32 20, i32 2, i32 42, i32 18, ; 56..63
	i32 36, i32 17, i32 4, i32 24, i32 44, i32 43, i32 46, i32 6, ; 64..71
	i32 23, i32 43, i32 8, i32 22, i32 2, i32 30, i32 16, i32 17, ; 72..79
	i32 3, i32 45, i32 27, i32 3, i32 10, i32 1, i32 15, i32 6, ; 80..87
	i32 22, i32 19, i32 0, i32 46, i32 12, i32 11 ; 88..93
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
