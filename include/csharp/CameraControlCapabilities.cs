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
	public class CameraControlCapabilitiesFactory
	{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoCameraControlCapabilitiesConstructDefaultNative();
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoCameraControlCapabilitiesDestructNative(IntPtr obj);
		public static CameraControlCapabilities Create()
		{
			IntPtr objPtr = VidyoCameraControlCapabilitiesConstructDefaultNative();
			return new CameraControlCapabilities(objPtr);
		}
		public static void Destroy(CameraControlCapabilities obj)
		{
			VidyoCameraControlCapabilitiesDestructNative(obj.GetObjectPtr());
		}
	}
	public class CameraControlCapabilities{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoCameraControlCapabilities reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGethasPhotoCaptureNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetpanTiltHasContinuousMoveNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetpanTiltHasNudgeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetpanTiltHasRubberBandNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetzoomHasNudgeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetzoomHasRubberBandNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoCameraControlCapabilitiesGetzooomHasContinuousMoveNative(IntPtr obj);

		public enum CameraControlDirection{
			CameracontroldirectionPanLeft,
			CameracontroldirectionPanRight,
			CameracontroldirectionTiltUp,
			CameracontroldirectionTiltDown,
			CameracontroldirectionZoomIn,
			CameracontroldirectionZoomOut
		}
		public Boolean hasPhotoCapture;
		public Boolean panTiltHasContinuousMove;
		public Boolean panTiltHasNudge;
		public Boolean panTiltHasRubberBand;
		public Boolean zoomHasNudge;
		public Boolean zoomHasRubberBand;
		public Boolean zooomHasContinuousMove;
		public CameraControlCapabilities(IntPtr obj){
			objPtr = obj;

			hasPhotoCapture = VidyoCameraControlCapabilitiesGethasPhotoCaptureNative(objPtr);
			panTiltHasContinuousMove = VidyoCameraControlCapabilitiesGetpanTiltHasContinuousMoveNative(objPtr);
			panTiltHasNudge = VidyoCameraControlCapabilitiesGetpanTiltHasNudgeNative(objPtr);
			panTiltHasRubberBand = VidyoCameraControlCapabilitiesGetpanTiltHasRubberBandNative(objPtr);
			zoomHasNudge = VidyoCameraControlCapabilitiesGetzoomHasNudgeNative(objPtr);
			zoomHasRubberBand = VidyoCameraControlCapabilitiesGetzoomHasRubberBandNative(objPtr);
			zooomHasContinuousMove = VidyoCameraControlCapabilitiesGetzooomHasContinuousMoveNative(objPtr);
		}
	};
}