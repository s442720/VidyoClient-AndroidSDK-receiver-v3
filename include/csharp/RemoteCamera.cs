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
	public class RemoteCamera{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoRemoteCamera reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteCameraAddToLocalRendererNative(IntPtr c, IntPtr localRenderer, [MarshalAs(UnmanagedType.I4)]RemoteCameraMode mode);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteCameraConstructCopyNative(IntPtr other);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraControlPTZNudgeNative(IntPtr c, int pan, int tilt, int zoom);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraControlPTZStartNative(IntPtr c, [MarshalAs(UnmanagedType.I4)]CameraControlCapabilities.CameraControlDirection direction, ulong timeout);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraControlPTZStopNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRemoteCameraDestructNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteCameraGetControlCapabilitiesNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteCameraGetIdNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteCameraGetLocalRenderingStreamIdNative(IntPtr c, int index);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteCameraGetNameNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern RemoteCameraPosition VidyoRemoteCameraGetPositionNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraIsControllableNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraRegisterFrameSizeListenerNative(IntPtr c, OnFrameSizeUpdate onFrameSizeUpdate);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraRemoveFromLocalRendererNative(IntPtr c, IntPtr localRenderer);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraSetPositionInLocalRendererNative(IntPtr c, IntPtr localRenderer, int x, int y, uint width, uint height, ulong frameInterval);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraShowCameraControlNative(IntPtr c, Boolean show);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoRemoteCameraUnregisterFrameSizeListenerNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoRemoteCameraGetUserDataNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoRemoteCameraSetUserDataNative(IntPtr obj, IntPtr userData);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnFrameSizeUpdate(IntPtr c, ulong width, ulong height);
		private OnFrameSizeUpdate _mOnFrameSizeUpdate;
		public enum RemoteCameraMode{
			RemotecameramodeDynamic,
			RemotecameramodeStatic
		}
		public enum RemoteCameraPosition{
			RemotecamerapositionUnknown,
			RemotecamerapositionFront,
			RemotecamerapositionBack
		}
		public interface IRegisterFrameSizeListener{

			void OnFrameSizeUpdate(ulong width, ulong height);
		}
		private IRegisterFrameSizeListener _mIRegisterFrameSizeListener;
		public RemoteCamera(IntPtr other){
			objPtr = VidyoRemoteCameraConstructCopyNative(other);
			VidyoRemoteCameraSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~RemoteCamera(){
			if(objPtr != IntPtr.Zero){
				VidyoRemoteCameraSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoRemoteCameraDestructNative(objPtr);
			}
		}
		public ulong AddToLocalRenderer(LocalRenderer localRenderer, RemoteCameraMode mode){

			ulong ret = VidyoRemoteCameraAddToLocalRendererNative(objPtr, (localRenderer != null) ? localRenderer.GetObjectPtr():IntPtr.Zero, mode);

			return ret;
		}
		public Boolean ControlPTZNudge(int pan, int tilt, int zoom){

			Boolean ret = VidyoRemoteCameraControlPTZNudgeNative(objPtr, pan, tilt, zoom);

			return ret;
		}
		public Boolean ControlPTZStart(CameraControlCapabilities.CameraControlDirection direction, ulong timeout){

			Boolean ret = VidyoRemoteCameraControlPTZStartNative(objPtr, direction, timeout);

			return ret;
		}
		public Boolean ControlPTZStop(){

			Boolean ret = VidyoRemoteCameraControlPTZStopNative(objPtr);

			return ret;
		}
		public CameraControlCapabilities GetControlCapabilities(){

			IntPtr ret = VidyoRemoteCameraGetControlCapabilitiesNative(objPtr);
			CameraControlCapabilities csRet = new CameraControlCapabilities(ret);

			return csRet;
		}
		public String GetId(){

			IntPtr ret = VidyoRemoteCameraGetIdNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public ulong GetLocalRenderingStreamId(int index){

			ulong ret = VidyoRemoteCameraGetLocalRenderingStreamIdNative(objPtr, index);

			return ret;
		}
		public String GetName(){

			IntPtr ret = VidyoRemoteCameraGetNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public RemoteCameraPosition GetPosition(){

			RemoteCameraPosition ret = VidyoRemoteCameraGetPositionNative(objPtr);

			return ret;
		}
		public Boolean IsControllable(){

			Boolean ret = VidyoRemoteCameraIsControllableNative(objPtr);

			return ret;
		}
		public Boolean RegisterFrameSizeListener(IRegisterFrameSizeListener _iIRegisterFrameSizeListener){
			_mIRegisterFrameSizeListener = _iIRegisterFrameSizeListener;
			_mOnFrameSizeUpdate = OnFrameSizeUpdateDelegate;

			Boolean ret = VidyoRemoteCameraRegisterFrameSizeListenerNative(objPtr, _mOnFrameSizeUpdate);

			return ret;
		}
		public Boolean RemoveFromLocalRenderer(LocalRenderer localRenderer){

			Boolean ret = VidyoRemoteCameraRemoveFromLocalRendererNative(objPtr, (localRenderer != null) ? localRenderer.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean SetPositionInLocalRenderer(LocalRenderer localRenderer, int x, int y, uint width, uint height, ulong frameInterval){

			Boolean ret = VidyoRemoteCameraSetPositionInLocalRendererNative(objPtr, (localRenderer != null) ? localRenderer.GetObjectPtr():IntPtr.Zero, x, y, width, height, frameInterval);

			return ret;
		}
		public Boolean ShowCameraControl(Boolean show){

			Boolean ret = VidyoRemoteCameraShowCameraControlNative(objPtr, show);

			return ret;
		}
		public Boolean UnregisterFrameSizeListener(){

			Boolean ret = VidyoRemoteCameraUnregisterFrameSizeListenerNative(objPtr);

			return ret;
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnFrameSizeUpdate))]
#endif
		private static void OnFrameSizeUpdateDelegate(IntPtr c, ulong width, ulong height){
			RemoteCamera csC = null;
			if(c != IntPtr.Zero){
				if(RemoteCamera.VidyoRemoteCameraGetUserDataNative(c) == IntPtr.Zero)
					csC = new RemoteCamera(c);
				else{
					GCHandle objHandle = (GCHandle)RemoteCamera.VidyoRemoteCameraGetUserDataNative(c);
					csC = (RemoteCamera)objHandle.Target;
				}
			}
			if(csC._mIRegisterFrameSizeListener != null)
				csC._mIRegisterFrameSizeListener.OnFrameSizeUpdate(width, height);
		}
	};
}