/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class NatPunchthroughClient : PluginInterface2 {
  private HandleRef swigCPtr;

  internal NatPunchthroughClient(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.NatPunchthroughClient_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NatPunchthroughClient obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughClient() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatPunchthroughClient(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static NatPunchthroughClient GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.NatPunchthroughClient_GetInstance();
    NatPunchthroughClient ret = (cPtr == IntPtr.Zero) ? null : new NatPunchthroughClient(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(NatPunchthroughClient i) {
    RakNetPINVOKE.NatPunchthroughClient_DestroyInstance(NatPunchthroughClient.getCPtr(i));
  }

  public NatPunchthroughClient() : this(RakNetPINVOKE.new_NatPunchthroughClient(), true) {
  }

  public bool OpenNAT(RakNetGUID destination, SystemAddress facilitator) {
    bool ret = RakNetPINVOKE.NatPunchthroughClient_OpenNAT(swigCPtr, RakNetGUID.getCPtr(destination), SystemAddress.getCPtr(facilitator));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool OpenNATGroup(RakNetGUID destination, SystemAddress facilitator) {
    bool ret = RakNetPINVOKE.NatPunchthroughClient_OpenNATGroup(swigCPtr, RakNetGUID.getCPtr(destination), SystemAddress.getCPtr(facilitator));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PunchthroughConfiguration GetPunchthroughConfiguration() {
    IntPtr cPtr = RakNetPINVOKE.NatPunchthroughClient_GetPunchthroughConfiguration(swigCPtr);
    PunchthroughConfiguration ret = (cPtr == IntPtr.Zero) ? null : new PunchthroughConfiguration(cPtr, false);
    return ret;
  }

  public void SetDebugInterface(NatPunchthroughDebugInterface i) {
    RakNetPINVOKE.NatPunchthroughClient_SetDebugInterface(swigCPtr, NatPunchthroughDebugInterface.getCPtr(i));
  }

  public virtual void GetGuidsForGroupPunchthroughRequest(RakNetGUID excludeThisGuid, RakNetListRakNetGUID guids) {
    RakNetPINVOKE.NatPunchthroughClient_GetGuidsForGroupPunchthroughRequest(swigCPtr, RakNetGUID.getCPtr(excludeThisGuid), RakNetListRakNetGUID.getCPtr(guids));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetUPNPPortMappings(string externalPort, string internalPort, SystemAddress natPunchthroughServerAddress) {
    RakNetPINVOKE.NatPunchthroughClient_GetUPNPPortMappings(swigCPtr, externalPort, internalPort, SystemAddress.getCPtr(natPunchthroughServerAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    RakNetPINVOKE.NatPunchthroughClient_Clear(swigCPtr);
  }

}

}
