; ModuleID = 'obj\Release\120\android\compressed_assemblies.armeabi-v7a.ll'
source_filename = "obj\Release\120\android\compressed_assemblies.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [459264 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [163328 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [169472 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [1688576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [121856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [690176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [100352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [5120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [46080 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [5120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [35328 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [14752 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [376832 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [747008 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [223232 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [38912 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [7168 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [65024 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [1591808 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [859648 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [67072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [369664 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [531456 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [366592 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [466432 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [9728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [41984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [206848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [29184 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [37376 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [320512 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [14336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [49152 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [93696 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_37 = internal global [75264 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_38 = internal global [23448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_39 = internal global [152984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_40 = internal global [15240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_41 = internal global [15296 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_42 = internal global [15240 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_43 = internal global [2214296 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_44 = internal global [26504 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_45 = internal global [536984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_46 = internal global [2039808 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [47 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 459264, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([459264 x i8], [459264 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 163328, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([163328 x i8], [163328 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 169472, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([169472 x i8], [169472 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 1688576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1688576 x i8], [1688576 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 121856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([121856 x i8], [121856 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 690176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([690176 x i8], [690176 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 100352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([100352 x i8], [100352 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 46080, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([46080 x i8], [46080 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 35328, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([35328 x i8], [35328 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 14752, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14752 x i8], [14752 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 376832, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([376832 x i8], [376832 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 747008, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([747008 x i8], [747008 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 223232, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([223232 x i8], [223232 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 38912, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([38912 x i8], [38912 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 7168, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([7168 x i8], [7168 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 65024, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([65024 x i8], [65024 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 1591808, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1591808 x i8], [1591808 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 859648, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([859648 x i8], [859648 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 67072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([67072 x i8], [67072 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 369664, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([369664 x i8], [369664 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 531456, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([531456 x i8], [531456 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 366592, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([366592 x i8], [366592 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 466432, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([466432 x i8], [466432 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 9728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9728 x i8], [9728 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 41984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([41984 x i8], [41984 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 206848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([206848 x i8], [206848 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 29184, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29184 x i8], [29184 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 37376, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([37376 x i8], [37376 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 320512, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([320512 x i8], [320512 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 14336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14336 x i8], [14336 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 49152, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([49152 x i8], [49152 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 93696, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([93696 x i8], [93696 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}, 
	; 37
	%struct.CompressedAssemblyDescriptor {
		i32 75264, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([75264 x i8], [75264 x i8]* @__CompressedAssemblyDescriptor_data_37, i32 0, i32 0); data
	}, 
	; 38
	%struct.CompressedAssemblyDescriptor {
		i32 23448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([23448 x i8], [23448 x i8]* @__CompressedAssemblyDescriptor_data_38, i32 0, i32 0); data
	}, 
	; 39
	%struct.CompressedAssemblyDescriptor {
		i32 152984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152984 x i8], [152984 x i8]* @__CompressedAssemblyDescriptor_data_39, i32 0, i32 0); data
	}, 
	; 40
	%struct.CompressedAssemblyDescriptor {
		i32 15240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15240 x i8], [15240 x i8]* @__CompressedAssemblyDescriptor_data_40, i32 0, i32 0); data
	}, 
	; 41
	%struct.CompressedAssemblyDescriptor {
		i32 15296, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15296 x i8], [15296 x i8]* @__CompressedAssemblyDescriptor_data_41, i32 0, i32 0); data
	}, 
	; 42
	%struct.CompressedAssemblyDescriptor {
		i32 15240, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15240 x i8], [15240 x i8]* @__CompressedAssemblyDescriptor_data_42, i32 0, i32 0); data
	}, 
	; 43
	%struct.CompressedAssemblyDescriptor {
		i32 2214296, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2214296 x i8], [2214296 x i8]* @__CompressedAssemblyDescriptor_data_43, i32 0, i32 0); data
	}, 
	; 44
	%struct.CompressedAssemblyDescriptor {
		i32 26504, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26504 x i8], [26504 x i8]* @__CompressedAssemblyDescriptor_data_44, i32 0, i32 0); data
	}, 
	; 45
	%struct.CompressedAssemblyDescriptor {
		i32 536984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([536984 x i8], [536984 x i8]* @__CompressedAssemblyDescriptor_data_45, i32 0, i32 0); data
	}, 
	; 46
	%struct.CompressedAssemblyDescriptor {
		i32 2039808, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2039808 x i8], [2039808 x i8]* @__CompressedAssemblyDescriptor_data_46, i32 0, i32 0); data
	}
], align 4; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 47, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([47 x %struct.CompressedAssemblyDescriptor], [47 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 4


!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
