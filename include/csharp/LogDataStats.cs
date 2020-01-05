// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2016 Vidyo, Inc. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace VidyoClient
{
	public class LogDataStatsFactory
	{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLogDataStatsConstructDefaultNative();
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLogDataStatsDestructNative(IntPtr obj);
		public static LogDataStats Create()
		{
			IntPtr objPtr = VidyoLogDataStatsConstructDefaultNative();
			return new LogDataStats(objPtr);
		}
		public static void Destroy(LogDataStats obj)
		{
			VidyoLogDataStatsDestructNative(obj.GetObjectPtr());
		}
	}
	public class LogDataStats{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoLogDataStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogDataStatsGetnameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLogDataStatsGetoccurancesNative(IntPtr obj);

		public String name;
		public uint occurances;
		public LogDataStats(IntPtr obj){
			objPtr = obj;

			name = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogDataStatsGetnameNative(objPtr));
			occurances = VidyoLogDataStatsGetoccurancesNative(objPtr);
		}
	};
}